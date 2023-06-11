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

public unsafe struct PFN_vkCmdSetViewportSwizzleNV
{
    public PFN_vkCmdSetViewportSwizzleNV(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, uint, uint, AdamantiumVulkan.Core.Interop.VkViewportSwizzleNV*, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, uint, uint, AdamantiumVulkan.Core.Interop.VkViewportSwizzleNV*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, uint firstViewport, uint viewportCount, AdamantiumVulkan.Core.Interop.VkViewportSwizzleNV* pViewportSwizzles)
    {
         InvokeFunc(commandBuffer, firstViewport, viewportCount, pViewportSwizzles);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, uint firstViewport, uint viewportCount, AdamantiumVulkan.Core.Interop.VkViewportSwizzleNV* pViewportSwizzles)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, uint, uint, AdamantiumVulkan.Core.Interop.VkViewportSwizzleNV*, void>)ptr)(commandBuffer, firstViewport, viewportCount, pViewportSwizzles);
    }

    public static explicit operator PFN_vkCmdSetViewportSwizzleNV(void* ptr) => new(ptr);
}

