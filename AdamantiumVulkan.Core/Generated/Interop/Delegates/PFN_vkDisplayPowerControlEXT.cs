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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 13788 Column: 30
public unsafe struct PFN_vkDisplayPowerControlEXT
{
    public PFN_vkDisplayPowerControlEXT(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkDisplayKHR_T, AdamantiumVulkan.Core.Interop.VkDisplayPowerInfoEXT*, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkDisplayKHR_T, AdamantiumVulkan.Core.Interop.VkDisplayPowerInfoEXT*, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkDisplayKHR_T display, AdamantiumVulkan.Core.Interop.VkDisplayPowerInfoEXT* pDisplayPowerInfo)
    {
        return InvokeFunc(device, display, pDisplayPowerInfo);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkDisplayKHR_T display, AdamantiumVulkan.Core.Interop.VkDisplayPowerInfoEXT* pDisplayPowerInfo)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkDisplayKHR_T, AdamantiumVulkan.Core.Interop.VkDisplayPowerInfoEXT*, Result>)ptr)(device, display, pDisplayPowerInfo);
    }

    public static explicit operator PFN_vkDisplayPowerControlEXT(void* ptr) => new(ptr);
}


