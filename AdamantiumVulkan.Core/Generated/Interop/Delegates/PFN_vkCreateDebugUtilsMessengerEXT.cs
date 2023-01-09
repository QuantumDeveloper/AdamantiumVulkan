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

public unsafe struct PFN_vkCreateDebugUtilsMessengerEXT
{
    public PFN_vkCreateDebugUtilsMessengerEXT(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkInstance_T, VkDebugUtilsMessengerCreateInfoEXT*, VkAllocationCallbacks*, out VkDebugUtilsMessengerEXT_T, Result>)ptr;
    }

    private delegate* unmanaged<VkInstance_T, VkDebugUtilsMessengerCreateInfoEXT*, VkAllocationCallbacks*, out VkDebugUtilsMessengerEXT_T, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(VkInstance_T instance, VkDebugUtilsMessengerCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkDebugUtilsMessengerEXT_T pMessenger)
    {
        return InvokeFunc(instance, pCreateInfo, pAllocator, out pMessenger);
    }
    public static Result Invoke(void* ptr, VkInstance_T instance, VkDebugUtilsMessengerCreateInfoEXT* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkDebugUtilsMessengerEXT_T pMessenger)
    {
        return ((delegate* unmanaged<VkInstance_T, VkDebugUtilsMessengerCreateInfoEXT*, VkAllocationCallbacks*, out VkDebugUtilsMessengerEXT_T, Result>)ptr)(instance, pCreateInfo, pAllocator, out pMessenger);
    }

    public static explicit operator PFN_vkCreateDebugUtilsMessengerEXT(void* ptr) => new(ptr);
}

