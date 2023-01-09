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

public unsafe struct PFN_vkGetPerformanceParameterINTEL
{
    public PFN_vkGetPerformanceParameterINTEL(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkDevice_T, PerformanceParameterTypeINTEL, VkPerformanceValueINTEL*, Result>)ptr;
    }

    private delegate* unmanaged<VkDevice_T, PerformanceParameterTypeINTEL, VkPerformanceValueINTEL*, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(VkDevice_T device, PerformanceParameterTypeINTEL parameter, VkPerformanceValueINTEL* pValue)
    {
        return InvokeFunc(device, parameter, pValue);
    }
    public static Result Invoke(void* ptr, VkDevice_T device, PerformanceParameterTypeINTEL parameter, VkPerformanceValueINTEL* pValue)
    {
        return ((delegate* unmanaged<VkDevice_T, PerformanceParameterTypeINTEL, VkPerformanceValueINTEL*, Result>)ptr)(device, parameter, pValue);
    }

    public static explicit operator PFN_vkGetPerformanceParameterINTEL(void* ptr) => new(ptr);
}

