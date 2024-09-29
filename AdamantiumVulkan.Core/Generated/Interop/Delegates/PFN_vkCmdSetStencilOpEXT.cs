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

// File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_core.h Line: 15001 Column: 26
public unsafe struct PFN_vkCmdSetStencilOpEXT
{
    public PFN_vkCmdSetStencilOpEXT(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, VkStencilFaceFlags, StencilOp, StencilOp, StencilOp, CompareOp, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, VkStencilFaceFlags, StencilOp, StencilOp, StencilOp, CompareOp, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, VkStencilFaceFlags faceMask, StencilOp failOp, StencilOp passOp, StencilOp depthFailOp, CompareOp compareOp)
    {
         InvokeFunc(commandBuffer, faceMask, failOp, passOp, depthFailOp, compareOp);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, VkStencilFaceFlags faceMask, StencilOp failOp, StencilOp passOp, StencilOp depthFailOp, CompareOp compareOp)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, VkStencilFaceFlags, StencilOp, StencilOp, StencilOp, CompareOp, void>)ptr)(commandBuffer, faceMask, failOp, passOp, depthFailOp, compareOp);
    }

    public static explicit operator PFN_vkCmdSetStencilOpEXT(void* ptr) => new(ptr);
}


