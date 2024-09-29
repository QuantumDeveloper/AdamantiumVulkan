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

namespace AdamantiumVulkan.Windows.Interop;

internal static unsafe partial class VulkanInterop
{
    public const string LibraryPath = "vulkan-1";

    // File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_win32.h Line: 305 Column: 32
    [DllImport(LibraryPath, EntryPoint = "vkAcquireFullScreenExclusiveModeEXT", ExactSpelling = true)]
    internal static extern Result vkAcquireFullScreenExclusiveModeEXT(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkSwapchainKHR_T swapchain);

    // File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_win32.h Line: 328 Column: 32
    [DllImport(LibraryPath, EntryPoint = "vkAcquireWinrtDisplayNV", ExactSpelling = true)]
    internal static extern Result vkAcquireWinrtDisplayNV(AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, AdamantiumVulkan.Core.Interop.VkDisplayKHR_T display);

    // File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_win32.h Line: 39 Column: 32
    [DllImport(LibraryPath, EntryPoint = "vkCreateWin32SurfaceKHR", ExactSpelling = true)]
    internal static extern Result vkCreateWin32SurfaceKHR(AdamantiumVulkan.Core.Interop.VkInstance_T instance, AdamantiumVulkan.Windows.Interop.VkWin32SurfaceCreateInfoKHR* pCreateInfo, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks* pAllocator, out AdamantiumVulkan.Core.Interop.VkSurfaceKHR_T pSurface);

    // File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_win32.h Line: 313 Column: 32
    [DllImport(LibraryPath, EntryPoint = "vkGetDeviceGroupSurfacePresentModes2EXT", ExactSpelling = true)]
    internal static extern Result vkGetDeviceGroupSurfacePresentModes2EXT(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, VkDeviceGroupPresentModeFlagsKHR* pModes);

    // File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_win32.h Line: 209 Column: 32
    [DllImport(LibraryPath, EntryPoint = "vkGetFenceWin32HandleKHR", ExactSpelling = true)]
    internal static extern Result vkGetFenceWin32HandleKHR(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Windows.Interop.VkFenceGetWin32HandleInfoKHR* pGetWin32HandleInfo, IntPtr pHandle);

    // File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_win32.h Line: 88 Column: 32
    [DllImport(LibraryPath, EntryPoint = "vkGetMemoryWin32HandleKHR", ExactSpelling = true)]
    internal static extern Result vkGetMemoryWin32HandleKHR(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Windows.Interop.VkMemoryGetWin32HandleInfoKHR* pGetWin32HandleInfo, out IntPtr pHandle);

    // File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_win32.h Line: 237 Column: 32
    [DllImport(LibraryPath, EntryPoint = "vkGetMemoryWin32HandleNV", ExactSpelling = true)]
    internal static extern Result vkGetMemoryWin32HandleNV(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkDeviceMemory_T memory, VkExternalMemoryHandleTypeFlagsNV handleType, IntPtr pHandle);

    // File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_win32.h Line: 93 Column: 32
    [DllImport(LibraryPath, EntryPoint = "vkGetMemoryWin32HandlePropertiesKHR", ExactSpelling = true)]
    internal static extern Result vkGetMemoryWin32HandlePropertiesKHR(AdamantiumVulkan.Core.Interop.VkDevice_T device, ExternalMemoryHandleTypeFlagBits handleType, System.IntPtr handle, AdamantiumVulkan.Windows.Interop.VkMemoryWin32HandlePropertiesKHR* pMemoryWin32HandleProperties);

    // File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_win32.h Line: 299 Column: 32
    [DllImport(LibraryPath, EntryPoint = "vkGetPhysicalDeviceSurfacePresentModes2EXT", ExactSpelling = true)]
    internal static extern Result vkGetPhysicalDeviceSurfacePresentModes2EXT(AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, AdamantiumVulkan.Core.Interop.VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, uint* pPresentModeCount, PresentModeKHR* pPresentModes);

    // File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_win32.h Line: 45 Column: 32
    [DllImport(LibraryPath, EntryPoint = "vkGetPhysicalDeviceWin32PresentationSupportKHR", ExactSpelling = true)]
    internal static extern VkBool32 vkGetPhysicalDeviceWin32PresentationSupportKHR(AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, uint queueFamilyIndex);

    // File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_win32.h Line: 165 Column: 32
    [DllImport(LibraryPath, EntryPoint = "vkGetSemaphoreWin32HandleKHR", ExactSpelling = true)]
    internal static extern Result vkGetSemaphoreWin32HandleKHR(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Windows.Interop.VkSemaphoreGetWin32HandleInfoKHR* pGetWin32HandleInfo, IntPtr pHandle);

    // File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_win32.h Line: 332 Column: 32
    [DllImport(LibraryPath, EntryPoint = "vkGetWinrtDisplayNV", ExactSpelling = true)]
    internal static extern Result vkGetWinrtDisplayNV(AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, uint deviceRelativeId, out AdamantiumVulkan.Core.Interop.VkDisplayKHR_T pDisplay);

    // File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_win32.h Line: 205 Column: 32
    [DllImport(LibraryPath, EntryPoint = "vkImportFenceWin32HandleKHR", ExactSpelling = true)]
    internal static extern Result vkImportFenceWin32HandleKHR(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Windows.Interop.VkImportFenceWin32HandleInfoKHR* pImportFenceWin32HandleInfo);

    // File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_win32.h Line: 161 Column: 32
    [DllImport(LibraryPath, EntryPoint = "vkImportSemaphoreWin32HandleKHR", ExactSpelling = true)]
    internal static extern Result vkImportSemaphoreWin32HandleKHR(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Windows.Interop.VkImportSemaphoreWin32HandleInfoKHR* pImportSemaphoreWin32HandleInfo);

    // File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_win32.h Line: 309 Column: 32
    [DllImport(LibraryPath, EntryPoint = "vkReleaseFullScreenExclusiveModeEXT", ExactSpelling = true)]
    internal static extern Result vkReleaseFullScreenExclusiveModeEXT(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkSwapchainKHR_T swapchain);

}



