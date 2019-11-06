using System.Collections.Generic;

namespace AdamantiumVulkan.SPIRV.Cross
{
    public class SpirvReflection
    {
        private SpvcContext context;
        private SpvcCompiler compiler;
        private SpvcParsedIr parsedIr;
        private SpvcResources resources;
        private SpvcSet set;
        private SpvcResult lastResult;

        private static readonly List<SpvcResourceType> resourcesToReflect;

        static SpirvReflection()
        {
            resourcesToReflect = new List<SpvcResourceType>
            {
                SpvcResourceType.UniformBuffer,
                SpvcResourceType.SeparateSamplers,
                SpvcResourceType.SeparateImage,
                SpvcResourceType.SampledImage,
                SpvcResourceType.StorageImage,
                SpvcResourceType.StorageBuffer,
                SpvcResourceType.AccelerationStructure
            };
        }

        public SpirvReflection(byte[] byteCode)
        {
            lastResult = SpvcContext.Create(out context);
            SpirvResultHelper.CheckResult(lastResult, "SpvcContext::Create");
            lastResult = context.ParseSpirv(byteCode, (ulong)byteCode.Length / 4, out parsedIr);
            SpirvResultHelper.CheckResult(lastResult, "SpvcContext::ParseSpirv");
        }

        public SpirvReflectionResult Disassemble(SpvcBackend backend)
        {
            lastResult = context.CreateCompiler(backend, parsedIr, SpvcCaptureMode.TakeOwnership, out compiler);
            SpirvResultHelper.CheckResult(lastResult, "SpvcContext::CreateCompiler");
            lastResult = compiler.GetActiveInterfaceVariables(out set);
            SpirvResultHelper.CheckResult(lastResult, "SpvcCompiler::GetActiveInterfaceVariables");
            lastResult = compiler.CreateShaderResourcesForActiveVariables(out resources, set);
            ulong size = 0;

            var disassembleResult = new SpirvReflectionResult();

            foreach (var resourceType in resourcesToReflect)
            {
                lastResult = resources.GetResourceListForType(resourceType, out var shaderResources, ref size);

                for (ulong i = 0; i < (ulong)shaderResources.Length; ++i)
                {
                    var shaderResource = new ShaderReflectionVariable(resourceType);
                    shaderResource.Name = shaderResources[i].Name;
                    shaderResource.TypeId = shaderResources[i].Id;
                    var spvcType = compiler.GetTypeHandle(shaderResources[i].Base_type_id);
                    shaderResource.Type = spvcType.GetBasetype();

                    shaderResource.DescriptorSet = compiler.GetDecoration(shaderResources[i].Id, AdamantiumVulkan.SPIRV.SpvDecoration.Descriptorset);
                    shaderResource.SlotIndex = compiler.GetDecoration(shaderResources[i].Id, AdamantiumVulkan.SPIRV.SpvDecoration.Binding);

                    ulong tmpSize = 0;
                    lastResult = compiler.GetDeclaredStructSize(spvcType, ref tmpSize);
                    shaderResource.Size = tmpSize;

                    shaderResource.ColumnsCount = spvcType.GetColumns();
                    shaderResource.ArrayDimensionsCount = spvcType.GetNumArrayDimensions();
                    for (var x = 0u; x < shaderResource.ArrayDimensionsCount; ++x)
                    {
                        shaderResource.AddArraySizeForDimension(x, spvcType.GetArrayDimension(x));
                    }

                    var membersCount = spvcType.GetNumMemberTypes();
                    for (uint k = 0; k < membersCount; ++k)
                    {
                        var member = new ShaderReflectionVariable(SpvcResourceType.UniformBuffer);
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
