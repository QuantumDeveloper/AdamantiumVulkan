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

public unsafe struct PFN_vkCmdOpticalFlowExecuteNV
{
    public PFN_vkCmdOpticalFlowExecuteNV(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkCommandBuffer_T, VkOpticalFlowSessionNV_T, VkOpticalFlowExecuteInfoNV*, void>)ptr;
    }

    private delegate* unmanaged<VkCommandBuffer_T, VkOpticalFlowSessionNV_T, VkOpticalFlowExecuteInfoNV*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(VkCommandBuffer_T commandBuffer, VkOpticalFlowSessionNV_T session, VkOpticalFlowExecuteInfoNV* pExecuteInfo)
    {
         InvokeFunc(commandBuffer, session, pExecuteInfo);
    }
    public static void Invoke(void* ptr, VkCommandBuffer_T commandBuffer, VkOpticalFlowSessionNV_T session, VkOpticalFlowExecuteInfoNV* pExecuteInfo)
    {
         ((delegate* unmanaged<VkCommandBuffer_T, VkOpticalFlowSessionNV_T, VkOpticalFlowExecuteInfoNV*, void>)ptr)(commandBuffer, session, pExecuteInfo);
    }

    public static explicit operator PFN_vkCmdOpticalFlowExecuteNV(void* ptr) => new(ptr);
}


