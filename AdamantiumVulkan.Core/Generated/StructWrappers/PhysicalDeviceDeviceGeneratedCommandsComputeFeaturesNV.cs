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

public unsafe partial class PhysicalDeviceDeviceGeneratedCommandsComputeFeaturesNV : QBDisposableObject
{
    public PhysicalDeviceDeviceGeneratedCommandsComputeFeaturesNV()
    {
    }

    public PhysicalDeviceDeviceGeneratedCommandsComputeFeaturesNV(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceDeviceGeneratedCommandsComputeFeaturesNV _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        DeviceGeneratedCompute = _internal.deviceGeneratedCompute;
        DeviceGeneratedComputePipelines = _internal.deviceGeneratedComputePipelines;
        DeviceGeneratedComputeCaptureReplay = _internal.deviceGeneratedComputeCaptureReplay;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 DeviceGeneratedCompute { get; set; }
    public VkBool32 DeviceGeneratedComputePipelines { get; set; }
    public VkBool32 DeviceGeneratedComputeCaptureReplay { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceDeviceGeneratedCommandsComputeFeaturesNV ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceDeviceGeneratedCommandsComputeFeaturesNV();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.deviceGeneratedCompute = DeviceGeneratedCompute;
        _internal.deviceGeneratedComputePipelines = DeviceGeneratedComputePipelines;
        _internal.deviceGeneratedComputeCaptureReplay = DeviceGeneratedComputeCaptureReplay;
        return _internal;
    }

    public static implicit operator PhysicalDeviceDeviceGeneratedCommandsComputeFeaturesNV(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceDeviceGeneratedCommandsComputeFeaturesNV p)
    {
        return new PhysicalDeviceDeviceGeneratedCommandsComputeFeaturesNV(p);
    }

}



