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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 16233 Column: 26
public unsafe struct PFN_vkCmdSetPrimitiveTopologyEXT
{
    public PFN_vkCmdSetPrimitiveTopologyEXT(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, PrimitiveTopology, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, PrimitiveTopology, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, PrimitiveTopology primitiveTopology)
    {
         InvokeFunc(commandBuffer, primitiveTopology);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, PrimitiveTopology primitiveTopology)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, PrimitiveTopology, void>)ptr)(commandBuffer, primitiveTopology);
    }

    public static explicit operator PFN_vkCmdSetPrimitiveTopologyEXT(void* ptr) => new(ptr);
}


