using System.Collections.Generic;
using Adamantium.Vulkan.Generator.CodeGeneration;
using QuantumBinding.Generator.AST;
using QuantumBinding.Generator.CodeGeneration;
using QuantumBinding.Generator.Processors;

namespace Adamantium.Vulkan.Generator.Processors;

public class VulkanCodeGeneratorPass : CodeGeneratorPass
{
    public VulkanCodeGeneratorPass()
    {
        CodeGeneratorPassKind = ExecutionPassKind.PerTranslationUnit;
        GeneratorSpecializations = GeneratorSpecializations.DispatchTables;
    }
    
    protected override CodeGenerator OnCreateGenerator(GeneratorCategory category, params TranslationUnit[] units)
    {
        return new VulkanDispatchTableGenerator(ProcessingContext, units, category);
    }

    protected override List<CodeGenerator> ProcessPerTypeCodeGeneration(TranslationUnit unit, GeneratorSpecializations specializations)
    {
        switch (specializations)
        {
            case GeneratorSpecializations.DispatchTables:
                return ProcessDeclarations(unit.DispatchTables, unit);
            default:
                return new List<CodeGenerator>();
        }
    }
}