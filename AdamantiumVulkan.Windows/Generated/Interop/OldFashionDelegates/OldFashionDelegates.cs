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

namespace AdamantiumVulkan.Windows.Interop;

public static unsafe class Delegates
{
    // File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_win32.h Line: 35 Column: 30
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public unsafe delegate Result PFN_vkCreateWin32SurfaceKHR(AdamantiumVulkan.Core.Interop.VkInstance_T instance, AdamantiumVulkan.Windows.Interop.VkWin32SurfaceCreateInfoKHR* pCreateInfo, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks* pAllocator, out AdamantiumVulkan.Core.Interop.VkSurfaceKHR_T pSurface);
    // File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_win32.h Line: 36 Column: 30
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public unsafe delegate uint PFN_vkGetPhysicalDeviceWin32PresentationSupportKHR(AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, uint queueFamilyIndex);
    // File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_win32.h Line: 84 Column: 30
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public unsafe delegate Result PFN_vkGetMemoryWin32HandleKHR(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Windows.Interop.VkMemoryGetWin32HandleInfoKHR* pGetWin32HandleInfo, IntPtr pHandle);
    // File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_win32.h Line: 85 Column: 30
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public unsafe delegate Result PFN_vkGetMemoryWin32HandlePropertiesKHR(AdamantiumVulkan.Core.Interop.VkDevice_T device, ExternalMemoryHandleTypeFlagBits handleType, System.IntPtr handle, AdamantiumVulkan.Windows.Interop.VkMemoryWin32HandlePropertiesKHR* pMemoryWin32HandleProperties);
    // File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_win32.h Line: 157 Column: 30
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public unsafe delegate Result PFN_vkImportSemaphoreWin32HandleKHR(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Windows.Interop.VkImportSemaphoreWin32HandleInfoKHR* pImportSemaphoreWin32HandleInfo);
    // File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_win32.h Line: 158 Column: 30
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public unsafe delegate Result PFN_vkGetSemaphoreWin32HandleKHR(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Windows.Interop.VkSemaphoreGetWin32HandleInfoKHR* pGetWin32HandleInfo, IntPtr pHandle);
    // File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_win32.h Line: 201 Column: 30
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public unsafe delegate Result PFN_vkImportFenceWin32HandleKHR(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Windows.Interop.VkImportFenceWin32HandleInfoKHR* pImportFenceWin32HandleInfo);
    // File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_win32.h Line: 202 Column: 30
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public unsafe delegate Result PFN_vkGetFenceWin32HandleKHR(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Windows.Interop.VkFenceGetWin32HandleInfoKHR* pGetWin32HandleInfo, IntPtr pHandle);
    // File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_win32.h Line: 234 Column: 30
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public unsafe delegate Result PFN_vkGetMemoryWin32HandleNV(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkDeviceMemory_T memory, VkExternalMemoryHandleTypeFlagsNV handleType, IntPtr pHandle);
    // File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_win32.h Line: 293 Column: 30
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public unsafe delegate Result PFN_vkGetPhysicalDeviceSurfacePresentModes2EXT(AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, AdamantiumVulkan.Core.Interop.VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, ref uint* pPresentModeCount, ref PresentModeKHR* pPresentModes);
    // File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_win32.h Line: 294 Column: 30
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public unsafe delegate Result PFN_vkAcquireFullScreenExclusiveModeEXT(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkSwapchainKHR_T swapchain);
    // File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_win32.h Line: 295 Column: 30
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public unsafe delegate Result PFN_vkReleaseFullScreenExclusiveModeEXT(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkSwapchainKHR_T swapchain);
    // File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_win32.h Line: 296 Column: 30
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public unsafe delegate Result PFN_vkGetDeviceGroupSurfacePresentModes2EXT(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, ref VkDeviceGroupPresentModeFlagsKHR* pModes);
    // File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_win32.h Line: 324 Column: 30
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public unsafe delegate Result PFN_vkAcquireWinrtDisplayNV(AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, AdamantiumVulkan.Core.Interop.VkDisplayKHR_T display);
    // File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_win32.h Line: 325 Column: 30
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public unsafe delegate Result PFN_vkGetWinrtDisplayNV(AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, uint deviceRelativeId, out AdamantiumVulkan.Core.Interop.VkDisplayKHR_T pDisplay);
}


