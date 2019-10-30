using System;
using System.Collections.Generic;
using System.Text;

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
            lastResult = resources.GetResourceListForType(SpvcResourceType.UniformBuffer, out var cbuffers, ref size);

            for (ulong i = 0; i < (ulong)cbuffers.Length; ++i)
            {
                var shaderResource = new ShaderResource(SpvcResourceType.UniformBuffer);
                shaderResource.Name = cbuffers[i].Name;
                shaderResource.TypeId = cbuffers[i].Id;
                var spvcType = compiler.GetTypeHandle(cbuffers[i].Base_type_id);

                shaderResource.SlotId = compiler.GetDecoration(cbuffers[i].Id, AdamantiumVulkan.SPIRV.SpvDecoration.Binding);
                ulong tmpSize = 0;
                lastResult = compiler.GetDeclaredStructSize(spvcType, ref tmpSize);
                shaderResource.Size = tmpSize;

                var membersCount = spvcType.GetNumMemberTypes();
                for (uint k = 0; k < membersCount; ++k)
                {
                    var member = new ShaderResourceMember();
                    var memberType = spvcType.GetMemberType(k);
                    member.TypeId = memberType;
                    ulong typeSize = 0;
                    lastResult = compiler.GetDeclaredStructMemberSize(spvcType, k, ref typeSize);
                    member.Size = typeSize;
                    uint offset = 0;
                    lastResult = compiler.TypeStructMemberOffset(spvcType, k, ref offset);
                    member.Offset = offset;
                    member.Name = compiler.GetMemberName(cbuffers[i].Base_type_id, k);
                    uint stride = 0;
                    lastResult = compiler.TypeStructMemberArrayStride(spvcType, k, ref stride);
                    member.ArrayStride = stride;
                    lastResult = compiler.TypeStructMemberMatrixStride(spvcType, k, ref stride);
                    member.MatrixStride = stride;

                    shaderResource.AddMember(member);

                    //Console.WriteLine($"MemberType = {memberType}, Size = {typeSize}, Offset = {offset}, Name = {name}");
                }

                disassembleResult.AddShaderResource(shaderResource);
            }

            return disassembleResult;
        }
    }
}
