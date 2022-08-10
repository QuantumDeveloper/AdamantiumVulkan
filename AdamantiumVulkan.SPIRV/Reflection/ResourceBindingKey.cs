using System;

namespace AdamantiumVulkan.Spirv.Reflection
{
    public struct ResourceBindingKey : IEquatable<ResourceBindingKey>
    {
        public uint BindingId;

        public uint DescriptorSet;

        public string Name;

        public uint TypeId;

        public bool Equals(ResourceBindingKey other)
        {
            return BindingId == other.BindingId && 
                   DescriptorSet == other.DescriptorSet && 
                   Name == other.Name &&
                   TypeId == other.TypeId;
        }

        public override bool Equals(object obj)
        {
            return obj is ResourceBindingKey other && Equals(other);
        }

        public override int GetHashCode()
        {
            return BindingId.GetHashCode() + DescriptorSet.GetHashCode() + Name.GetHashCode() + TypeId.GetHashCode();
        }
    }
}