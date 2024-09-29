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

public unsafe partial class PhysicalDeviceMultiviewPerViewRenderAreasFeaturesQCOM : QBDisposableObject
{
    public PhysicalDeviceMultiviewPerViewRenderAreasFeaturesQCOM()
    {
    }

    public PhysicalDeviceMultiviewPerViewRenderAreasFeaturesQCOM(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceMultiviewPerViewRenderAreasFeaturesQCOM _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        MultiviewPerViewRenderAreas = _internal.multiviewPerViewRenderAreas;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 MultiviewPerViewRenderAreas { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceMultiviewPerViewRenderAreasFeaturesQCOM ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceMultiviewPerViewRenderAreasFeaturesQCOM();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (MultiviewPerViewRenderAreas != (uint)default)
        {
            _internal.multiviewPerViewRenderAreas = MultiviewPerViewRenderAreas;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceMultiviewPerViewRenderAreasFeaturesQCOM(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceMultiviewPerViewRenderAreasFeaturesQCOM p)
    {
        return new PhysicalDeviceMultiviewPerViewRenderAreasFeaturesQCOM(p);
    }

}



