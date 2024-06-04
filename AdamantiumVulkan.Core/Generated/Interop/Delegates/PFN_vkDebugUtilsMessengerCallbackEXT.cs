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

// File: C:\VulkanSDK\1.3.275.0\Include\vulkan/vulkan_core.h Line: 12705 Column: 30
public unsafe struct PFN_vkDebugUtilsMessengerCallbackEXT
{
    public PFN_vkDebugUtilsMessengerCallbackEXT(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<DebugUtilsMessageSeverityFlagBitsEXT, DebugUtilsMessageTypeFlagBitsEXT, AdamantiumVulkan.Core.Interop.VkDebugUtilsMessengerCallbackDataEXT*, void*, uint>)ptr;
    }

    private delegate* unmanaged<DebugUtilsMessageSeverityFlagBitsEXT, DebugUtilsMessageTypeFlagBitsEXT, AdamantiumVulkan.Core.Interop.VkDebugUtilsMessengerCallbackDataEXT*, void*, uint> InvokeFunc;

    public void* NativePointer { get; }

    public uint Invoke(DebugUtilsMessageSeverityFlagBitsEXT messageSeverity, DebugUtilsMessageTypeFlagBitsEXT messageTypes, AdamantiumVulkan.Core.Interop.VkDebugUtilsMessengerCallbackDataEXT* pCallbackData, void* pUserData)
    {
        return InvokeFunc(messageSeverity, messageTypes, pCallbackData, pUserData);
    }
    public static uint Invoke(void* ptr, DebugUtilsMessageSeverityFlagBitsEXT messageSeverity, DebugUtilsMessageTypeFlagBitsEXT messageTypes, AdamantiumVulkan.Core.Interop.VkDebugUtilsMessengerCallbackDataEXT* pCallbackData, void* pUserData)
    {
        return ((delegate* unmanaged<DebugUtilsMessageSeverityFlagBitsEXT, DebugUtilsMessageTypeFlagBitsEXT, AdamantiumVulkan.Core.Interop.VkDebugUtilsMessengerCallbackDataEXT*, void*, uint>)ptr)(messageSeverity, messageTypes, pCallbackData, pUserData);
    }

    public static explicit operator PFN_vkDebugUtilsMessengerCallbackEXT(void* ptr) => new(ptr);
}


