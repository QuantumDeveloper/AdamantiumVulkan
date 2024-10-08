﻿using System;
using System.Collections.Generic;
using System.Linq;
using AdamantiumVulkan.Spirv.Cross;
using QuantumBinding.Utils;

namespace AdamantiumVulkan.Spirv.Reflection
{
    public class SpirvReflection : QBDisposableObject
    {
        private SpirvContext context;
        private SpirvCompiler compiler;
        private SpirvParsedIr parsedIr;
        private SpirvResources resources;
        private SpirvSet set;
        private Result lastResult;

        private static readonly List<ResourceType> resourcesToReflect;

        private byte[] bytecode;
        private Backend reflectionBackend;

        static SpirvReflection()
        {
            resourcesToReflect = new List<ResourceType>
            {
                ResourceType.UniformBuffer,
                ResourceType.SeparateSamplers,
                ResourceType.SeparateImage,
                ResourceType.SampledImage,
                ResourceType.StorageImage,
                ResourceType.StorageBuffer,
                ResourceType.AccelerationStructure,
                ResourceType.RayQuery
            };
        }

        public byte[] GetByteCode()
        {
            return bytecode;
        }

        public SpirvReflection(byte[] bytecode, Backend reflectionBackend = Backend.Hlsl)
        {
            if (bytecode == null || bytecode.Length == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(bytecode), "bytecode array should not be null or empty");
            }
            
            lastResult = SpirvContext.Create(out context);
            SpirvResultHelper.CheckResult(lastResult, "SpvcContext::Create");

            this.bytecode = bytecode;
            this.reflectionBackend = reflectionBackend;
        }
        
        public SpirvReflectionResult Disassemble(List<ResourceBindingKey> resourceKeys)
        {
            lastResult = context.ParseSpirv(bytecode, (ulong)bytecode.Length / 4, out parsedIr);
            SpirvResultHelper.CheckResult(lastResult, "SpvcContext::ParseSpirv");
            lastResult = context.CreateCompiler(reflectionBackend, parsedIr, CaptureMode.TakeOwnership, out compiler);
            SpirvResultHelper.CheckResult(lastResult, "SpvcContext::CreateCompiler");
            lastResult = compiler.GetActiveInterfaceVariables(out set);
            SpirvResultHelper.CheckResult(lastResult, "SpvcCompiler::GetActiveInterfaceVariables");
            lastResult = compiler.CreateShaderResourcesForActiveVariables(out resources, set);

            var disassembleResult = new SpirvReflectionResult();

            foreach (var resourceType in resourcesToReflect)
            {
                lastResult = resources.GetResourceListForType(resourceType, out var shaderResources, out var size);

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

                    var bindingKey = MakeResourceBindingKey(
                        resourceDescription.Name,
                        resourceDescription.TypeId,
                        resourceDescription.SlotIndex,
                        resourceDescription.DescriptorSet);
                    
                    if (IsSameResourceIdPresent(resourceKeys, bindingKey))
                    {
                        bindingKey = FindNextAvailableId(bindingKey, resourceKeys);
                        compiler.SetDecoration(shaderResources[i].Id, SpvDecoration.Binding, bindingKey.BindingId);
                        resourceKeys.Add(bindingKey);
                        resourceDescription.SlotIndex = bindingKey.BindingId;
                        uint offset = 0;
                        if (compiler.GetBinaryOffsetForDecoration(shaderResources[i].Id, SpvDecoration.Binding,
                            ref offset))
                        {
                            var ids = BitConverter.GetBytes(bindingKey.BindingId);
                            var byteOffset = offset * 4;
                            foreach (var id in ids)
                            {
                                bytecode[byteOffset++] = id;
                            }
                        }
                    }
                    else
                    {
                        resourceKeys.Add(bindingKey);
                    }

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
                        var memberType = spvcType.GetMemberType(k);
                        var member = new ShaderReflectionVariable(ResourceType.UniformBuffer);

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

                        //Get the number of rows in the type
                        member.RowCount = memberTypeHandle.GetVectorSize();
                        //Get the number of columns in the type
                        member.ColumnCount = memberTypeHandle.GetColumns();
                        member.ArrayDimensionsCount = memberTypeHandle.GetNumArrayDimensions();

                        if (member.RowCount == 1 && member.ColumnCount == 1)
                        {
                            member.VariableType = ShaderVariableClass.Scalar;
                        }
                        else if (member.RowCount > 1 && member.ColumnCount == 1)
                        {
                            member.VariableType = ShaderVariableClass.Vector;
                        }
                        else
                        {
                            if (compiler.HasMemberDecoration(shaderResources[i].Base_type_id, offset,
                                SpvDecoration.RowMajor))
                            {
                                member.VariableType = ShaderVariableClass.MatrixRows;
                            }
                            else if (compiler.HasMemberDecoration(shaderResources[i].Base_type_id, offset,
                                SpvDecoration.ColMajor))
                            {
                                member.VariableType = ShaderVariableClass.MatrixColumns;
                            }
                        }

                        if (member.Type == Basetype.Struct)
                        {
                            member.VariableType = ShaderVariableClass.Struct;
                        }
                        
                        for (var x = 0u; x < member.ArrayDimensionsCount; ++x)
                        {
                            member.AddArraySizeForDimension(x, spvcType.GetArrayDimension(x));
                        }

                        shaderResource.AddVariable(member);
                    }

                    disassembleResult.AddShaderResource(shaderResource);
                }
            }

            disassembleResult.Bytecode = bytecode;

            return disassembleResult;
        }

        private bool IsSameResourceIdPresent(List<ResourceBindingKey> resourceKeys, ResourceBindingKey current)
        {
            // We are looking for resource with same Binding Id, but different name
            // If names are the same and Binding Id also the same, it means that this resource is sharing
            // between several shaders
            
            foreach (var bindingKey in resourceKeys)
            {
                if (bindingKey.Name != current.Name &&
                    bindingKey.BindingId == current.BindingId &&
                    bindingKey.DescriptorSet == current.DescriptorSet)
                {
                    return true;
                }
                
            }

            return false;
        }

        private ResourceBindingKey MakeResourceBindingKey(string name, uint typeId, uint bindingId, uint descriptorSet)
        {
            return new ResourceBindingKey() { Name = name, TypeId = typeId, BindingId = bindingId, DescriptorSet = descriptorSet};
        }

        private ResourceBindingKey FindNextAvailableId(ResourceBindingKey key, List<ResourceBindingKey> bindingKeys)
        {
            var maxId = bindingKeys.Max(x => x.BindingId);
            key.BindingId = maxId + 1;
            return key;
        }

        protected override void UnmanagedDisposeOverride()
        {
            context?.ReleaseAllocations();
            context?.Destroy();
        }
    }
}
