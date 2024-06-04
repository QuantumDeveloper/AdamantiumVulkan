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

// File: C:\VulkanSDK\1.3.275.0\Include\vulkan/vulkan_core.h Line: 16568 Column: 30
public unsafe struct PFN_vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI
{
    public PFN_vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkRenderPass_T, AdamantiumVulkan.Core.Interop.VkExtent2D*, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkRenderPass_T, AdamantiumVulkan.Core.Interop.VkExtent2D*, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkRenderPass_T renderpass, AdamantiumVulkan.Core.Interop.VkExtent2D* pMaxWorkgroupSize)
    {
        return InvokeFunc(device, renderpass, pMaxWorkgroupSize);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkRenderPass_T renderpass, AdamantiumVulkan.Core.Interop.VkExtent2D* pMaxWorkgroupSize)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkRenderPass_T, AdamantiumVulkan.Core.Interop.VkExtent2D*, Result>)ptr)(device, renderpass, pMaxWorkgroupSize);
    }

    public static explicit operator PFN_vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI(void* ptr) => new(ptr);
}


