using System;
using AdamantiumVulkan.SPIRV.Cross;
using System.Collections.Generic;
using AdamantiumVulkan.Shaders;

namespace AdamantiumVulkan.SPIRV.Reflection
{
    public class SpirvReflection : DisposableObject
    {
        private SpvcContext context;
        private SpvcCompiler compiler;
        private SpvcParsedIr parsedIr;
        private SpvcResources resources;
        private SpvcSet set;
        private SpvcResult lastResult;

        private static readonly List<SpvcResourceType> resourcesToReflect;

        private byte[] bytecode;
        private SpvcBackend reflectionBackend;

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

        public SpirvReflection(byte[] bytecode, SpvcBackend reflectionBackend = SpvcBackend.Hlsl)
        {
            if (bytecode == null || bytecode.Length == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(bytecode), "bytecode array should not be null or empty");
            }
            
            lastResult = SpvcContext.Create(out context);
            SpirvResultHelper.CheckResult(lastResult, "SpvcContext::Create");

            this.bytecode = bytecode;
            this.reflectionBackend = reflectionBackend;
        }
        
        public static CompilationResult CompileToSpirvBinary(string sourceText, ShadercShaderKind shaderKind, string inputFileName, string entryPointName, CompileOptions options = null)
        {
            var compiler = ShaderCompiler.New();
            var result = compiler.CompileIntoSpirv(sourceText, shaderKind, inputFileName, entryPointName, options);
            compiler.Dispose();
            return result;
        }
        
        public static CompilationResult CompileToSpirvAssembly(string sourceText, ShadercShaderKind shaderKind, string inputFileName, string entryPointName, CompileOptions options = null)
        {
            var compiler = ShaderCompiler.New();
            var result = compiler.CompileIntoSpirvAssembly(sourceText, shaderKind, inputFileName, entryPointName, options);
            compiler.Dispose();
            return result;
        }
        
        public static CompilationResult CompileIntoPreprocessedText(string sourceText, ShadercShaderKind shaderKind, string inputFileName, string entryPointName, CompileOptions options = null)
        {
            var compiler = ShaderCompiler.New();
            var result = compiler.CompileIntoPreprocessedText(sourceText, shaderKind, inputFileName, entryPointName, options);
            compiler.Dispose();
            return result;
        }

        public SpirvReflectionResult Disassemble()
        {
            lastResult = context.ParseSpirv(bytecode, (ulong)bytecode.Length / 4, out parsedIr);
            SpirvResultHelper.CheckResult(lastResult, "SpvcContext::ParseSpirv");
            lastResult = context.CreateCompiler(reflectionBackend, parsedIr, SpvcCaptureMode.TakeOwnership, out compiler);
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
                    var shaderResource = new ShaderReflectionResource();
                    var resourceDescription = new ShaderReflectionVariable(resourceType);
                    shaderResource.Description = resourceDescription;
                    
                    resourceDescription.Name = shaderResources[i].Name;
                    resourceDescription.TypeId = shaderResources[i].Id;
                    var spvcType = compiler.GetTypeHandle(shaderResources[i].Base_type_id);
                    resourceDescription.Type = spvcType.GetBasetype();

                    resourceDescription.DescriptorSet = compiler.GetDecoration(shaderResources[i].Id, SpvDecoration.DescriptorSet);
                    resourceDescription.SlotIndex = compiler.GetDecoration(shaderResources[i].Id, SpvDecoration.Binding);

                    ulong tmpSize = 0;
                    lastResult = compiler.GetDeclaredStructSize(spvcType, ref tmpSize);
                    resourceDescription.Size = tmpSize;

                    resourceDescription.RowCount = spvcType.GetColumns();
                    resourceDescription.ArrayDimensionsCount = spvcType.GetNumArrayDimensions();
                    for (var x = 0u; x < resourceDescription.ArrayDimensionsCount; ++x)
                    {
                        resourceDescription.AddArraySizeForDimension(x, spvcType.GetArrayDimension(x));
                    }

                    resourceDescription.Dimension = (ShaderResourceDimension)spvcType.GetImageDimension();

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

                        member.RowCount = spvcType.GetColumns();
                        member.ArrayDimensionsCount = spvcType.GetNumArrayDimensions();
                        for (var x = 0u; x < member.ArrayDimensionsCount; ++x)
                        {
                            member.AddArraySizeForDimension(x, spvcType.GetArrayDimension(x));
                        }

                        shaderResource.AddVariable(member);
                    }

                    disassembleResult.AddShaderResource(shaderResource);
                }
            }

            return disassembleResult;
        }

        protected override void UnmanagedDisposeOverride()
        {
            context.ReleaseAllocations();
            context.Destroy();
        }
    }
}
