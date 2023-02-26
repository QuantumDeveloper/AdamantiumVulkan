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
using AdamantiumVulkan.Core.Interop;

namespace AdamantiumVulkan.Windows.Interop;

public unsafe struct PFN_vkCreateWin32SurfaceKHR
{
    public PFN_vkCreateWin32SurfaceKHR(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkInstance_T, AdamantiumVulkan.Windows.Interop.VkWin32SurfaceCreateInfoKHR*, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks*, out AdamantiumVulkan.Core.Interop.VkSurfaceKHR_T, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkInstance_T, AdamantiumVulkan.Windows.Interop.VkWin32SurfaceCreateInfoKHR*, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks*, out AdamantiumVulkan.Core.Interop.VkSurfaceKHR_T, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkInstance_T instance, AdamantiumVulkan.Windows.Interop.VkWin32SurfaceCreateInfoKHR* pCreateInfo, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks* pAllocator, out AdamantiumVulkan.Core.Interop.VkSurfaceKHR_T pSurface)
    {
        return InvokeFunc(instance, pCreateInfo, pAllocator, out pSurface);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkInstance_T instance, AdamantiumVulkan.Windows.Interop.VkWin32SurfaceCreateInfoKHR* pCreateInfo, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks* pAllocator, out AdamantiumVulkan.Core.Interop.VkSurfaceKHR_T pSurface)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkInstance_T, AdamantiumVulkan.Windows.Interop.VkWin32SurfaceCreateInfoKHR*, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks*, out AdamantiumVulkan.Core.Interop.VkSurfaceKHR_T, Result>)ptr)(instance, pCreateInfo, pAllocator, out pSurface);
    }

    public static explicit operator PFN_vkCreateWin32SurfaceKHR(void* ptr) => new(ptr);
}


