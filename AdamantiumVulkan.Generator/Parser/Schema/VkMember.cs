using System.Collections.Generic;
using System.Linq;

namespace AdamantiumVulkan.Generator.Parser.Schema;

public class VkMember : VkTypeBase
{
    public string DefaultValueType { get; set; }
    public string DefaultValue { get; set; }
    public bool HasDefaultValue => !string.IsNullOrEmpty(DefaultValue);
    public MemberSemantic Semantic { get; set; } = MemberSemantic.None;
    
    public List<int> ArrayDimensions { get; set; } = new();
    public override bool IsFixedArray => ArrayDimensions.Count > 0;
    public int TotalArraySize => ArrayDimensions.Aggregate(1, (a, b) => a * b);
}