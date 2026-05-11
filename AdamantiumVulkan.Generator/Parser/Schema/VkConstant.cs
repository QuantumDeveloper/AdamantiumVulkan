using QuantumBinding.Generator;

namespace AdamantiumVulkan.Generator.Parser.Schema;

public class VkConstant : VkDeclaration
{
    public object Value { get; set; }
    public long NumericValue { get; set; }
    public bool IsDeprecated { get; set; }
    public bool IsFunctionLike { get; set; }
    public PrimitiveType PrimitiveType { get; set; }
    
    public override string ToString()
    {
        return $"{Name} = {Value}";
    }
}