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

public unsafe struct PFN_vkCmdSetDepthBounds
{
    public PFN_vkCmdSetDepthBounds(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, float, float, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, float, float, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, float minDepthBounds, float maxDepthBounds)
    {
         InvokeFunc(commandBuffer, minDepthBounds, maxDepthBounds);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, float minDepthBounds, float maxDepthBounds)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, float, float, void>)ptr)(commandBuffer, minDepthBounds, maxDepthBounds);
    }

    public static explicit operator PFN_vkCmdSetDepthBounds(void* ptr) => new(ptr);
}


