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

// File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_core.h Line: 20553 Column: 26
public unsafe struct PFN_vkCmdExecuteGeneratedCommandsEXT
{
    public PFN_vkCmdExecuteGeneratedCommandsEXT(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, VkBool32, AdamantiumVulkan.Core.Interop.VkGeneratedCommandsInfoEXT*, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, VkBool32, AdamantiumVulkan.Core.Interop.VkGeneratedCommandsInfoEXT*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, VkBool32 isPreprocessed, AdamantiumVulkan.Core.Interop.VkGeneratedCommandsInfoEXT* pGeneratedCommandsInfo)
    {
         InvokeFunc(commandBuffer, isPreprocessed, pGeneratedCommandsInfo);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, VkBool32 isPreprocessed, AdamantiumVulkan.Core.Interop.VkGeneratedCommandsInfoEXT* pGeneratedCommandsInfo)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, VkBool32, AdamantiumVulkan.Core.Interop.VkGeneratedCommandsInfoEXT*, void>)ptr)(commandBuffer, isPreprocessed, pGeneratedCommandsInfo);
    }

    public static explicit operator PFN_vkCmdExecuteGeneratedCommandsEXT(void* ptr) => new(ptr);
}


