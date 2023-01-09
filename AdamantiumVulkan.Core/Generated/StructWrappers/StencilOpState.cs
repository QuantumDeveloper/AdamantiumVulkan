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

public unsafe partial class StencilOpState
{
    public StencilOpState()
    {
    }

    public StencilOpState(AdamantiumVulkan.Core.Interop.VkStencilOpState _internal)
    {
        FailOp = _internal.failOp;
        PassOp = _internal.passOp;
        DepthFailOp = _internal.depthFailOp;
        CompareOp = _internal.compareOp;
        CompareMask = _internal.compareMask;
        WriteMask = _internal.writeMask;
        Reference = _internal.reference;
    }

    public StencilOp FailOp { get; set; }
    public StencilOp PassOp { get; set; }
    public StencilOp DepthFailOp { get; set; }
    public CompareOp CompareOp { get; set; }
    public uint CompareMask { get; set; }
    public uint WriteMask { get; set; }
    public uint Reference { get; set; }

    public AdamantiumVulkan.Core.Interop.VkStencilOpState ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkStencilOpState();
        _internal.failOp = FailOp;
        _internal.passOp = PassOp;
        _internal.depthFailOp = DepthFailOp;
        _internal.compareOp = CompareOp;
        _internal.compareMask = CompareMask;
        _internal.writeMask = WriteMask;
        _internal.reference = Reference;
        return _internal;
    }

    public static implicit operator StencilOpState(AdamantiumVulkan.Core.Interop.VkStencilOpState s)
    {
        return new StencilOpState(s);
    }

}


