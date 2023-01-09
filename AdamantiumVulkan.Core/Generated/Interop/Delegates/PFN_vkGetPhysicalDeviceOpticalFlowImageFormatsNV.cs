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

public unsafe struct PFN_vkGetPhysicalDeviceOpticalFlowImageFormatsNV
{
    public PFN_vkGetPhysicalDeviceOpticalFlowImageFormatsNV(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkPhysicalDevice_T, VkOpticalFlowImageFormatInfoNV*, ref uint*, VkOpticalFlowImageFormatPropertiesNV*, Result>)ptr;
    }

    private delegate* unmanaged<VkPhysicalDevice_T, VkOpticalFlowImageFormatInfoNV*, ref uint*, VkOpticalFlowImageFormatPropertiesNV*, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(VkPhysicalDevice_T physicalDevice, VkOpticalFlowImageFormatInfoNV* pOpticalFlowImageFormatInfo, ref uint* pFormatCount, VkOpticalFlowImageFormatPropertiesNV* pImageFormatProperties)
    {
        return InvokeFunc(physicalDevice, pOpticalFlowImageFormatInfo, ref pFormatCount, pImageFormatProperties);
    }
    public static Result Invoke(void* ptr, VkPhysicalDevice_T physicalDevice, VkOpticalFlowImageFormatInfoNV* pOpticalFlowImageFormatInfo, ref uint* pFormatCount, VkOpticalFlowImageFormatPropertiesNV* pImageFormatProperties)
    {
        return ((delegate* unmanaged<VkPhysicalDevice_T, VkOpticalFlowImageFormatInfoNV*, ref uint*, VkOpticalFlowImageFormatPropertiesNV*, Result>)ptr)(physicalDevice, pOpticalFlowImageFormatInfo, ref pFormatCount, pImageFormatProperties);
    }

    public static explicit operator PFN_vkGetPhysicalDeviceOpticalFlowImageFormatsNV(void* ptr) => new(ptr);
}


