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

public unsafe struct PFN_vkGetWinrtDisplayNV
{
    public PFN_vkGetWinrtDisplayNV(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, uint, out AdamantiumVulkan.Core.Interop.VkDisplayKHR_T, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, uint, out AdamantiumVulkan.Core.Interop.VkDisplayKHR_T, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, uint deviceRelativeId, out AdamantiumVulkan.Core.Interop.VkDisplayKHR_T pDisplay)
    {
        return InvokeFunc(physicalDevice, deviceRelativeId, out pDisplay);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, uint deviceRelativeId, out AdamantiumVulkan.Core.Interop.VkDisplayKHR_T pDisplay)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, uint, out AdamantiumVulkan.Core.Interop.VkDisplayKHR_T, Result>)ptr)(physicalDevice, deviceRelativeId, out pDisplay);
    }

    public static explicit operator PFN_vkGetWinrtDisplayNV(void* ptr) => new(ptr);
}

