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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 8400 Column: 30
public unsafe struct PFN_vkTransitionImageLayout
{
    public PFN_vkTransitionImageLayout(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, uint, AdamantiumVulkan.Core.Interop.VkHostImageLayoutTransitionInfo*, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, uint, AdamantiumVulkan.Core.Interop.VkHostImageLayoutTransitionInfo*, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, uint transitionCount, AdamantiumVulkan.Core.Interop.VkHostImageLayoutTransitionInfo* pTransitions)
    {
        return InvokeFunc(device, transitionCount, pTransitions);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, uint transitionCount, AdamantiumVulkan.Core.Interop.VkHostImageLayoutTransitionInfo* pTransitions)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, uint, AdamantiumVulkan.Core.Interop.VkHostImageLayoutTransitionInfo*, Result>)ptr)(device, transitionCount, pTransitions);
    }

    public static explicit operator PFN_vkTransitionImageLayout(void* ptr) => new(ptr);
}


