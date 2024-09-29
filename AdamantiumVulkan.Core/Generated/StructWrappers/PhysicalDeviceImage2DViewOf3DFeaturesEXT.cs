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

public unsafe partial class PhysicalDeviceImage2DViewOf3DFeaturesEXT : QBDisposableObject
{
    public PhysicalDeviceImage2DViewOf3DFeaturesEXT()
    {
    }

    public PhysicalDeviceImage2DViewOf3DFeaturesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceImage2DViewOf3DFeaturesEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        Image2DViewOf3D = _internal.image2DViewOf3D;
        Sampler2DViewOf3D = _internal.sampler2DViewOf3D;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 Image2DViewOf3D { get; set; }
    public VkBool32 Sampler2DViewOf3D { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceImage2DViewOf3DFeaturesEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceImage2DViewOf3DFeaturesEXT();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (Image2DViewOf3D != (uint)default)
        {
            _internal.image2DViewOf3D = Image2DViewOf3D;
        }
        if (Sampler2DViewOf3D != (uint)default)
        {
            _internal.sampler2DViewOf3D = Sampler2DViewOf3D;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceImage2DViewOf3DFeaturesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceImage2DViewOf3DFeaturesEXT p)
    {
        return new PhysicalDeviceImage2DViewOf3DFeaturesEXT(p);
    }

}



