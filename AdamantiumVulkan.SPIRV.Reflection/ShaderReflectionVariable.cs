using System.Collections.Generic;
using AdamantiumVulkan.SPIRV.Cross;

namespace AdamantiumVulkan.SPIRV.Reflection
{
    public class ShaderReflectionVariable
    {
        public ShaderReflectionVariable(SpvcResourceType resourceType)
        {
            Class = resourceType;
            dimensionToArraySize = new Dictionary<uint, uint>();
        }

        public string Name { get; internal set; }
        
        public ulong Size { get; internal set; }

        public uint Offset { get; internal set; }

        public uint SlotIndex { get; internal set; }

        public uint DescriptorSet { get; internal set; }

        public SpvcResourceType Class { get; internal set; }

        public SpvcBasetype Type { get; internal set; }

        public ShaderResourceDimension Dimension { get; internal set; }

        public uint ArrayStride { get; internal set; }

        public uint ArrayDimensionsCount { get; internal set; }

        public uint MatrixStride { get; internal set; }

        public uint RowCount { get; internal set; }

        public uint ElementCount
        {
            get
            {
                if (ArrayDimensionsCount == 0)
                    return 1;

                uint totalElementCount = 1;
                for (uint i = 0; i < ArrayDimensionsCount; ++i)
                {
                    totalElementCount *= GetArraySizeForDimension(i);
                }

                return totalElementCount;
            }
            
        }

        public uint TypeId { get; internal set; }
        
        private Dictionary<uint, uint> dimensionToArraySize;
        
        public uint GetArraySizeForDimension(uint dim)
        {
            dimensionToArraySize.TryGetValue(dim, out var size);
            return size;
        }

        public void AddArraySizeForDimension(uint dimension, uint arraySize)
        {
            dimensionToArraySize[dimension] = arraySize;
        }
        
        public override string ToString()
        {
            return $"{Class}, {Name}, Size = {Size}, StartOffset = {Offset} SlotId = {SlotIndex}, DescriptorSet = {DescriptorSet},  TypeId = {TypeId}";
        }
    }
}