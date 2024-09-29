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

public unsafe partial class RenderPassStripeBeginInfoARM : QBDisposableObject
{
    private NativeStruct<AdamantiumVulkan.Core.Interop.VkRenderPassStripeInfoARM> _pStripeInfos;

    public RenderPassStripeBeginInfoARM()
    {
    }

    public RenderPassStripeBeginInfoARM(AdamantiumVulkan.Core.Interop.VkRenderPassStripeBeginInfoARM _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        StripeInfoCount = _internal.stripeInfoCount;
        PStripeInfos = new RenderPassStripeInfoARM(*_internal.pStripeInfos);
        NativeUtils.Free(_internal.pStripeInfos);
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public uint StripeInfoCount { get; set; }
    public RenderPassStripeInfoARM PStripeInfos { get; set; }

    public AdamantiumVulkan.Core.Interop.VkRenderPassStripeBeginInfoARM ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkRenderPassStripeBeginInfoARM();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (StripeInfoCount != default)
        {
            _internal.stripeInfoCount = StripeInfoCount;
        }
        _pStripeInfos.Dispose();
        if (PStripeInfos != default)
        {
            var struct0 = PStripeInfos.ToNative();
            _pStripeInfos = new NativeStruct<AdamantiumVulkan.Core.Interop.VkRenderPassStripeInfoARM>(struct0);
            _internal.pStripeInfos = _pStripeInfos.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        _pStripeInfos.Dispose();
    }


    public static implicit operator RenderPassStripeBeginInfoARM(AdamantiumVulkan.Core.Interop.VkRenderPassStripeBeginInfoARM r)
    {
        return new RenderPassStripeBeginInfoARM(r);
    }

}



