namespace AdamantiumVulkan.Generator.Parser.Schema;

public class VkTypedef : VkDeclaration
{
    public string BaseType { get; set; }
    public bool IsPointer { get; set; }
    public bool IsOpaque { get; set; }
}