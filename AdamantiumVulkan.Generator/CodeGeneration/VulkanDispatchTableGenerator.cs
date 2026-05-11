using System.Collections.Generic;
using System.Linq;
using QuantumBinding.Generator;
using QuantumBinding.Generator.AST;
using QuantumBinding.Generator.CodeGeneration;

namespace AdamantiumVulkan.Generator.CodeGeneration;

public class VulkanDispatchTableGenerator : CSharpCodeGenerator
{
    public VulkanDispatchTableGenerator(ProcessingContext context, IEnumerable<TranslationUnit> units, GeneratorCategory category) : base(context, units, category)
    {
    }

    public VulkanDispatchTableGenerator(ProcessingContext context, TranslationUnit unit, GeneratorCategory category) : base(context, unit, category)
    {
    }
    
    public override void Run()
    {
        if (Category == GeneratorCategory.Undefined)
        {
            IsEmpty = true;
            return;
        }
            
        Name = Category.ToString();
            
        PushBlock(CodeBlockKind.Root);

        GenerateFileHeader();

        foreach (var unit in TranslationUnits)
        {
            CurrentTranslationUnit = unit;

            TypePrinter.PushModule(unit.Module);

            NewLine();

            PushBlock(CodeBlockKind.Namespace);
                
            GenerateUsings();

            WriteCurrentNamespace(CurrentTranslationUnit);

            UsingsBlock.WriteLine($"using {CurrentTranslationUnit.FullNamespace}.{CurrentTranslationUnit.Module.InteropSubNamespace};");

            NewLine();

            GenerateDispatchTables();

            PopBlock();
        }

        PopBlock();
    }

    protected override void GenerateUsings()
    {
        base.GenerateUsings();
        UsingsBlock.WriteLine($"using {CurrentTranslationUnit.FullNamespace}.{CurrentTranslationUnit.Module.InteropSubNamespace};");
    }

    protected override void GenerateDeclaration(Declaration declaration)
    {
        switch (declaration)
        {
            case DispatchTable dispatchTable:
                GenerateDispatchTable(dispatchTable);
                break;
        }
    }

    private void GenerateDispatchTables()
    {
        foreach (var dispatchTable in CurrentTranslationUnit.DispatchTables)
        {
            GenerateDispatchTable(dispatchTable);
        }
    }

    private void GenerateDispatchTable(DispatchTable dispatchTable)
    {
        PushBlock(CodeBlockKind.DispatchTable);

        var scope = dispatchTable.Metadata.Get<HandleScope>("Scope");
        var header = dispatchTable.Visit(TypePrinter);
        WriteLine($"public unsafe partial class {header}");
        WriteOpenBraceAndIndent();
        Declaration parentDeclaration = dispatchTable.TableOwner;
        WriteLine($"public {header}({parentDeclaration.FullName} owner)");
        WriteOpenBraceAndIndent();
        foreach (var field in dispatchTable.Fields)
        {
            TypePrinter.PushMarshalType(MarshalTypes.SkipParamTypesAndModifiers);
            var fieldDeclaration = field.Visit(TypePrinter);
            TypePrinter.PopMarshalType();
            WriteLine($"{field.Name} = ({fieldDeclaration})owner.{dispatchTable.FunctionName}(\"{field.Name}\");");
        }
        UnindentAndWriteCloseBrace();
        NewLine();
        foreach (var field in dispatchTable.Fields)
        {
            var fieldDeclaration = field.Visit(TypePrinter);
            WriteLine($"{fieldDeclaration};");
        }
        
        UnindentAndWriteCloseBrace();
        
        PopBlock(NewLineStrategy.NewLineBeforeNextBlock);
    }
}