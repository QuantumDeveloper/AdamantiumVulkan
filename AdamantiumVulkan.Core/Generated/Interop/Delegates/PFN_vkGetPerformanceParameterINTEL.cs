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

// File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_core.h Line: 15523 Column: 30
public unsafe struct PFN_vkGetPerformanceParameterINTEL
{
    public PFN_vkGetPerformanceParameterINTEL(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, PerformanceParameterTypeINTEL, AdamantiumVulkan.Core.Interop.VkPerformanceValueINTEL*, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, PerformanceParameterTypeINTEL, AdamantiumVulkan.Core.Interop.VkPerformanceValueINTEL*, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, PerformanceParameterTypeINTEL parameter, AdamantiumVulkan.Core.Interop.VkPerformanceValueINTEL* pValue)
    {
        return InvokeFunc(device, parameter, pValue);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, PerformanceParameterTypeINTEL parameter, AdamantiumVulkan.Core.Interop.VkPerformanceValueINTEL* pValue)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, PerformanceParameterTypeINTEL, AdamantiumVulkan.Core.Interop.VkPerformanceValueINTEL*, Result>)ptr)(device, parameter, pValue);
    }

    public static explicit operator PFN_vkGetPerformanceParameterINTEL(void* ptr) => new(ptr);
}


