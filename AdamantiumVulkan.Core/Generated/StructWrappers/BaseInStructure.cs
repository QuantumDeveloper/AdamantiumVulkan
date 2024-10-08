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

public unsafe partial class BaseInStructure : QBDisposableObject
{
    private NativeStruct<AdamantiumVulkan.Core.Interop.VkBaseInStructure> _pNext;

    public BaseInStructure()
    {
    }

    public BaseInStructure(AdamantiumVulkan.Core.Interop.VkBaseInStructure _internal)
    {
        SType = _internal.sType;
        PNext = new BaseInStructure(*_internal.pNext);
        NativeUtils.Free(_internal.pNext);
    }

    public StructureType SType { get; set; }
    public BaseInStructure PNext { get; set; }

    public AdamantiumVulkan.Core.Interop.VkBaseInStructure ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkBaseInStructure();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _pNext.Dispose();
        if (PNext != default)
        {
            var struct0 = PNext.ToNative();
            _pNext = new NativeStruct<AdamantiumVulkan.Core.Interop.VkBaseInStructure>(struct0);
            _internal.pNext = _pNext.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        _pNext.Dispose();
    }


    public static implicit operator BaseInStructure(AdamantiumVulkan.Core.Interop.VkBaseInStructure b)
    {
        return new BaseInStructure(b);
    }

}



