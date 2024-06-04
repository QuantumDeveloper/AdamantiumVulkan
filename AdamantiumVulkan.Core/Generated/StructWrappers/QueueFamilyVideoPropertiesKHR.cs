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

public unsafe partial class QueueFamilyVideoPropertiesKHR : QBDisposableObject
{
    public QueueFamilyVideoPropertiesKHR()
    {
    }

    public QueueFamilyVideoPropertiesKHR(AdamantiumVulkan.Core.Interop.VkQueueFamilyVideoPropertiesKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        VideoCodecOperations = _internal.videoCodecOperations;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkVideoCodecOperationFlagsKHR VideoCodecOperations { get; set; }

    public AdamantiumVulkan.Core.Interop.VkQueueFamilyVideoPropertiesKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkQueueFamilyVideoPropertiesKHR();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.videoCodecOperations = VideoCodecOperations;
        return _internal;
    }

    public static implicit operator QueueFamilyVideoPropertiesKHR(AdamantiumVulkan.Core.Interop.VkQueueFamilyVideoPropertiesKHR q)
    {
        return new QueueFamilyVideoPropertiesKHR(q);
    }

}



