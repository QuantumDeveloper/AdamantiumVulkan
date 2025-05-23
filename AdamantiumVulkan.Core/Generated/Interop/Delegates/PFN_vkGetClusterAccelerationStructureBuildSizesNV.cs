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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 20814 Column: 26
public unsafe struct PFN_vkGetClusterAccelerationStructureBuildSizesNV
{
    public PFN_vkGetClusterAccelerationStructureBuildSizesNV(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkClusterAccelerationStructureInputInfoNV*, AdamantiumVulkan.Core.Interop.VkAccelerationStructureBuildSizesInfoKHR*, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkClusterAccelerationStructureInputInfoNV*, AdamantiumVulkan.Core.Interop.VkAccelerationStructureBuildSizesInfoKHR*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkClusterAccelerationStructureInputInfoNV* pInfo, AdamantiumVulkan.Core.Interop.VkAccelerationStructureBuildSizesInfoKHR* pSizeInfo)
    {
         InvokeFunc(device, pInfo, pSizeInfo);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkClusterAccelerationStructureInputInfoNV* pInfo, AdamantiumVulkan.Core.Interop.VkAccelerationStructureBuildSizesInfoKHR* pSizeInfo)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkClusterAccelerationStructureInputInfoNV*, AdamantiumVulkan.Core.Interop.VkAccelerationStructureBuildSizesInfoKHR*, void>)ptr)(device, pInfo, pSizeInfo);
    }

    public static explicit operator PFN_vkGetClusterAccelerationStructureBuildSizesNV(void* ptr) => new(ptr);
}


