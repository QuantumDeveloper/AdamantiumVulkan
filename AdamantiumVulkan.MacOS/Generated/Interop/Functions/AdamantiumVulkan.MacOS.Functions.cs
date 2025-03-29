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
using AdamantiumVulkan.Core.Interop;

namespace AdamantiumVulkan.MacOS.Interop;

internal static unsafe partial class VulkanInterop
{
    public const string LibraryPath = "vulkan-1";

    // File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_macos.h Line: 37 Column: 32
    [DllImport(LibraryPath, EntryPoint = "vkCreateMacOSSurfaceMVK", ExactSpelling = true)]
    internal static extern Result vkCreateMacOSSurfaceMVK(AdamantiumVulkan.Core.Interop.VkInstance_T instance, AdamantiumVulkan.MacOS.Interop.VkMacOSSurfaceCreateInfoMVK* pCreateInfo, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks* pAllocator, out AdamantiumVulkan.Core.Interop.VkSurfaceKHR_T pSurface);

}



