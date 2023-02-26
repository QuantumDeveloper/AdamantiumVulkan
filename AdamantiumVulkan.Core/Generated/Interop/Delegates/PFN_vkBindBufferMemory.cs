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

public unsafe struct PFN_vkBindBufferMemory
{
    public PFN_vkBindBufferMemory(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkBuffer_T, AdamantiumVulkan.Core.Interop.VkDeviceMemory_T, VkDeviceSize, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkBuffer_T, AdamantiumVulkan.Core.Interop.VkDeviceMemory_T, VkDeviceSize, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkBuffer_T buffer, AdamantiumVulkan.Core.Interop.VkDeviceMemory_T memory, VkDeviceSize memoryOffset)
    {
        return InvokeFunc(device, buffer, memory, memoryOffset);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkBuffer_T buffer, AdamantiumVulkan.Core.Interop.VkDeviceMemory_T memory, VkDeviceSize memoryOffset)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkBuffer_T, AdamantiumVulkan.Core.Interop.VkDeviceMemory_T, VkDeviceSize, Result>)ptr)(device, buffer, memory, memoryOffset);
    }

    public static explicit operator PFN_vkBindBufferMemory(void* ptr) => new(ptr);
}


