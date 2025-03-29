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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 21546 Column: 26
public unsafe struct PFN_vkGetAccelerationStructureBuildSizesKHR
{
    public PFN_vkGetAccelerationStructureBuildSizesKHR(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AccelerationStructureBuildTypeKHR, AdamantiumVulkan.Core.Interop.VkAccelerationStructureBuildGeometryInfoKHR*, uint*, AdamantiumVulkan.Core.Interop.VkAccelerationStructureBuildSizesInfoKHR*, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AccelerationStructureBuildTypeKHR, AdamantiumVulkan.Core.Interop.VkAccelerationStructureBuildGeometryInfoKHR*, uint*, AdamantiumVulkan.Core.Interop.VkAccelerationStructureBuildSizesInfoKHR*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, AccelerationStructureBuildTypeKHR buildType, AdamantiumVulkan.Core.Interop.VkAccelerationStructureBuildGeometryInfoKHR* pBuildInfo, uint* pMaxPrimitiveCounts, AdamantiumVulkan.Core.Interop.VkAccelerationStructureBuildSizesInfoKHR* pSizeInfo)
    {
         InvokeFunc(device, buildType, pBuildInfo, pMaxPrimitiveCounts, pSizeInfo);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, AccelerationStructureBuildTypeKHR buildType, AdamantiumVulkan.Core.Interop.VkAccelerationStructureBuildGeometryInfoKHR* pBuildInfo, uint* pMaxPrimitiveCounts, AdamantiumVulkan.Core.Interop.VkAccelerationStructureBuildSizesInfoKHR* pSizeInfo)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AccelerationStructureBuildTypeKHR, AdamantiumVulkan.Core.Interop.VkAccelerationStructureBuildGeometryInfoKHR*, uint*, AdamantiumVulkan.Core.Interop.VkAccelerationStructureBuildSizesInfoKHR*, void>)ptr)(device, buildType, pBuildInfo, pMaxPrimitiveCounts, pSizeInfo);
    }

    public static explicit operator PFN_vkGetAccelerationStructureBuildSizesKHR(void* ptr) => new(ptr);
}


