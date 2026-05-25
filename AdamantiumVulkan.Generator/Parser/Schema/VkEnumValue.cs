namespace AdamantiumVulkan.Generator.Parser.Schema;

public class VkEnumValue : VkDeclaration
{
    public string Value { get; set; }
    public string BitPos { get; set; }

    public override string ToString()
    {
        return $"{Name} = {Value}";
    }
}