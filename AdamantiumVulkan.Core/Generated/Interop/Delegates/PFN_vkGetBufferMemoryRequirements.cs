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

public unsafe struct PFN_vkGetBufferMemoryRequirements
{
    public PFN_vkGetBufferMemoryRequirements(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkDevice_T, VkBuffer_T, VkMemoryRequirements*, void>)ptr;
    }

    private delegate* unmanaged<VkDevice_T, VkBuffer_T, VkMemoryRequirements*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(VkDevice_T device, VkBuffer_T buffer, VkMemoryRequirements* pMemoryRequirements)
    {
         InvokeFunc(device, buffer, pMemoryRequirements);
    }
    public static void Invoke(void* ptr, VkDevice_T device, VkBuffer_T buffer, VkMemoryRequirements* pMemoryRequirements)
    {
         ((delegate* unmanaged<VkDevice_T, VkBuffer_T, VkMemoryRequirements*, void>)ptr)(device, buffer, pMemoryRequirements);
    }

    public static explicit operator PFN_vkGetBufferMemoryRequirements(void* ptr) => new(ptr);
}


