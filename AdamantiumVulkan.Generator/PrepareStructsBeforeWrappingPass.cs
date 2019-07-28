using System.Collections.Generic;
using QuantumBinding.Generator;
using QuantumBinding.Generator.AST;
using QuantumBinding.Generator.Processors;

namespace AdamantiumVulkan.Generator
{
    public class PredefinedValues
    {
        public PredefinedValues()
        {
            FieldValues = new Dictionary<string, string>();
        }

        public string StructType { get; set; }

        public Dictionary<string, string> FieldValues { get; set; }
    }

    public class PrepareStructsBeforeWrappingPass : PreGeneratorPass
    {
        private Dictionary<string, PredefinedValues> predefinedValues;
        public PrepareStructsBeforeWrappingPass(Dictionary<string, PredefinedValues> predefinedValues)
        {
            Options.VisitClasses = true;
            this.predefinedValues = predefinedValues;
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
                    @class.AddPredefinedField(field, value);
                }
            }

            return true;
        }
    }
}