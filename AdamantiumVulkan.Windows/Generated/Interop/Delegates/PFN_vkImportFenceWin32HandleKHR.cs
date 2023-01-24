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

public unsafe struct PFN_vkImportFenceWin32HandleKHR
{
    public PFN_vkImportFenceWin32HandleKHR(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Windows.Interop.VkImportFenceWin32HandleInfoKHR*, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Windows.Interop.VkImportFenceWin32HandleInfoKHR*, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Windows.Interop.VkImportFenceWin32HandleInfoKHR* pImportFenceWin32HandleInfo)
    {
        return InvokeFunc(device, pImportFenceWin32HandleInfo);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Windows.Interop.VkImportFenceWin32HandleInfoKHR* pImportFenceWin32HandleInfo)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Windows.Interop.VkImportFenceWin32HandleInfoKHR*, Result>)ptr)(device, pImportFenceWin32HandleInfo);
    }

    public static explicit operator PFN_vkImportFenceWin32HandleKHR(void* ptr) => new(ptr);
}


