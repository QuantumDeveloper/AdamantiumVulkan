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

public unsafe partial class RenderPassSubpassFeedbackInfoEXT
{
    public RenderPassSubpassFeedbackInfoEXT()
    {
    }

    public RenderPassSubpassFeedbackInfoEXT(AdamantiumVulkan.Core.Interop.VkRenderPassSubpassFeedbackInfoEXT _internal)
    {
        SubpassMergeStatus = _internal.subpassMergeStatus;
        Description = new string((sbyte*)_internal.description);
        PostMergeIndex = _internal.postMergeIndex;
    }

    public SubpassMergeStatusEXT SubpassMergeStatus { get; set; }
    public string Description { get; set; }
    public uint PostMergeIndex { get; set; }

    public AdamantiumVulkan.Core.Interop.VkRenderPassSubpassFeedbackInfoEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkRenderPassSubpassFeedbackInfoEXT();
        _internal.subpassMergeStatus = SubpassMergeStatus;
        if(Description != null)
        {
            if (Description.Length > 256)
                throw new System.ArgumentOutOfRangeException(nameof(Description), "Array is out of bounds. Size should not be more than 256");

            NativeUtils.StringToFixedArray(_internal.description, 256, Description, false);
        }
        _internal.postMergeIndex = PostMergeIndex;
        return _internal;
    }

    public static implicit operator RenderPassSubpassFeedbackInfoEXT(AdamantiumVulkan.Core.Interop.VkRenderPassSubpassFeedbackInfoEXT r)
    {
        return new RenderPassSubpassFeedbackInfoEXT(r);
    }

}


