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

// File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_core.h Line: 18584 Column: 30
public unsafe struct PFN_vkCreateShadersEXT
{
    public PFN_vkCreateShadersEXT(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, uint, AdamantiumVulkan.Core.Interop.VkShaderCreateInfoEXT*, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks*, AdamantiumVulkan.Core.Interop.VkShaderEXT_T*, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, uint, AdamantiumVulkan.Core.Interop.VkShaderCreateInfoEXT*, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks*, AdamantiumVulkan.Core.Interop.VkShaderEXT_T*, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, uint createInfoCount, AdamantiumVulkan.Core.Interop.VkShaderCreateInfoEXT* pCreateInfos, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks* pAllocator, AdamantiumVulkan.Core.Interop.VkShaderEXT_T* pShaders)
    {
        return InvokeFunc(device, createInfoCount, pCreateInfos, pAllocator, pShaders);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, uint createInfoCount, AdamantiumVulkan.Core.Interop.VkShaderCreateInfoEXT* pCreateInfos, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks* pAllocator, AdamantiumVulkan.Core.Interop.VkShaderEXT_T* pShaders)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, uint, AdamantiumVulkan.Core.Interop.VkShaderCreateInfoEXT*, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks*, AdamantiumVulkan.Core.Interop.VkShaderEXT_T*, Result>)ptr)(device, createInfoCount, pCreateInfos, pAllocator, pShaders);
    }

    public static explicit operator PFN_vkCreateShadersEXT(void* ptr) => new(ptr);
}

