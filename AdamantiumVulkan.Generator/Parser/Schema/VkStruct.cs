using System.Collections.Generic;

namespace AdamantiumVulkan.Generator.Parser.Schema;

public class VkStruct : VkDeclaration
{
    public bool IsUnion { get; set; }
    public List<VkMember> Members { get; set; } = new();
    public string StructExtend { get; set; } 
    public string AliasTarget { get; set; }
    public bool IsAlias { get; set; }

    public override string ToString()
    {
        return Name;
    }
}