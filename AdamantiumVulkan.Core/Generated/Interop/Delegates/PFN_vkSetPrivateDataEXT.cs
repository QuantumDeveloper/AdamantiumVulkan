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

// File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_core.h Line: 16853 Column: 30
public unsafe struct PFN_vkSetPrivateDataEXT
{
    public PFN_vkSetPrivateDataEXT(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, ObjectType, ulong, AdamantiumVulkan.Core.Interop.VkPrivateDataSlot_T, ulong, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, ObjectType, ulong, AdamantiumVulkan.Core.Interop.VkPrivateDataSlot_T, ulong, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, ObjectType objectType, ulong objectHandle, AdamantiumVulkan.Core.Interop.VkPrivateDataSlot_T privateDataSlot, ulong data)
    {
        return InvokeFunc(device, objectType, objectHandle, privateDataSlot, data);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, ObjectType objectType, ulong objectHandle, AdamantiumVulkan.Core.Interop.VkPrivateDataSlot_T privateDataSlot, ulong data)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, ObjectType, ulong, AdamantiumVulkan.Core.Interop.VkPrivateDataSlot_T, ulong, Result>)ptr)(device, objectType, objectHandle, privateDataSlot, data);
    }

    public static explicit operator PFN_vkSetPrivateDataEXT(void* ptr) => new(ptr);
}


