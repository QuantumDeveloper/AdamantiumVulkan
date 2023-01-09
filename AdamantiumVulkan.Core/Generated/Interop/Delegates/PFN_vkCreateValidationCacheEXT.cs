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

public unsafe struct PFN_vkCreateValidationCacheEXT
{
    public PFN_vkCreateValidationCacheEXT(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkDevice_T, VkValidationCacheCreateInfoEXT*, VkAllocationCallbacks*, out VkValidationCacheEXT_T, Result>)ptr;
    }

    private delegate* unmanaged<VkDevice_T, VkValidationCacheCreateInfoEXT*, VkAllocationCallbacks*, out VkValidationCacheEXT_T, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(VkDevice_T device, VkValidationCacheCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkValidationCacheEXT_T pValidationCache)
    {
        return InvokeFunc(device, pCreateInfo, pAllocator, out pValidationCache);
    }
    public static Result Invoke(void* ptr, VkDevice_T device, VkValidationCacheCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkValidationCacheEXT_T pValidationCache)
    {
        return ((delegate* unmanaged<VkDevice_T, VkValidationCacheCreateInfoEXT*, VkAllocationCallbacks*, out VkValidationCacheEXT_T, Result>)ptr)(device, pCreateInfo, pAllocator, out pValidationCache);
    }

    public static explicit operator PFN_vkCreateValidationCacheEXT(void* ptr) => new(ptr);
}


