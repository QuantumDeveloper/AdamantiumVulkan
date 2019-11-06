using System.Collections.Generic;

namespace AdamantiumVulkan.SPIRV.Cross
{
    public class ShaderReflectionVariable
    {
        private List<ShaderReflectionVariable> members;
        private Dictionary<uint, uint> dimensionToArraySize;

        public ShaderReflectionVariable(SpvcResourceType resourceClass)
        {
            Class = resourceClass;
            members = new List<ShaderReflectionVariable>();
            dimensionToArraySize = new Dictionary<uint, uint>();
        }

        public SpvcResourceType Class { get; private set; }
        
        public SpvcBasetype Type { get; internal set; }

        public uint SlotIndex { get; internal set; }

        public uint DescriptorSet { get; internal set; }

        public string Name { get; internal set; }

        public ulong Size { get; internal set; }
        
        public uint Offset { get; internal set; }

        public uint ArrayStride { get; internal set; }
        
        public uint ArrayDimensionsCount { get; internal set; }

        public uint MatrixStride { get; internal set; }
        
        public uint RowsCount { get; internal set; }
        
        public uint ColumnsCount { get; internal set; }

        public uint TypeId { get; internal set; }
        
        public IReadOnlyCollection<ShaderReflectionVariable> Members => members.AsReadOnly();
        
        public uint GetArraySizeForDimension(uint dim)
        {
            dimensionToArraySize.TryGetValue(dim, out var size);
            return size;
        }

        public void AddArraySizeForDimension(uint dimension, uint arraySize)
        {
            dimensionToArraySize[dimension] = arraySize;
        }

        public void AddMember(ShaderReflectionVariable member)
        {
            if (!members.Contains(member))
            {
                members.Add(member);
            }
        }

        public override string ToString()
        {
            return $"{Class}, {Name}, MembersCount = {Members.Count}, SlotId = {SlotIndex}, DescriptorSet = {DescriptorSet}, Size = {Size}, TypeId = {TypeId}";
        }
    }
}
