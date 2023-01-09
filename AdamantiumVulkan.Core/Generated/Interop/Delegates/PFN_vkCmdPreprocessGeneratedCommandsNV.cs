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

public unsafe struct PFN_vkCmdPreprocessGeneratedCommandsNV
{
    public PFN_vkCmdPreprocessGeneratedCommandsNV(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkCommandBuffer_T, VkGeneratedCommandsInfoNV*, void>)ptr;
    }

    private delegate* unmanaged<VkCommandBuffer_T, VkGeneratedCommandsInfoNV*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(VkCommandBuffer_T commandBuffer, VkGeneratedCommandsInfoNV* pGeneratedCommandsInfo)
    {
         InvokeFunc(commandBuffer, pGeneratedCommandsInfo);
    }
    public static void Invoke(void* ptr, VkCommandBuffer_T commandBuffer, VkGeneratedCommandsInfoNV* pGeneratedCommandsInfo)
    {
         ((delegate* unmanaged<VkCommandBuffer_T, VkGeneratedCommandsInfoNV*, void>)ptr)(commandBuffer, pGeneratedCommandsInfo);
    }

    public static explicit operator PFN_vkCmdPreprocessGeneratedCommandsNV(void* ptr) => new(ptr);
}


