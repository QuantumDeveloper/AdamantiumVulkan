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

// File: C:\VulkanSDK\1.3.275.0\Include\vulkan/vulkan_core.h Line: 17090 Column: 26
public unsafe struct PFN_vkCmdBuildMicromapsEXT
{
    public PFN_vkCmdBuildMicromapsEXT(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, uint, AdamantiumVulkan.Core.Interop.VkMicromapBuildInfoEXT*, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, uint, AdamantiumVulkan.Core.Interop.VkMicromapBuildInfoEXT*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, uint infoCount, AdamantiumVulkan.Core.Interop.VkMicromapBuildInfoEXT* pInfos)
    {
         InvokeFunc(commandBuffer, infoCount, pInfos);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, uint infoCount, AdamantiumVulkan.Core.Interop.VkMicromapBuildInfoEXT* pInfos)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, uint, AdamantiumVulkan.Core.Interop.VkMicromapBuildInfoEXT*, void>)ptr)(commandBuffer, infoCount, pInfos);
    }

    public static explicit operator PFN_vkCmdBuildMicromapsEXT(void* ptr) => new(ptr);
}


