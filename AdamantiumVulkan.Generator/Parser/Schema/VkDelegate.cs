namespace AdamantiumVulkan.Generator.Parser.Schema;

public class VkDelegate : VkCommand
{
    public string CommandName { get; set; }
    
    public override string ToString()
    {
        return Name;
    }
}