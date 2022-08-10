using System.Collections.Generic;
using System.Linq;
using QuantumBinding.Generator;
using QuantumBinding.Generator.AST;
using QuantumBinding.Generator.Processors;

namespace AdamantiumVulkan.Generator
{
    public class StructurePredefinedInput
    {
        public StructurePredefinedInput()
        {
            FieldValues = new Dictionary<string, PredefinedFieldInput>();
        }

        public string StructType { get; set; }

        public Dictionary<string, PredefinedFieldInput> FieldValues { get; set; }
    }

    public class PredefinedFieldInput
    {
        public bool IsReadOnly { get; set; }

        public string Value { get; set; }
    }

    public class PrepareStructsBeforeWrappingPass : PreGeneratorPass
    {
        private Dictionary<string, StructurePredefinedInput> predefinedValues;
        public PrepareStructsBeforeWrappingPass(List<StructurePredefinedInput> predefinedValues)
        {
            Options.VisitClasses = true;
            this.predefinedValues = predefinedValues.ToDictionary(x=>x.StructType);
        }

        public override bool VisitClass(Class @class)
        {
            if (IsVisited(@class) || @class.ClassType != ClassType.Struct)
            {
                return false;
            }

            if (predefinedValues == null) return false;

            if (!predefinedValues.TryGetValue(@class.Name, out var values))
            {
                return true;
            }

            foreach (var field in @class.Fields)
            {
                if (values.FieldValues.TryGetValue(field.Name, out var value))
                {
                    field.PredefinedValue = value.Value;
                    field.IsPredefinedValueReadOnly = value.IsReadOnly;
                }
            }

            return true;
        }
    }
}