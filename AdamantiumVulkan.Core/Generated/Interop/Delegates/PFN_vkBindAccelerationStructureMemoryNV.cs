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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 15016 Column: 30
public unsafe struct PFN_vkBindAccelerationStructureMemoryNV
{
    public PFN_vkBindAccelerationStructureMemoryNV(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, uint, AdamantiumVulkan.Core.Interop.VkBindAccelerationStructureMemoryInfoNV*, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, uint, AdamantiumVulkan.Core.Interop.VkBindAccelerationStructureMemoryInfoNV*, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, uint bindInfoCount, AdamantiumVulkan.Core.Interop.VkBindAccelerationStructureMemoryInfoNV* pBindInfos)
    {
        return InvokeFunc(device, bindInfoCount, pBindInfos);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, uint bindInfoCount, AdamantiumVulkan.Core.Interop.VkBindAccelerationStructureMemoryInfoNV* pBindInfos)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, uint, AdamantiumVulkan.Core.Interop.VkBindAccelerationStructureMemoryInfoNV*, Result>)ptr)(device, bindInfoCount, pBindInfos);
    }

    public static explicit operator PFN_vkBindAccelerationStructureMemoryNV(void* ptr) => new(ptr);
}


