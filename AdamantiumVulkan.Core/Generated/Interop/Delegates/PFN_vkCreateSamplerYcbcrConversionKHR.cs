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

public unsafe struct PFN_vkCreateSamplerYcbcrConversionKHR
{
    public PFN_vkCreateSamplerYcbcrConversionKHR(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkDevice_T, VkSamplerYcbcrConversionCreateInfo*, VkAllocationCallbacks*, out VkSamplerYcbcrConversion_T, Result>)ptr;
    }

    private delegate* unmanaged<VkDevice_T, VkSamplerYcbcrConversionCreateInfo*, VkAllocationCallbacks*, out VkSamplerYcbcrConversion_T, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(VkDevice_T device, VkSamplerYcbcrConversionCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSamplerYcbcrConversion_T pYcbcrConversion)
    {
        return InvokeFunc(device, pCreateInfo, pAllocator, out pYcbcrConversion);
    }
    public static Result Invoke(void* ptr, VkDevice_T device, VkSamplerYcbcrConversionCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSamplerYcbcrConversion_T pYcbcrConversion)
    {
        return ((delegate* unmanaged<VkDevice_T, VkSamplerYcbcrConversionCreateInfo*, VkAllocationCallbacks*, out VkSamplerYcbcrConversion_T, Result>)ptr)(device, pCreateInfo, pAllocator, out pYcbcrConversion);
    }

    public static explicit operator PFN_vkCreateSamplerYcbcrConversionKHR(void* ptr) => new(ptr);
}


