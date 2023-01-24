// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System.Security;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using QuantumBinding.Utils;
using AdamantiumVulkan.Core;

namespace AdamantiumVulkan.Core.Interop;

public unsafe struct PFN_vkGetPhysicalDeviceDisplayPlanePropertiesKHR
{
    public PFN_vkGetPhysicalDeviceDisplayPlanePropertiesKHR(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, ref uint*, AdamantiumVulkan.Core.Interop.VkDisplayPlanePropertiesKHR*, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, ref uint*, AdamantiumVulkan.Core.Interop.VkDisplayPlanePropertiesKHR*, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, ref uint* pPropertyCount, AdamantiumVulkan.Core.Interop.VkDisplayPlanePropertiesKHR* pProperties)
    {
        return InvokeFunc(physicalDevice, ref pPropertyCount, pProperties);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, ref uint* pPropertyCount, AdamantiumVulkan.Core.Interop.VkDisplayPlanePropertiesKHR* pProperties)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, ref uint*, AdamantiumVulkan.Core.Interop.VkDisplayPlanePropertiesKHR*, Result>)ptr)(physicalDevice, ref pPropertyCount, pProperties);
    }

    public static explicit operator PFN_vkGetPhysicalDeviceDisplayPlanePropertiesKHR(void* ptr) => new(ptr);
}


