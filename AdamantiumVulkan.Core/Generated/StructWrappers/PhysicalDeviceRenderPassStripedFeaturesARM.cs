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

public unsafe partial class PhysicalDeviceRenderPassStripedFeaturesARM : QBDisposableObject
{
    public PhysicalDeviceRenderPassStripedFeaturesARM()
    {
    }

    public PhysicalDeviceRenderPassStripedFeaturesARM(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceRenderPassStripedFeaturesARM _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        RenderPassStriped = _internal.renderPassStriped;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 RenderPassStriped { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceRenderPassStripedFeaturesARM ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceRenderPassStripedFeaturesARM();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (RenderPassStriped != (uint)default)
        {
            _internal.renderPassStriped = RenderPassStriped;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceRenderPassStripedFeaturesARM(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceRenderPassStripedFeaturesARM p)
    {
        return new PhysicalDeviceRenderPassStripedFeaturesARM(p);
    }

}



