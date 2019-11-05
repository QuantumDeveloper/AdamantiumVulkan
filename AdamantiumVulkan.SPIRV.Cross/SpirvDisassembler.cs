using System.Collections.Generic;

namespace AdamantiumVulkan.SPIRV.Cross
{
    public static class SpirvResultHelper
    {
        public static void CheckResult(SpvcResult result, string methodName)
        {
            if (result != SpvcResult.Success)
            {
                throw new ResultException($"Result of function {methodName} was not success. Function Returns {result}");
            }
        }
    }

    public class SpirvDisassembler
    {
        private SpvcContext context;
        private SpvcCompiler compiler;
        private SpvcParsedIr parsedIr;
        private SpvcResources resources;
        private SpvcSet set;
        private SpvcResult lastResult;

        private static List<SpvcResourceType> resourcesToDisassemble;

        static SpirvDisassembler()
        {
            resourcesToDisassemble = new List<SpvcResourceType>();
            resourcesToDisassemble.Add(SpvcResourceType.UniformBuffer);
            resourcesToDisassemble.Add(SpvcResourceType.SeparateSamplers);
            resourcesToDisassemble.Add(SpvcResourceType.SeparateImage);
            resourcesToDisassemble.Add(SpvcResourceType.SampledImage);
            resourcesToDisassemble.Add(SpvcResourceType.StorageImage);
            resourcesToDisassemble.Add(SpvcResourceType.StorageBuffer);
        }

        public SpirvDisassembler(byte[] byteCode)
        {
            lastResult = SpvcContext.Create(out context);
            SpirvResultHelper.CheckResult(lastResult, "SpvcContext::Create");
            lastResult = context.ParseSpirv(byteCode, (ulong)byteCode.Length / 4, out parsedIr);
            SpirvResultHelper.CheckResult(lastResult, "SpvcContext::ParseSpirv");
        }

        public SpirvDisassemblerResult Disassemble(SpvcBackend backend)
        {
            lastResult = context.CreateCompiler(backend, parsedIr, SpvcCaptureMode.TakeOwnership, out compiler);
            SpirvResultHelper.CheckResult(lastResult, "SpvcContext::CreateCompiler");
            lastResult = compiler.GetActiveInterfaceVariables(out set);
            SpirvResultHelper.CheckResult(lastResult, "SpvcCompiler::GetActiveInterfaceVariables");
            lastResult = compiler.CreateShaderResourcesForActiveVariables(out resources, set);
            ulong size = 0;

            var disassembleResult = new SpirvDisassemblerResult();

            foreach (var resourceType in resourcesToDisassemble)
            {
                lastResult = resources.GetResourceListForType(resourceType, out var shaderResources, ref size);

                for (ulong i = 0; i < (ulong)shaderResources.Length; ++i)
                {
                    var shaderResource = new ShaderReflectionResource(resourceType);
                    shaderResource.Name = shaderResources[i].Name;
                    shaderResource.TypeId = shaderResources[i].Id;
                    var spvcType = compiler.GetTypeHandle(shaderResources[i].Base_type_id);
                    shaderResource.Type = spvcType.GetBasetype();

                    shaderResource.DescriptorSet = compiler.GetDecoration(shaderResources[i].Id, AdamantiumVulkan.SPIRV.SpvDecoration.Descriptorset);
                    shaderResource.SlotId = compiler.GetDecoration(shaderResources[i].Id, AdamantiumVulkan.SPIRV.SpvDecoration.Binding);

                    ulong tmpSize = 0;
                    lastResult = compiler.GetDeclaredStructSize(spvcType, ref tmpSize);
                    shaderResource.Size = tmpSize;

                    var membersCount = spvcType.GetNumMemberTypes();
                    for (uint k = 0; k < membersCount; ++k)
                    {
                        var member = new ShaderReflectionResourceMember();
                        var memberType = spvcType.GetMemberType(k);
                        member.TypeId = memberType;
                        var memberTypeHandle = compiler.GetTypeHandle(memberType);
                        member.Type = memberTypeHandle.GetBasetype();
                        ulong typeSize = 0;
                        lastResult = compiler.GetDeclaredStructMemberSize(spvcType, k, ref typeSize);
                        member.Size = typeSize;
                        uint offset = 0;
                        lastResult = compiler.TypeStructMemberOffset(spvcType, k, ref offset);
                        member.Offset = offset;
                        member.Name = compiler.GetMemberName(shaderResources[i].Base_type_id, k);
                        uint stride = 0;
                        lastResult = compiler.TypeStructMemberArrayStride(spvcType, k, ref stride);
                        member.ArrayStride = stride;
                        lastResult = compiler.TypeStructMemberMatrixStride(spvcType, k, ref stride);
                        member.MatrixStride = stride;

                        shaderResource.AddMember(member);
                    }

                    disassembleResult.AddShaderResource(shaderResource);
                }
            }

            return disassembleResult;
        }
    }
}
