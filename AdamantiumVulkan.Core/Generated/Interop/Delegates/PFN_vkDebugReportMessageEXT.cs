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

// File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_core.h Line: 11788 Column: 26
public unsafe struct PFN_vkDebugReportMessageEXT
{
    public PFN_vkDebugReportMessageEXT(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkInstance_T, VkDebugReportFlagsEXT, DebugReportObjectTypeEXT, ulong, ulong, int, sbyte*, sbyte*, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkInstance_T, VkDebugReportFlagsEXT, DebugReportObjectTypeEXT, ulong, ulong, int, sbyte*, sbyte*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkInstance_T instance, VkDebugReportFlagsEXT flags, DebugReportObjectTypeEXT objectType, ulong @object, ulong location, int messageCode, sbyte* pLayerPrefix, sbyte* pMessage)
    {
         InvokeFunc(instance, flags, objectType, @object, location, messageCode, pLayerPrefix, pMessage);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkInstance_T instance, VkDebugReportFlagsEXT flags, DebugReportObjectTypeEXT objectType, ulong @object, ulong location, int messageCode, sbyte* pLayerPrefix, sbyte* pMessage)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkInstance_T, VkDebugReportFlagsEXT, DebugReportObjectTypeEXT, ulong, ulong, int, sbyte*, sbyte*, void>)ptr)(instance, flags, objectType, @object, location, messageCode, pLayerPrefix, pMessage);
    }

    public static explicit operator PFN_vkDebugReportMessageEXT(void* ptr) => new(ptr);
}


