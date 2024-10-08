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

public unsafe partial class ColorBlendAdvancedEXT : QBDisposableObject
{
    public ColorBlendAdvancedEXT()
    {
    }

    public ColorBlendAdvancedEXT(AdamantiumVulkan.Core.Interop.VkColorBlendAdvancedEXT _internal)
    {
        AdvancedBlendOp = _internal.advancedBlendOp;
        SrcPremultiplied = _internal.srcPremultiplied;
        DstPremultiplied = _internal.dstPremultiplied;
        BlendOverlap = _internal.blendOverlap;
        ClampResults = _internal.clampResults;
    }

    public BlendOp AdvancedBlendOp { get; set; }
    public VkBool32 SrcPremultiplied { get; set; }
    public VkBool32 DstPremultiplied { get; set; }
    public BlendOverlapEXT BlendOverlap { get; set; }
    public VkBool32 ClampResults { get; set; }

    public AdamantiumVulkan.Core.Interop.VkColorBlendAdvancedEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkColorBlendAdvancedEXT();
        if (AdvancedBlendOp != default)
        {
            _internal.advancedBlendOp = AdvancedBlendOp;
        }
        if (SrcPremultiplied != (uint)default)
        {
            _internal.srcPremultiplied = SrcPremultiplied;
        }
        if (DstPremultiplied != (uint)default)
        {
            _internal.dstPremultiplied = DstPremultiplied;
        }
        if (BlendOverlap != default)
        {
            _internal.blendOverlap = BlendOverlap;
        }
        if (ClampResults != (uint)default)
        {
            _internal.clampResults = ClampResults;
        }
        return _internal;
    }

    public static implicit operator ColorBlendAdvancedEXT(AdamantiumVulkan.Core.Interop.VkColorBlendAdvancedEXT c)
    {
        return new ColorBlendAdvancedEXT(c);
    }

}



