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

public unsafe partial class PhysicalDeviceLineRasterizationFeaturesEXT : QBDisposableObject
{
    public PhysicalDeviceLineRasterizationFeaturesEXT()
    {
    }

    public PhysicalDeviceLineRasterizationFeaturesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceLineRasterizationFeaturesEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        RectangularLines = _internal.rectangularLines;
        BresenhamLines = _internal.bresenhamLines;
        SmoothLines = _internal.smoothLines;
        StippledRectangularLines = _internal.stippledRectangularLines;
        StippledBresenhamLines = _internal.stippledBresenhamLines;
        StippledSmoothLines = _internal.stippledSmoothLines;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 RectangularLines { get; set; }
    public VkBool32 BresenhamLines { get; set; }
    public VkBool32 SmoothLines { get; set; }
    public VkBool32 StippledRectangularLines { get; set; }
    public VkBool32 StippledBresenhamLines { get; set; }
    public VkBool32 StippledSmoothLines { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceLineRasterizationFeaturesEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceLineRasterizationFeaturesEXT();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.rectangularLines = RectangularLines;
        _internal.bresenhamLines = BresenhamLines;
        _internal.smoothLines = SmoothLines;
        _internal.stippledRectangularLines = StippledRectangularLines;
        _internal.stippledBresenhamLines = StippledBresenhamLines;
        _internal.stippledSmoothLines = StippledSmoothLines;
        return _internal;
    }

    public static implicit operator PhysicalDeviceLineRasterizationFeaturesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceLineRasterizationFeaturesEXT p)
    {
        return new PhysicalDeviceLineRasterizationFeaturesEXT(p);
    }

}



