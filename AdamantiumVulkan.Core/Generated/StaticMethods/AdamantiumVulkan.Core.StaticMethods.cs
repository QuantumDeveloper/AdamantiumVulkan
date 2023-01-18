// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using QuantumBinding.Utils;
using AdamantiumVulkan.Core.Interop;

namespace AdamantiumVulkan.Core;

public unsafe static class VulkanNative
{
    public static Result CreateInstance(in InstanceCreateInfo pCreateInfo, in AllocationCallbacks pAllocator, out AdamantiumVulkan.Core.Instance pInstance)
    {
        var arg0 = ReferenceEquals(pCreateInfo, null) ? null : NativeUtils.StructOrEnumToPointer(pCreateInfo.ToNative());
        var arg1 = ReferenceEquals(pAllocator, null) ? null : NativeUtils.StructOrEnumToPointer(pAllocator.ToNative());
        VkInstance_T arg2;
        var result = AdamantiumVulkan.Core.Interop.VulkanInterop.vkCreateInstance(arg0, arg1, out arg2);
        NativeUtils.Free(arg0);
        pAllocator?.Dispose();
        NativeUtils.Free(arg1);
        pInstance = new Instance(arg2);
        return result;
    }

    public static Result EnumerateInstanceExtensionProperties(string pLayerName, ref uint pPropertyCount, ExtensionProperties[] pProperties)
    {
        var arg0 = (sbyte*)NativeUtils.PointerToString(pLayerName, false);
        var arg1 = NativeUtils.StructOrEnumToPointer(pPropertyCount);
        var arg2 = ReferenceEquals(pProperties, null) ? null : NativeUtils.GetPointerToManagedArray<AdamantiumVulkan.Core.Interop.VkExtensionProperties>(pProperties.Length);
        var result = AdamantiumVulkan.Core.Interop.VulkanInterop.vkEnumerateInstanceExtensionProperties(arg0, arg1, arg2);
        NativeUtils.Free(arg0);
        pPropertyCount = *arg1;
        NativeUtils.Free(arg1);
        if (!ReferenceEquals(pProperties, null))
        {
            for (var i = 0U; i < pProperties.Length; ++i)
            {
                pProperties[i] = new ExtensionProperties(arg2[i]);
            }
        }
        NativeUtils.Free(arg2);
        return result;
    }

    public static Result EnumerateInstanceExtensionProperties(string pLayerName, ref uint pPropertyCount, ExtensionProperties pProperties)
    {
        var arg0 = (sbyte*)NativeUtils.PointerToString(pLayerName, false);
        var arg1 = NativeUtils.StructOrEnumToPointer(pPropertyCount);
        var arg2 = ReferenceEquals(pProperties, null) ? null : NativeUtils.StructOrEnumToPointer(pProperties.ToNative());
        var result = AdamantiumVulkan.Core.Interop.VulkanInterop.vkEnumerateInstanceExtensionProperties(arg0, arg1, arg2);
        NativeUtils.Free(arg0);
        pPropertyCount = *arg1;
        NativeUtils.Free(arg1);
        if (arg2 is not null)
        {
            pProperties = new AdamantiumVulkan.Core.ExtensionProperties(*arg2);
        }
        NativeUtils.Free(arg2);
        return result;
    }

    public static Result EnumerateInstanceLayerProperties(ref uint pPropertyCount, LayerProperties[] pProperties)
    {
        var arg0 = NativeUtils.StructOrEnumToPointer(pPropertyCount);
        var arg1 = ReferenceEquals(pProperties, null) ? null : NativeUtils.GetPointerToManagedArray<AdamantiumVulkan.Core.Interop.VkLayerProperties>(pProperties.Length);
        var result = AdamantiumVulkan.Core.Interop.VulkanInterop.vkEnumerateInstanceLayerProperties(arg0, arg1);
        pPropertyCount = *arg0;
        NativeUtils.Free(arg0);
        if (!ReferenceEquals(pProperties, null))
        {
            for (var i = 0U; i < pProperties.Length; ++i)
            {
                pProperties[i] = new LayerProperties(arg1[i]);
            }
        }
        NativeUtils.Free(arg1);
        return result;
    }

    public static Result EnumerateInstanceLayerProperties(ref uint pPropertyCount, LayerProperties pProperties)
    {
        var arg0 = NativeUtils.StructOrEnumToPointer(pPropertyCount);
        var arg1 = ReferenceEquals(pProperties, null) ? null : NativeUtils.StructOrEnumToPointer(pProperties.ToNative());
        var result = AdamantiumVulkan.Core.Interop.VulkanInterop.vkEnumerateInstanceLayerProperties(arg0, arg1);
        pPropertyCount = *arg0;
        NativeUtils.Free(arg0);
        if (arg1 is not null)
        {
            pProperties = new AdamantiumVulkan.Core.LayerProperties(*arg1);
        }
        NativeUtils.Free(arg1);
        return result;
    }

    public static Result EnumerateInstanceVersion(ref uint pApiVersion)
    {
        var arg0 = NativeUtils.StructOrEnumToPointer(pApiVersion);
        var result = AdamantiumVulkan.Core.Interop.VulkanInterop.vkEnumerateInstanceVersion(arg0);
        pApiVersion = *arg0;
        NativeUtils.Free(arg0);
        return result;
    }

}


