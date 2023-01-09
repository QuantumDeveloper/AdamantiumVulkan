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

public unsafe struct PFN_vkCmdCopyBufferToImage2
{
    public PFN_vkCmdCopyBufferToImage2(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkCommandBuffer_T, VkCopyBufferToImageInfo2*, void>)ptr;
    }

    private delegate* unmanaged<VkCommandBuffer_T, VkCopyBufferToImageInfo2*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(VkCommandBuffer_T commandBuffer, VkCopyBufferToImageInfo2* pCopyBufferToImageInfo)
    {
         InvokeFunc(commandBuffer, pCopyBufferToImageInfo);
    }
    public static void Invoke(void* ptr, VkCommandBuffer_T commandBuffer, VkCopyBufferToImageInfo2* pCopyBufferToImageInfo)
    {
         ((delegate* unmanaged<VkCommandBuffer_T, VkCopyBufferToImageInfo2*, void>)ptr)(commandBuffer, pCopyBufferToImageInfo);
    }

    public static explicit operator PFN_vkCmdCopyBufferToImage2(void* ptr) => new(ptr);
}


