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

public unsafe partial class PhysicalDeviceImageProcessing2FeaturesQCOM : QBDisposableObject
{
    public PhysicalDeviceImageProcessing2FeaturesQCOM()
    {
    }

    public PhysicalDeviceImageProcessing2FeaturesQCOM(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceImageProcessing2FeaturesQCOM _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        TextureBlockMatch2 = _internal.textureBlockMatch2;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 TextureBlockMatch2 { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceImageProcessing2FeaturesQCOM ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceImageProcessing2FeaturesQCOM();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.textureBlockMatch2 = TextureBlockMatch2;
        return _internal;
    }

    public static implicit operator PhysicalDeviceImageProcessing2FeaturesQCOM(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceImageProcessing2FeaturesQCOM p)
    {
        return new PhysicalDeviceImageProcessing2FeaturesQCOM(p);
    }

}



