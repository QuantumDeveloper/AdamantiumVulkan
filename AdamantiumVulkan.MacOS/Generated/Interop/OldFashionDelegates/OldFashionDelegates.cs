// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AdamantiumVulkan.Core;
using AdamantiumVulkan.Core.Interop;

namespace AdamantiumVulkan.MacOS.Interop;

public static unsafe class Delegates
{
    // File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_macos.h Line: 34 Column: 30
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public unsafe delegate Result PFN_vkCreateMacOSSurfaceMVK(AdamantiumVulkan.Core.Interop.VkInstance_T instance, AdamantiumVulkan.MacOS.Interop.VkMacOSSurfaceCreateInfoMVK* pCreateInfo, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks* pAllocator, out AdamantiumVulkan.Core.Interop.VkSurfaceKHR_T pSurface);
}


