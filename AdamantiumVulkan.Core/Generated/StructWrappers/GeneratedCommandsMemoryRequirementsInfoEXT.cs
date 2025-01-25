// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System.Runtime.InteropServices;
using QuantumBinding.Utils;
using AdamantiumVulkan.Core.Interop;

namespace AdamantiumVulkan.Core;

public unsafe partial class GeneratedCommandsMemoryRequirementsInfoEXT : QBDisposableObject
{
    public GeneratedCommandsMemoryRequirementsInfoEXT()
    {
    }

    public GeneratedCommandsMemoryRequirementsInfoEXT(AdamantiumVulkan.Core.Interop.VkGeneratedCommandsMemoryRequirementsInfoEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        IndirectExecutionSet = new IndirectExecutionSetEXT(_internal.indirectExecutionSet);
        IndirectCommandsLayout = new IndirectCommandsLayoutEXT(_internal.indirectCommandsLayout);
        MaxSequenceCount = _internal.maxSequenceCount;
        MaxDrawCount = _internal.maxDrawCount;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public IndirectExecutionSetEXT IndirectExecutionSet { get; set; }
    public IndirectCommandsLayoutEXT IndirectCommandsLayout { get; set; }
    public uint MaxSequenceCount { get; set; }
    public uint MaxDrawCount { get; set; }

    public AdamantiumVulkan.Core.Interop.VkGeneratedCommandsMemoryRequirementsInfoEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkGeneratedCommandsMemoryRequirementsInfoEXT();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (IndirectExecutionSet != default)
        {
            _internal.indirectExecutionSet = IndirectExecutionSet;
        }
        if (IndirectCommandsLayout != default)
        {
            _internal.indirectCommandsLayout = IndirectCommandsLayout;
        }
        if (MaxSequenceCount != default)
        {
            _internal.maxSequenceCount = MaxSequenceCount;
        }
        if (MaxDrawCount != default)
        {
            _internal.maxDrawCount = MaxDrawCount;
        }
        return _internal;
    }

    public static implicit operator GeneratedCommandsMemoryRequirementsInfoEXT(AdamantiumVulkan.Core.Interop.VkGeneratedCommandsMemoryRequirementsInfoEXT g)
    {
        return new GeneratedCommandsMemoryRequirementsInfoEXT(g);
    }

}



