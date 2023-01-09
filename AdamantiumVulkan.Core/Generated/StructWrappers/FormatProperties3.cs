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

public unsafe partial class FormatProperties3 : QBDisposableObject
{
    public FormatProperties3()
    {
    }

    public FormatProperties3(AdamantiumVulkan.Core.Interop.VkFormatProperties3 _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        LinearTilingFeatures = _internal.linearTilingFeatures;
        OptimalTilingFeatures = _internal.optimalTilingFeatures;
        BufferFeatures = _internal.bufferFeatures;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkFormatFeatureFlags2 LinearTilingFeatures { get; set; }
    public VkFormatFeatureFlags2 OptimalTilingFeatures { get; set; }
    public VkFormatFeatureFlags2 BufferFeatures { get; set; }

    public AdamantiumVulkan.Core.Interop.VkFormatProperties3 ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkFormatProperties3();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.linearTilingFeatures = LinearTilingFeatures;
        _internal.optimalTilingFeatures = OptimalTilingFeatures;
        _internal.bufferFeatures = BufferFeatures;
        return _internal;
    }

    public static implicit operator FormatProperties3(AdamantiumVulkan.Core.Interop.VkFormatProperties3 f)
    {
        return new FormatProperties3(f);
    }

}


