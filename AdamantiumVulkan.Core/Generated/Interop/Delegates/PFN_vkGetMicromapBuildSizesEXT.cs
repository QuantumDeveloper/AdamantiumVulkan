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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 18535 Column: 26
public unsafe struct PFN_vkGetMicromapBuildSizesEXT
{
    public PFN_vkGetMicromapBuildSizesEXT(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AccelerationStructureBuildTypeKHR, AdamantiumVulkan.Core.Interop.VkMicromapBuildInfoEXT*, AdamantiumVulkan.Core.Interop.VkMicromapBuildSizesInfoEXT*, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AccelerationStructureBuildTypeKHR, AdamantiumVulkan.Core.Interop.VkMicromapBuildInfoEXT*, AdamantiumVulkan.Core.Interop.VkMicromapBuildSizesInfoEXT*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, AccelerationStructureBuildTypeKHR buildType, AdamantiumVulkan.Core.Interop.VkMicromapBuildInfoEXT* pBuildInfo, AdamantiumVulkan.Core.Interop.VkMicromapBuildSizesInfoEXT* pSizeInfo)
    {
         InvokeFunc(device, buildType, pBuildInfo, pSizeInfo);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, AccelerationStructureBuildTypeKHR buildType, AdamantiumVulkan.Core.Interop.VkMicromapBuildInfoEXT* pBuildInfo, AdamantiumVulkan.Core.Interop.VkMicromapBuildSizesInfoEXT* pSizeInfo)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AccelerationStructureBuildTypeKHR, AdamantiumVulkan.Core.Interop.VkMicromapBuildInfoEXT*, AdamantiumVulkan.Core.Interop.VkMicromapBuildSizesInfoEXT*, void>)ptr)(device, buildType, pBuildInfo, pSizeInfo);
    }

    public static explicit operator PFN_vkGetMicromapBuildSizesEXT(void* ptr) => new(ptr);
}


