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

public unsafe struct PFN_vkCmdSetRasterizerDiscardEnable
{
    public PFN_vkCmdSetRasterizerDiscardEnable(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkCommandBuffer_T, VkBool32, void>)ptr;
    }

    private delegate* unmanaged<VkCommandBuffer_T, VkBool32, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(VkCommandBuffer_T commandBuffer, VkBool32 rasterizerDiscardEnable)
    {
         InvokeFunc(commandBuffer, rasterizerDiscardEnable);
    }
    public static void Invoke(void* ptr, VkCommandBuffer_T commandBuffer, VkBool32 rasterizerDiscardEnable)
    {
         ((delegate* unmanaged<VkCommandBuffer_T, VkBool32, void>)ptr)(commandBuffer, rasterizerDiscardEnable);
    }

    public static explicit operator PFN_vkCmdSetRasterizerDiscardEnable(void* ptr) => new(ptr);
}


