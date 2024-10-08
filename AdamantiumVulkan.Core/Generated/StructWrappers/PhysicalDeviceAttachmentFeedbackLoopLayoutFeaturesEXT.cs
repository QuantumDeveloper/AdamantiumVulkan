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

public unsafe partial class PhysicalDeviceAttachmentFeedbackLoopLayoutFeaturesEXT : QBDisposableObject
{
    public PhysicalDeviceAttachmentFeedbackLoopLayoutFeaturesEXT()
    {
    }

    public PhysicalDeviceAttachmentFeedbackLoopLayoutFeaturesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceAttachmentFeedbackLoopLayoutFeaturesEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        AttachmentFeedbackLoopLayout = _internal.attachmentFeedbackLoopLayout;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 AttachmentFeedbackLoopLayout { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceAttachmentFeedbackLoopLayoutFeaturesEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceAttachmentFeedbackLoopLayoutFeaturesEXT();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (AttachmentFeedbackLoopLayout != (uint)default)
        {
            _internal.attachmentFeedbackLoopLayout = AttachmentFeedbackLoopLayout;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceAttachmentFeedbackLoopLayoutFeaturesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceAttachmentFeedbackLoopLayoutFeaturesEXT p)
    {
        return new PhysicalDeviceAttachmentFeedbackLoopLayoutFeaturesEXT(p);
    }

}



