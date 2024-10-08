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

public unsafe partial class PhysicalDeviceBorderColorSwizzleFeaturesEXT : QBDisposableObject
{
    public PhysicalDeviceBorderColorSwizzleFeaturesEXT()
    {
    }

    public PhysicalDeviceBorderColorSwizzleFeaturesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceBorderColorSwizzleFeaturesEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        BorderColorSwizzle = _internal.borderColorSwizzle;
        BorderColorSwizzleFromImage = _internal.borderColorSwizzleFromImage;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 BorderColorSwizzle { get; set; }
    public VkBool32 BorderColorSwizzleFromImage { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceBorderColorSwizzleFeaturesEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceBorderColorSwizzleFeaturesEXT();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (BorderColorSwizzle != (uint)default)
        {
            _internal.borderColorSwizzle = BorderColorSwizzle;
        }
        if (BorderColorSwizzleFromImage != (uint)default)
        {
            _internal.borderColorSwizzleFromImage = BorderColorSwizzleFromImage;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceBorderColorSwizzleFeaturesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceBorderColorSwizzleFeaturesEXT p)
    {
        return new PhysicalDeviceBorderColorSwizzleFeaturesEXT(p);
    }

}



