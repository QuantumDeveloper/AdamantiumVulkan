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

public unsafe partial class PhysicalDeviceDeviceMemoryReportFeaturesEXT : QBDisposableObject
{
    public PhysicalDeviceDeviceMemoryReportFeaturesEXT()
    {
    }

    public PhysicalDeviceDeviceMemoryReportFeaturesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceDeviceMemoryReportFeaturesEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        DeviceMemoryReport = _internal.deviceMemoryReport;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 DeviceMemoryReport { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceDeviceMemoryReportFeaturesEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceDeviceMemoryReportFeaturesEXT();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.deviceMemoryReport = DeviceMemoryReport;
        return _internal;
    }

    public static implicit operator PhysicalDeviceDeviceMemoryReportFeaturesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceDeviceMemoryReportFeaturesEXT p)
    {
        return new PhysicalDeviceDeviceMemoryReportFeaturesEXT(p);
    }

}


