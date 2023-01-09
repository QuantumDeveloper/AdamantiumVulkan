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

public unsafe struct PFN_vkGetPhysicalDeviceSurfaceSupportKHR
{
    public PFN_vkGetPhysicalDeviceSurfaceSupportKHR(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkPhysicalDevice_T, uint, VkSurfaceKHR_T, ref VkBool32*, Result>)ptr;
    }

    private delegate* unmanaged<VkPhysicalDevice_T, uint, VkSurfaceKHR_T, ref VkBool32*, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(VkPhysicalDevice_T physicalDevice, uint queueFamilyIndex, VkSurfaceKHR_T surface, ref VkBool32* pSupported)
    {
        return InvokeFunc(physicalDevice, queueFamilyIndex, surface, ref pSupported);
    }
    public static Result Invoke(void* ptr, VkPhysicalDevice_T physicalDevice, uint queueFamilyIndex, VkSurfaceKHR_T surface, ref VkBool32* pSupported)
    {
        return ((delegate* unmanaged<VkPhysicalDevice_T, uint, VkSurfaceKHR_T, ref VkBool32*, Result>)ptr)(physicalDevice, queueFamilyIndex, surface, ref pSupported);
    }

    public static explicit operator PFN_vkGetPhysicalDeviceSurfaceSupportKHR(void* ptr) => new(ptr);
}


