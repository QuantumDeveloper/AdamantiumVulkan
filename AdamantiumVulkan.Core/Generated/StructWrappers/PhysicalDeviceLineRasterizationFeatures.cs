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

public unsafe partial class PhysicalDeviceLineRasterizationFeatures : QBDisposableObject
{
    public PhysicalDeviceLineRasterizationFeatures()
    {
    }

    public PhysicalDeviceLineRasterizationFeatures(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceLineRasterizationFeatures _internal)
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

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceLineRasterizationFeatures ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceLineRasterizationFeatures();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (RectangularLines != (uint)default)
        {
            _internal.rectangularLines = RectangularLines;
        }
        if (BresenhamLines != (uint)default)
        {
            _internal.bresenhamLines = BresenhamLines;
        }
        if (SmoothLines != (uint)default)
        {
            _internal.smoothLines = SmoothLines;
        }
        if (StippledRectangularLines != (uint)default)
        {
            _internal.stippledRectangularLines = StippledRectangularLines;
        }
        if (StippledBresenhamLines != (uint)default)
        {
            _internal.stippledBresenhamLines = StippledBresenhamLines;
        }
        if (StippledSmoothLines != (uint)default)
        {
            _internal.stippledSmoothLines = StippledSmoothLines;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceLineRasterizationFeatures(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceLineRasterizationFeatures p)
    {
        return new PhysicalDeviceLineRasterizationFeatures(p);
    }

}



