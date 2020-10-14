using System;

namespace AdamantiumVulkan.SPIRV.Reflection
{
    public struct ResourceBindingKey : IEquatable<ResourceBindingKey>
    {
        public uint BindingId;

        public uint DescriptorSet;

        public bool Equals(ResourceBindingKey other)
        {
            return BindingId == other.BindingId && DescriptorSet == other.DescriptorSet;
        }

        public override bool Equals(object obj)
        {
            return obj is ResourceBindingKey other && Equals(other);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(BindingId, DescriptorSet);
        }
    }
}