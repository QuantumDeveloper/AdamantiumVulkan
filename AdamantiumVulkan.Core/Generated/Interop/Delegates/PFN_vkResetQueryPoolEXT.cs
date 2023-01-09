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

public unsafe struct PFN_vkResetQueryPoolEXT
{
    public PFN_vkResetQueryPoolEXT(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkDevice_T, VkQueryPool_T, uint, uint, void>)ptr;
    }

    private delegate* unmanaged<VkDevice_T, VkQueryPool_T, uint, uint, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(VkDevice_T device, VkQueryPool_T queryPool, uint firstQuery, uint queryCount)
    {
         InvokeFunc(device, queryPool, firstQuery, queryCount);
    }
    public static void Invoke(void* ptr, VkDevice_T device, VkQueryPool_T queryPool, uint firstQuery, uint queryCount)
    {
         ((delegate* unmanaged<VkDevice_T, VkQueryPool_T, uint, uint, void>)ptr)(device, queryPool, firstQuery, queryCount);
    }

    public static explicit operator PFN_vkResetQueryPoolEXT(void* ptr) => new(ptr);
}

