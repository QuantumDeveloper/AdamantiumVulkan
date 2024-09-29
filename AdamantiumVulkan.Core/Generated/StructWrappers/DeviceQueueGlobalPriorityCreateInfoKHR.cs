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

public unsafe partial class DeviceQueueGlobalPriorityCreateInfoKHR : QBDisposableObject
{
    public DeviceQueueGlobalPriorityCreateInfoKHR()
    {
    }

    public DeviceQueueGlobalPriorityCreateInfoKHR(AdamantiumVulkan.Core.Interop.VkDeviceQueueGlobalPriorityCreateInfoKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        GlobalPriority = _internal.globalPriority;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public QueueGlobalPriorityKHR GlobalPriority { get; set; }

    public AdamantiumVulkan.Core.Interop.VkDeviceQueueGlobalPriorityCreateInfoKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkDeviceQueueGlobalPriorityCreateInfoKHR();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (GlobalPriority != default)
        {
            _internal.globalPriority = GlobalPriority;
        }
        return _internal;
    }

    public static implicit operator DeviceQueueGlobalPriorityCreateInfoKHR(AdamantiumVulkan.Core.Interop.VkDeviceQueueGlobalPriorityCreateInfoKHR d)
    {
        return new DeviceQueueGlobalPriorityCreateInfoKHR(d);
    }

}



