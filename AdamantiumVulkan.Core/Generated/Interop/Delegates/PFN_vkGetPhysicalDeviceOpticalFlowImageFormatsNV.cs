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

// File: C:\VulkanSDK\1.3.275.0\Include\vulkan/vulkan_core.h Line: 18212 Column: 30
public unsafe struct PFN_vkGetPhysicalDeviceOpticalFlowImageFormatsNV
{
    public PFN_vkGetPhysicalDeviceOpticalFlowImageFormatsNV(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, AdamantiumVulkan.Core.Interop.VkOpticalFlowImageFormatInfoNV*, ref uint*, AdamantiumVulkan.Core.Interop.VkOpticalFlowImageFormatPropertiesNV*, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, AdamantiumVulkan.Core.Interop.VkOpticalFlowImageFormatInfoNV*, ref uint*, AdamantiumVulkan.Core.Interop.VkOpticalFlowImageFormatPropertiesNV*, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, AdamantiumVulkan.Core.Interop.VkOpticalFlowImageFormatInfoNV* pOpticalFlowImageFormatInfo, ref uint* pFormatCount, AdamantiumVulkan.Core.Interop.VkOpticalFlowImageFormatPropertiesNV* pImageFormatProperties)
    {
        return InvokeFunc(physicalDevice, pOpticalFlowImageFormatInfo, ref pFormatCount, pImageFormatProperties);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, AdamantiumVulkan.Core.Interop.VkOpticalFlowImageFormatInfoNV* pOpticalFlowImageFormatInfo, ref uint* pFormatCount, AdamantiumVulkan.Core.Interop.VkOpticalFlowImageFormatPropertiesNV* pImageFormatProperties)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, AdamantiumVulkan.Core.Interop.VkOpticalFlowImageFormatInfoNV*, ref uint*, AdamantiumVulkan.Core.Interop.VkOpticalFlowImageFormatPropertiesNV*, Result>)ptr)(physicalDevice, pOpticalFlowImageFormatInfo, ref pFormatCount, pImageFormatProperties);
    }

    public static explicit operator PFN_vkGetPhysicalDeviceOpticalFlowImageFormatsNV(void* ptr) => new(ptr);
}


