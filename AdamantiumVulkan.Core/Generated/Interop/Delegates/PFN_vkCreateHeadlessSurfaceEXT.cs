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

public unsafe struct PFN_vkCreateHeadlessSurfaceEXT
{
    public PFN_vkCreateHeadlessSurfaceEXT(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkInstance_T, VkHeadlessSurfaceCreateInfoEXT*, VkAllocationCallbacks*, out VkSurfaceKHR_T, Result>)ptr;
    }

    private delegate* unmanaged<VkInstance_T, VkHeadlessSurfaceCreateInfoEXT*, VkAllocationCallbacks*, out VkSurfaceKHR_T, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(VkInstance_T instance, VkHeadlessSurfaceCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR_T pSurface)
    {
        return InvokeFunc(instance, pCreateInfo, pAllocator, out pSurface);
    }
    public static Result Invoke(void* ptr, VkInstance_T instance, VkHeadlessSurfaceCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR_T pSurface)
    {
        return ((delegate* unmanaged<VkInstance_T, VkHeadlessSurfaceCreateInfoEXT*, VkAllocationCallbacks*, out VkSurfaceKHR_T, Result>)ptr)(instance, pCreateInfo, pAllocator, out pSurface);
    }

    public static explicit operator PFN_vkCreateHeadlessSurfaceEXT(void* ptr) => new(ptr);
}

