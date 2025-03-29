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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 15023 Column: 30
public unsafe struct PFN_vkGetAccelerationStructureHandleNV
{
    public PFN_vkGetAccelerationStructureHandleNV(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkAccelerationStructureNV_T, ulong, void*, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkAccelerationStructureNV_T, ulong, void*, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkAccelerationStructureNV_T accelerationStructure, ulong dataSize, void* pData)
    {
        return InvokeFunc(device, accelerationStructure, dataSize, pData);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkAccelerationStructureNV_T accelerationStructure, ulong dataSize, void* pData)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkAccelerationStructureNV_T, ulong, void*, Result>)ptr)(device, accelerationStructure, dataSize, pData);
    }

    public static explicit operator PFN_vkGetAccelerationStructureHandleNV(void* ptr) => new(ptr);
}


