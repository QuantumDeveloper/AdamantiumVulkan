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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 4192 Column: 30
public unsafe struct PFN_vkWaitForFences
{
    public PFN_vkWaitForFences(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, uint, AdamantiumVulkan.Core.Interop.VkFence_T*, VkBool32, ulong, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, uint, AdamantiumVulkan.Core.Interop.VkFence_T*, VkBool32, ulong, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, uint fenceCount, AdamantiumVulkan.Core.Interop.VkFence_T* pFences, VkBool32 waitAll, ulong timeout)
    {
        return InvokeFunc(device, fenceCount, pFences, waitAll, timeout);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, uint fenceCount, AdamantiumVulkan.Core.Interop.VkFence_T* pFences, VkBool32 waitAll, ulong timeout)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, uint, AdamantiumVulkan.Core.Interop.VkFence_T*, VkBool32, ulong, Result>)ptr)(device, fenceCount, pFences, waitAll, timeout);
    }

    public static explicit operator PFN_vkWaitForFences(void* ptr) => new(ptr);
}


