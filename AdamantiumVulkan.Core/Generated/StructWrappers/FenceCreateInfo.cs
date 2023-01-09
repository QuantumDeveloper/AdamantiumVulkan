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

public unsafe partial class FenceCreateInfo : QBDisposableObject
{
    public FenceCreateInfo()
    {
    }

    public FenceCreateInfo(AdamantiumVulkan.Core.Interop.VkFenceCreateInfo _internal)
    {
        PNext = _internal.pNext;
        Flags = _internal.flags;
    }

    public StructureType SType => StructureType.FenceCreateInfo;
    public void* PNext { get; set; }
    public VkFenceCreateFlags Flags { get; set; }

    public AdamantiumVulkan.Core.Interop.VkFenceCreateInfo ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkFenceCreateInfo();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.flags = Flags;
        return _internal;
    }

    public static implicit operator FenceCreateInfo(AdamantiumVulkan.Core.Interop.VkFenceCreateInfo f)
    {
        return new FenceCreateInfo(f);
    }

}


