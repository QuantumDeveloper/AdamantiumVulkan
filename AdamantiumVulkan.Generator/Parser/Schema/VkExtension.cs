using System.Collections.Generic;

namespace AdamantiumVulkan.Generator.Parser.Schema;

public class VkExtension
{
    public string Name { get; set; }
    public int Version { get; set; }
    public string Type { get; set; }
    public List<string> RequiredCommands { get; set; } = new();
    public List<string> RequiredTypes { get; set; } = new();
    public string Platform { get; set; }
    
    public ExtensionType ExtensionType { get; set; }
    
    public override string ToString()
    {
        return $"{Name} {Version} {Type}";
    }
}