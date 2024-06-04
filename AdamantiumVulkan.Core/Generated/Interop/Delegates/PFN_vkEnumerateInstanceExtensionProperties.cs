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

namespace AdamantiumVulkan.Core.Interop;

// File: C:\VulkanSDK\1.3.275.0\Include\vulkan/vulkan_core.h Line: 3926 Column: 30
public unsafe struct PFN_vkEnumerateInstanceExtensionProperties
{
    public PFN_vkEnumerateInstanceExtensionProperties(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<sbyte*, ref uint*, AdamantiumVulkan.Core.Interop.VkExtensionProperties*, Result>)ptr;
    }

    private delegate* unmanaged<sbyte*, ref uint*, AdamantiumVulkan.Core.Interop.VkExtensionProperties*, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(sbyte* pLayerName, ref uint* pPropertyCount, AdamantiumVulkan.Core.Interop.VkExtensionProperties* pProperties)
    {
        return InvokeFunc(pLayerName, ref pPropertyCount, pProperties);
    }
    public static Result Invoke(void* ptr, sbyte* pLayerName, ref uint* pPropertyCount, AdamantiumVulkan.Core.Interop.VkExtensionProperties* pProperties)
    {
        return ((delegate* unmanaged<sbyte*, ref uint*, AdamantiumVulkan.Core.Interop.VkExtensionProperties*, Result>)ptr)(pLayerName, ref pPropertyCount, pProperties);
    }

    public static explicit operator PFN_vkEnumerateInstanceExtensionProperties(void* ptr) => new(ptr);
}


