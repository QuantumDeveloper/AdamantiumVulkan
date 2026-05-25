namespace AdamantiumVulkan.Generator.Parser.Schema;

public class VkHandle : VkDeclaration
{
    public string Parent { get; set; } // VkDevice -> VkPhysicalDevice
    public bool IsDispatchable { get; set; } // void* vs long
    
    public override string ToString() => Name;
}