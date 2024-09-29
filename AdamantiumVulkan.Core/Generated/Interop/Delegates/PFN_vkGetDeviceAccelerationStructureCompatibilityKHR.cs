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

// File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_core.h Line: 19330 Column: 26
public unsafe struct PFN_vkGetDeviceAccelerationStructureCompatibilityKHR
{
    public PFN_vkGetDeviceAccelerationStructureCompatibilityKHR(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkAccelerationStructureVersionInfoKHR*, ref AccelerationStructureCompatibilityKHR*, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkAccelerationStructureVersionInfoKHR*, ref AccelerationStructureCompatibilityKHR*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkAccelerationStructureVersionInfoKHR* pVersionInfo, ref AccelerationStructureCompatibilityKHR* pCompatibility)
    {
         InvokeFunc(device, pVersionInfo, ref pCompatibility);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkAccelerationStructureVersionInfoKHR* pVersionInfo, ref AccelerationStructureCompatibilityKHR* pCompatibility)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkAccelerationStructureVersionInfoKHR*, ref AccelerationStructureCompatibilityKHR*, void>)ptr)(device, pVersionInfo, ref pCompatibility);
    }

    public static explicit operator PFN_vkGetDeviceAccelerationStructureCompatibilityKHR(void* ptr) => new(ptr);
}


