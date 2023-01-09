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

public unsafe partial class PhysicalDeviceAccelerationStructureFeaturesKHR : QBDisposableObject
{
    public PhysicalDeviceAccelerationStructureFeaturesKHR()
    {
    }

    public PhysicalDeviceAccelerationStructureFeaturesKHR(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceAccelerationStructureFeaturesKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        AccelerationStructure = _internal.accelerationStructure;
        AccelerationStructureCaptureReplay = _internal.accelerationStructureCaptureReplay;
        AccelerationStructureIndirectBuild = _internal.accelerationStructureIndirectBuild;
        AccelerationStructureHostCommands = _internal.accelerationStructureHostCommands;
        DescriptorBindingAccelerationStructureUpdateAfterBind = _internal.descriptorBindingAccelerationStructureUpdateAfterBind;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 AccelerationStructure { get; set; }
    public VkBool32 AccelerationStructureCaptureReplay { get; set; }
    public VkBool32 AccelerationStructureIndirectBuild { get; set; }
    public VkBool32 AccelerationStructureHostCommands { get; set; }
    public VkBool32 DescriptorBindingAccelerationStructureUpdateAfterBind { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceAccelerationStructureFeaturesKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceAccelerationStructureFeaturesKHR();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.accelerationStructure = AccelerationStructure;
        _internal.accelerationStructureCaptureReplay = AccelerationStructureCaptureReplay;
        _internal.accelerationStructureIndirectBuild = AccelerationStructureIndirectBuild;
        _internal.accelerationStructureHostCommands = AccelerationStructureHostCommands;
        _internal.descriptorBindingAccelerationStructureUpdateAfterBind = DescriptorBindingAccelerationStructureUpdateAfterBind;
        return _internal;
    }

    public static implicit operator PhysicalDeviceAccelerationStructureFeaturesKHR(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceAccelerationStructureFeaturesKHR p)
    {
        return new PhysicalDeviceAccelerationStructureFeaturesKHR(p);
    }

}



