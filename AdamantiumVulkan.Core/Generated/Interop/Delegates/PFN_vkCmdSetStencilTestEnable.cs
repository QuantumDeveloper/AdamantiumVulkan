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

public unsafe struct PFN_vkCmdSetStencilTestEnable
{
    public PFN_vkCmdSetStencilTestEnable(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkCommandBuffer_T, VkBool32, void>)ptr;
    }

    private delegate* unmanaged<VkCommandBuffer_T, VkBool32, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(VkCommandBuffer_T commandBuffer, VkBool32 stencilTestEnable)
    {
         InvokeFunc(commandBuffer, stencilTestEnable);
    }
    public static void Invoke(void* ptr, VkCommandBuffer_T commandBuffer, VkBool32 stencilTestEnable)
    {
         ((delegate* unmanaged<VkCommandBuffer_T, VkBool32, void>)ptr)(commandBuffer, stencilTestEnable);
    }

    public static explicit operator PFN_vkCmdSetStencilTestEnable(void* ptr) => new(ptr);
}


