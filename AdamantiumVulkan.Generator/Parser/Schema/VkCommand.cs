using System.Collections.Generic;

namespace AdamantiumVulkan.Generator.Parser.Schema;

public class VkCommand : VkDeclaration
{
    public string ReturnType { get; set; }
    public List<VkParameter> Params { get; set; } = new();
    public string[] SuccessCodes { get; set; }
    
    public override string ToString()
    {
        return Name;
    }
}