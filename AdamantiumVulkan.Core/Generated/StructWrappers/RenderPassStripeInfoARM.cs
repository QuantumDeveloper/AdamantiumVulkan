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

public unsafe partial class RenderPassStripeInfoARM : QBDisposableObject
{
    public RenderPassStripeInfoARM()
    {
    }

    public RenderPassStripeInfoARM(AdamantiumVulkan.Core.Interop.VkRenderPassStripeInfoARM _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        StripeArea = new Rect2D(_internal.stripeArea);
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public Rect2D StripeArea { get; set; }

    public AdamantiumVulkan.Core.Interop.VkRenderPassStripeInfoARM ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkRenderPassStripeInfoARM();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (StripeArea != default)
        {
            _internal.stripeArea = StripeArea.ToNative();
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        StripeArea?.Dispose();
    }


    public static implicit operator RenderPassStripeInfoARM(AdamantiumVulkan.Core.Interop.VkRenderPassStripeInfoARM r)
    {
        return new RenderPassStripeInfoARM(r);
    }

}



