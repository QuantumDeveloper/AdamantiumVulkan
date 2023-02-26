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

public unsafe partial class ValidationFlagsEXT : QBDisposableObject
{
    private NativeStructArray<AdamantiumVulkan.Core.ValidationCheckEXT> _pDisabledValidationChecks;

    public ValidationFlagsEXT()
    {
    }

    public ValidationFlagsEXT(AdamantiumVulkan.Core.Interop.VkValidationFlagsEXT _internal)
    {
        PNext = _internal.pNext;
        DisabledValidationCheckCount = _internal.disabledValidationCheckCount;
        PDisabledValidationChecks = NativeUtils.PointerToManagedArray(_internal.pDisabledValidationChecks, _internal.disabledValidationCheckCount);
    }

    public StructureType SType => StructureType.ValidationFlagsExt;
    public void* PNext { get; set; }
    public uint DisabledValidationCheckCount { get; set; }
    public ValidationCheckEXT[] PDisabledValidationChecks { get; set; }

    public AdamantiumVulkan.Core.Interop.VkValidationFlagsEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkValidationFlagsEXT();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.disabledValidationCheckCount = DisabledValidationCheckCount;
        _pDisabledValidationChecks.Dispose();
        if (PDisabledValidationChecks != null)
        {
            _pDisabledValidationChecks = new NativeStructArray<AdamantiumVulkan.Core.ValidationCheckEXT>(PDisabledValidationChecks);
            _internal.pDisabledValidationChecks = _pDisabledValidationChecks.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        _pDisabledValidationChecks.Dispose();
    }


    public static implicit operator ValidationFlagsEXT(AdamantiumVulkan.Core.Interop.VkValidationFlagsEXT v)
    {
        return new ValidationFlagsEXT(v);
    }

}



