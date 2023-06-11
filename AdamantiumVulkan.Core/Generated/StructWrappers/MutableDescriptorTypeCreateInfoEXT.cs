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

public unsafe partial class MutableDescriptorTypeCreateInfoEXT : QBDisposableObject
{
    private NativeStruct<AdamantiumVulkan.Core.Interop.VkMutableDescriptorTypeListEXT> _pMutableDescriptorTypeLists;

    public MutableDescriptorTypeCreateInfoEXT()
    {
    }

    public MutableDescriptorTypeCreateInfoEXT(AdamantiumVulkan.Core.Interop.VkMutableDescriptorTypeCreateInfoEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        MutableDescriptorTypeListCount = _internal.mutableDescriptorTypeListCount;
        PMutableDescriptorTypeLists = new MutableDescriptorTypeListEXT(*_internal.pMutableDescriptorTypeLists);
        NativeUtils.Free(_internal.pMutableDescriptorTypeLists);
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public uint MutableDescriptorTypeListCount { get; set; }
    public MutableDescriptorTypeListEXT PMutableDescriptorTypeLists { get; set; }

    public AdamantiumVulkan.Core.Interop.VkMutableDescriptorTypeCreateInfoEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkMutableDescriptorTypeCreateInfoEXT();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.mutableDescriptorTypeListCount = MutableDescriptorTypeListCount;
        _pMutableDescriptorTypeLists.Dispose();
        if (PMutableDescriptorTypeLists != null)
        {
            var struct0 = PMutableDescriptorTypeLists.ToNative();
            _pMutableDescriptorTypeLists = new NativeStruct<AdamantiumVulkan.Core.Interop.VkMutableDescriptorTypeListEXT>(struct0);
            _internal.pMutableDescriptorTypeLists = _pMutableDescriptorTypeLists.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        _pMutableDescriptorTypeLists.Dispose();
    }


    public static implicit operator MutableDescriptorTypeCreateInfoEXT(AdamantiumVulkan.Core.Interop.VkMutableDescriptorTypeCreateInfoEXT m)
    {
        return new MutableDescriptorTypeCreateInfoEXT(m);
    }

}


