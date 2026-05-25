using System.Collections.Generic;

namespace AdamantiumVulkan.Generator.Parser.Schema;

public class VkEnum : VkDeclaration
{
    public bool IsFlags { get; set; }
    public string BaseType { get; set; }
    public List<VkEnumValue> Values { get; set; } = new();

    public override string ToString()
    {
        return Name;
    }
}