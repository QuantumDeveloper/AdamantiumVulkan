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

public unsafe struct PFN_vkGetMemoryWin32HandleKHR
{
    public PFN_vkGetMemoryWin32HandleKHR(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Windows.Interop.VkMemoryGetWin32HandleInfoKHR*, IntPtr, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Windows.Interop.VkMemoryGetWin32HandleInfoKHR*, IntPtr, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Windows.Interop.VkMemoryGetWin32HandleInfoKHR* pGetWin32HandleInfo, IntPtr pHandle)
    {
        return InvokeFunc(device, pGetWin32HandleInfo, pHandle);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Windows.Interop.VkMemoryGetWin32HandleInfoKHR* pGetWin32HandleInfo, IntPtr pHandle)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Windows.Interop.VkMemoryGetWin32HandleInfoKHR*, IntPtr, Result>)ptr)(device, pGetWin32HandleInfo, pHandle);
    }

    public static explicit operator PFN_vkGetMemoryWin32HandleKHR(void* ptr) => new(ptr);
}


