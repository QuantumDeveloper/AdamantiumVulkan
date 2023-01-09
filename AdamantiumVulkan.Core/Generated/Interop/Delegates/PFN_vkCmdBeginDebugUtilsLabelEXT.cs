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

public unsafe struct PFN_vkCmdBeginDebugUtilsLabelEXT
{
    public PFN_vkCmdBeginDebugUtilsLabelEXT(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkCommandBuffer_T, VkDebugUtilsLabelEXT*, void>)ptr;
    }

    private delegate* unmanaged<VkCommandBuffer_T, VkDebugUtilsLabelEXT*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(VkCommandBuffer_T commandBuffer, VkDebugUtilsLabelEXT* pLabelInfo)
    {
         InvokeFunc(commandBuffer, pLabelInfo);
    }
    public static void Invoke(void* ptr, VkCommandBuffer_T commandBuffer, VkDebugUtilsLabelEXT* pLabelInfo)
    {
         ((delegate* unmanaged<VkCommandBuffer_T, VkDebugUtilsLabelEXT*, void>)ptr)(commandBuffer, pLabelInfo);
    }

    public static explicit operator PFN_vkCmdBeginDebugUtilsLabelEXT(void* ptr) => new(ptr);
}


