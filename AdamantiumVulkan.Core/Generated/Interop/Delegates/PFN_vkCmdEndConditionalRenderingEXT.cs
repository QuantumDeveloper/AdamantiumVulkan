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

public unsafe struct PFN_vkCmdEndConditionalRenderingEXT
{
    public PFN_vkCmdEndConditionalRenderingEXT(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkCommandBuffer_T, void>)ptr;
    }

    private delegate* unmanaged<VkCommandBuffer_T, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(VkCommandBuffer_T commandBuffer)
    {
         InvokeFunc(commandBuffer);
    }
    public static void Invoke(void* ptr, VkCommandBuffer_T commandBuffer)
    {
         ((delegate* unmanaged<VkCommandBuffer_T, void>)ptr)(commandBuffer);
    }

    public static explicit operator PFN_vkCmdEndConditionalRenderingEXT(void* ptr) => new(ptr);
}


