using System.Collections.Generic;

namespace AdamantiumVulkan.Generator;

public class StructurePredefinedInput
{
    public StructurePredefinedInput()
    {
        FieldValues = new Dictionary<string, PredefinedField>();
    }

    public string StructType { get; set; }

    public Dictionary<string, PredefinedField> FieldValues { get; set; }
}