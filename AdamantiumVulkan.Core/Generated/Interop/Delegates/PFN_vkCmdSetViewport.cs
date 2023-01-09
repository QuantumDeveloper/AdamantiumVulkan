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

public unsafe struct PFN_vkCmdSetViewport
{
    public PFN_vkCmdSetViewport(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkCommandBuffer_T, uint, uint, VkViewport*, void>)ptr;
    }

    private delegate* unmanaged<VkCommandBuffer_T, uint, uint, VkViewport*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(VkCommandBuffer_T commandBuffer, uint firstViewport, uint viewportCount, VkViewport* pViewports)
    {
         InvokeFunc(commandBuffer, firstViewport, viewportCount, pViewports);
    }
    public static void Invoke(void* ptr, VkCommandBuffer_T commandBuffer, uint firstViewport, uint viewportCount, VkViewport* pViewports)
    {
         ((delegate* unmanaged<VkCommandBuffer_T, uint, uint, VkViewport*, void>)ptr)(commandBuffer, firstViewport, viewportCount, pViewports);
    }

    public static explicit operator PFN_vkCmdSetViewport(void* ptr) => new(ptr);
}


