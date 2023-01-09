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

public unsafe struct PFN_vkCmdSetBlendConstants
{
    public PFN_vkCmdSetBlendConstants(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkCommandBuffer_T, float[], void>)ptr;
    }

    private delegate* unmanaged<VkCommandBuffer_T, float[], void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(VkCommandBuffer_T commandBuffer, float[] blendConstants)
    {
         InvokeFunc(commandBuffer, blendConstants);
    }
    public static void Invoke(void* ptr, VkCommandBuffer_T commandBuffer, float[] blendConstants)
    {
         ((delegate* unmanaged<VkCommandBuffer_T, float[], void>)ptr)(commandBuffer, blendConstants);
    }

    public static explicit operator PFN_vkCmdSetBlendConstants(void* ptr) => new(ptr);
}

