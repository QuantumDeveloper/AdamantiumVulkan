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

public unsafe struct PFN_vkCmdCopyImageToBuffer2
{
    public PFN_vkCmdCopyImageToBuffer2(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkCommandBuffer_T, VkCopyImageToBufferInfo2*, void>)ptr;
    }

    private delegate* unmanaged<VkCommandBuffer_T, VkCopyImageToBufferInfo2*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(VkCommandBuffer_T commandBuffer, VkCopyImageToBufferInfo2* pCopyImageToBufferInfo)
    {
         InvokeFunc(commandBuffer, pCopyImageToBufferInfo);
    }
    public static void Invoke(void* ptr, VkCommandBuffer_T commandBuffer, VkCopyImageToBufferInfo2* pCopyImageToBufferInfo)
    {
         ((delegate* unmanaged<VkCommandBuffer_T, VkCopyImageToBufferInfo2*, void>)ptr)(commandBuffer, pCopyImageToBufferInfo);
    }

    public static explicit operator PFN_vkCmdCopyImageToBuffer2(void* ptr) => new(ptr);
}

