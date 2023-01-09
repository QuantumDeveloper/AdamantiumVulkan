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

public unsafe struct PFN_vkCmdCopyImageToBuffer
{
    public PFN_vkCmdCopyImageToBuffer(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkCommandBuffer_T, VkImage_T, ImageLayout, VkBuffer_T, uint, VkBufferImageCopy*, void>)ptr;
    }

    private delegate* unmanaged<VkCommandBuffer_T, VkImage_T, ImageLayout, VkBuffer_T, uint, VkBufferImageCopy*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(VkCommandBuffer_T commandBuffer, VkImage_T srcImage, ImageLayout srcImageLayout, VkBuffer_T dstBuffer, uint regionCount, VkBufferImageCopy* pRegions)
    {
         InvokeFunc(commandBuffer, srcImage, srcImageLayout, dstBuffer, regionCount, pRegions);
    }
    public static void Invoke(void* ptr, VkCommandBuffer_T commandBuffer, VkImage_T srcImage, ImageLayout srcImageLayout, VkBuffer_T dstBuffer, uint regionCount, VkBufferImageCopy* pRegions)
    {
         ((delegate* unmanaged<VkCommandBuffer_T, VkImage_T, ImageLayout, VkBuffer_T, uint, VkBufferImageCopy*, void>)ptr)(commandBuffer, srcImage, srcImageLayout, dstBuffer, regionCount, pRegions);
    }

    public static explicit operator PFN_vkCmdCopyImageToBuffer(void* ptr) => new(ptr);
}

