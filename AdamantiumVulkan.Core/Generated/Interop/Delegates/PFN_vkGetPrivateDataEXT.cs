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

// File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_core.h Line: 15814 Column: 26
public unsafe struct PFN_vkGetPrivateDataEXT
{
    public PFN_vkGetPrivateDataEXT(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, ObjectType, ulong, AdamantiumVulkan.Core.Interop.VkPrivateDataSlot_T, ref ulong*, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, ObjectType, ulong, AdamantiumVulkan.Core.Interop.VkPrivateDataSlot_T, ref ulong*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, ObjectType objectType, ulong objectHandle, AdamantiumVulkan.Core.Interop.VkPrivateDataSlot_T privateDataSlot, ref ulong* pData)
    {
         InvokeFunc(device, objectType, objectHandle, privateDataSlot, ref pData);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, ObjectType objectType, ulong objectHandle, AdamantiumVulkan.Core.Interop.VkPrivateDataSlot_T privateDataSlot, ref ulong* pData)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, ObjectType, ulong, AdamantiumVulkan.Core.Interop.VkPrivateDataSlot_T, ref ulong*, void>)ptr)(device, objectType, objectHandle, privateDataSlot, ref pData);
    }

    public static explicit operator PFN_vkGetPrivateDataEXT(void* ptr) => new(ptr);
}


