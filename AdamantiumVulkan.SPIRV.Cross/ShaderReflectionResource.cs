using System.Collections.Generic;

namespace AdamantiumVulkan.SPIRV.Cross
{
    public class ShaderReflectionResource
    {
        private List<ShaderReflectionResourceMember> members;

        public ShaderReflectionResource(SpvcResourceType resourceType)
        {
            ResourceType = resourceType;
            members = new List<ShaderReflectionResourceMember>();
        }

        public SpvcResourceType ResourceType { get; private set; }

        public uint SlotId { get; internal set; }

        public uint DescriptorSet { get; internal set; }

        public string Name { get; internal set; }

        public ulong Size { get; internal set; }

        public uint TypeId { get; internal set; }

        public SpvcBasetype Type { get; internal set; }

        public IReadOnlyCollection<ShaderReflectionResourceMember> Members => members.AsReadOnly();

        public void AddMember(ShaderReflectionResourceMember member)
        {
            if (!members.Contains(member))
            {
                members.Add(member);
            }
        }

        public override string ToString()
        {
            return $"{ResourceType}, {Name}, MembersCount = {Members.Count}, SlotId = {SlotId}, DescriptorSet = {DescriptorSet}, Size = {Size}, TypeId = {TypeId}";
        }
    }
}
