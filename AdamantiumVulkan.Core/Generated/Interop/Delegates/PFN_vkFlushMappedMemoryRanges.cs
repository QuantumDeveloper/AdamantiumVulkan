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

// File: C:\VulkanSDK\1.3.275.0\Include\vulkan/vulkan_core.h Line: 3938 Column: 30
public unsafe struct PFN_vkFlushMappedMemoryRanges
{
    public PFN_vkFlushMappedMemoryRanges(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, uint, AdamantiumVulkan.Core.Interop.VkMappedMemoryRange*, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, uint, AdamantiumVulkan.Core.Interop.VkMappedMemoryRange*, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, uint memoryRangeCount, AdamantiumVulkan.Core.Interop.VkMappedMemoryRange* pMemoryRanges)
    {
        return InvokeFunc(device, memoryRangeCount, pMemoryRanges);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, uint memoryRangeCount, AdamantiumVulkan.Core.Interop.VkMappedMemoryRange* pMemoryRanges)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, uint, AdamantiumVulkan.Core.Interop.VkMappedMemoryRange*, Result>)ptr)(device, memoryRangeCount, pMemoryRanges);
    }

    public static explicit operator PFN_vkFlushMappedMemoryRanges(void* ptr) => new(ptr);
}


