using System;
using System.Collections.Generic;
using System.Text;

namespace AdamantiumVulkan.SPIRV.Cross
{
    public class ShaderResource
    {
        private List<ShaderResourceMember> members;

        public ShaderResource(SpvcResourceType resourceType)
        {
            ResourceType = resourceType;
            members = new List<ShaderResourceMember>();
        }

        public SpvcResourceType ResourceType { get; private set; }

        public uint SlotId { get; internal set; }

        public string Name { get; internal set; }

        public ulong Size { get; internal set; }

        public uint TypeId { get; internal set; }

        public IReadOnlyCollection<ShaderResourceMember> Members => members.AsReadOnly();

        public void AddMember(ShaderResourceMember member)
        {
            if (members.Contains(member)) return;

            members.Add(member);
        }
    }
}
