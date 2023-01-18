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

public unsafe partial class RenderPassSubpassFeedbackCreateInfoEXT : QBDisposableObject
{
    private NativeStruct<AdamantiumVulkan.Core.Interop.VkRenderPassSubpassFeedbackInfoEXT> pSubpassFeedback;

    public RenderPassSubpassFeedbackCreateInfoEXT()
    {
    }

    public RenderPassSubpassFeedbackCreateInfoEXT(AdamantiumVulkan.Core.Interop.VkRenderPassSubpassFeedbackCreateInfoEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        PSubpassFeedback = new RenderPassSubpassFeedbackInfoEXT(*_internal.pSubpassFeedback);
        NativeUtils.Free(_internal.pSubpassFeedback);
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public RenderPassSubpassFeedbackInfoEXT PSubpassFeedback { get; set; }

    public AdamantiumVulkan.Core.Interop.VkRenderPassSubpassFeedbackCreateInfoEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkRenderPassSubpassFeedbackCreateInfoEXT();
        _internal.sType = SType;
        _internal.pNext = PNext;
        pSubpassFeedback.Dispose();
        if (PSubpassFeedback != null)
        {
            var struct0 = PSubpassFeedback.ToNative();
            pSubpassFeedback = new NativeStruct<AdamantiumVulkan.Core.Interop.VkRenderPassSubpassFeedbackInfoEXT>(struct0);
            _internal.pSubpassFeedback = pSubpassFeedback.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        pSubpassFeedback.Dispose();
    }


    public static implicit operator RenderPassSubpassFeedbackCreateInfoEXT(AdamantiumVulkan.Core.Interop.VkRenderPassSubpassFeedbackCreateInfoEXT r)
    {
        return new RenderPassSubpassFeedbackCreateInfoEXT(r);
    }

}



