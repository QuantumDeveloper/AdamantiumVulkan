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

// File: C:\VulkanSDK\1.3.275.0\Include\vulkan/vulkan_core.h Line: 10393 Column: 30
public unsafe struct PFN_vkGetPipelineExecutablePropertiesKHR
{
    public PFN_vkGetPipelineExecutablePropertiesKHR(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkPipelineInfoKHR*, ref uint*, AdamantiumVulkan.Core.Interop.VkPipelineExecutablePropertiesKHR*, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkPipelineInfoKHR*, ref uint*, AdamantiumVulkan.Core.Interop.VkPipelineExecutablePropertiesKHR*, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkPipelineInfoKHR* pPipelineInfo, ref uint* pExecutableCount, AdamantiumVulkan.Core.Interop.VkPipelineExecutablePropertiesKHR* pProperties)
    {
        return InvokeFunc(device, pPipelineInfo, ref pExecutableCount, pProperties);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkPipelineInfoKHR* pPipelineInfo, ref uint* pExecutableCount, AdamantiumVulkan.Core.Interop.VkPipelineExecutablePropertiesKHR* pProperties)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkPipelineInfoKHR*, ref uint*, AdamantiumVulkan.Core.Interop.VkPipelineExecutablePropertiesKHR*, Result>)ptr)(device, pPipelineInfo, ref pExecutableCount, pProperties);
    }

    public static explicit operator PFN_vkGetPipelineExecutablePropertiesKHR(void* ptr) => new(ptr);
}


