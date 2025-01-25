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

// File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_core.h Line: 4226 Column: 26
public unsafe struct PFN_vkCmdBlitImage
{
    public PFN_vkCmdBlitImage(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, AdamantiumVulkan.Core.Interop.VkImage_T, ImageLayout, AdamantiumVulkan.Core.Interop.VkImage_T, ImageLayout, uint, AdamantiumVulkan.Core.Interop.VkImageBlit*, Filter, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, AdamantiumVulkan.Core.Interop.VkImage_T, ImageLayout, AdamantiumVulkan.Core.Interop.VkImage_T, ImageLayout, uint, AdamantiumVulkan.Core.Interop.VkImageBlit*, Filter, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, AdamantiumVulkan.Core.Interop.VkImage_T srcImage, ImageLayout srcImageLayout, AdamantiumVulkan.Core.Interop.VkImage_T dstImage, ImageLayout dstImageLayout, uint regionCount, AdamantiumVulkan.Core.Interop.VkImageBlit* pRegions, Filter filter)
    {
         InvokeFunc(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions, filter);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, AdamantiumVulkan.Core.Interop.VkImage_T srcImage, ImageLayout srcImageLayout, AdamantiumVulkan.Core.Interop.VkImage_T dstImage, ImageLayout dstImageLayout, uint regionCount, AdamantiumVulkan.Core.Interop.VkImageBlit* pRegions, Filter filter)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, AdamantiumVulkan.Core.Interop.VkImage_T, ImageLayout, AdamantiumVulkan.Core.Interop.VkImage_T, ImageLayout, uint, AdamantiumVulkan.Core.Interop.VkImageBlit*, Filter, void>)ptr)(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions, filter);
    }

    public static explicit operator PFN_vkCmdBlitImage(void* ptr) => new(ptr);
}


