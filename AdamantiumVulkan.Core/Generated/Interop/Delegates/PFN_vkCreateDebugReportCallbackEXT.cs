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

public unsafe struct PFN_vkCreateDebugReportCallbackEXT
{
    public PFN_vkCreateDebugReportCallbackEXT(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkInstance_T, VkDebugReportCallbackCreateInfoEXT*, VkAllocationCallbacks*, out VkDebugReportCallbackEXT_T, Result>)ptr;
    }

    private delegate* unmanaged<VkInstance_T, VkDebugReportCallbackCreateInfoEXT*, VkAllocationCallbacks*, out VkDebugReportCallbackEXT_T, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(VkInstance_T instance, VkDebugReportCallbackCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkDebugReportCallbackEXT_T pCallback)
    {
        return InvokeFunc(instance, pCreateInfo, pAllocator, out pCallback);
    }
    public static Result Invoke(void* ptr, VkInstance_T instance, VkDebugReportCallbackCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkDebugReportCallbackEXT_T pCallback)
    {
        return ((delegate* unmanaged<VkInstance_T, VkDebugReportCallbackCreateInfoEXT*, VkAllocationCallbacks*, out VkDebugReportCallbackEXT_T, Result>)ptr)(instance, pCreateInfo, pAllocator, out pCallback);
    }

    public static explicit operator PFN_vkCreateDebugReportCallbackEXT(void* ptr) => new(ptr);
}

