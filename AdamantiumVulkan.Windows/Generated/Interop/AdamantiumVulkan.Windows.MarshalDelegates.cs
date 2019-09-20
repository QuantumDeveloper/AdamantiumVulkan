// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

namespace AdamantiumVulkan.Windows.Interop
{
    using System.Security;
    using System;
    using System.Runtime.InteropServices;
    using AdamantiumVulkan.Core;
    using AdamantiumVulkan.Core.Interop;

    // File: C:\VulkanSDK\1.1.101.0\Include\vulkan/vulkan_win32.h Line: 45 Column: 30
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate Result PFN_vkCreateWin32SurfaceKHR([In] AdamantiumVulkan.Core.Interop.VkInstance_T instance,  AdamantiumVulkan.Windows.Interop.VkWin32SurfaceCreateInfoKHR pCreateInfo,  System.IntPtr pAllocator, [Out] out AdamantiumVulkan.Core.Interop.VkSurfaceKHR_T pSurface);
    // File: C:\VulkanSDK\1.1.101.0\Include\vulkan/vulkan_win32.h Line: 46 Column: 30
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate uint PFN_vkGetPhysicalDeviceWin32PresentationSupportKHR([In] AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, [In] uint queueFamilyIndex);
    // File: C:\VulkanSDK\1.1.101.0\Include\vulkan/vulkan_win32.h Line: 94 Column: 30
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate Result PFN_vkGetMemoryWin32HandleKHR([In] AdamantiumVulkan.Core.Interop.VkDevice_T device,  AdamantiumVulkan.Windows.Interop.VkMemoryGetWin32HandleInfoKHR pGetWin32HandleInfo, [In, Out] System.IntPtr pHandle);
    // File: C:\VulkanSDK\1.1.101.0\Include\vulkan/vulkan_win32.h Line: 95 Column: 30
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate Result PFN_vkGetMemoryWin32HandlePropertiesKHR([In] AdamantiumVulkan.Core.Interop.VkDevice_T device, [In] ExternalMemoryHandleTypeFlagBits handleType, [In] System.IntPtr handle, [In] AdamantiumVulkan.Windows.Interop.VkMemoryWin32HandlePropertiesKHR pMemoryWin32HandleProperties);
    // File: C:\VulkanSDK\1.1.101.0\Include\vulkan/vulkan_win32.h Line: 167 Column: 30
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate Result PFN_vkImportSemaphoreWin32HandleKHR([In] AdamantiumVulkan.Core.Interop.VkDevice_T device,  AdamantiumVulkan.Windows.Interop.VkImportSemaphoreWin32HandleInfoKHR pImportSemaphoreWin32HandleInfo);
    // File: C:\VulkanSDK\1.1.101.0\Include\vulkan/vulkan_win32.h Line: 168 Column: 30
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate Result PFN_vkGetSemaphoreWin32HandleKHR([In] AdamantiumVulkan.Core.Interop.VkDevice_T device,  AdamantiumVulkan.Windows.Interop.VkSemaphoreGetWin32HandleInfoKHR pGetWin32HandleInfo, [In, Out] System.IntPtr pHandle);
    // File: C:\VulkanSDK\1.1.101.0\Include\vulkan/vulkan_win32.h Line: 211 Column: 30
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate Result PFN_vkImportFenceWin32HandleKHR([In] AdamantiumVulkan.Core.Interop.VkDevice_T device,  AdamantiumVulkan.Windows.Interop.VkImportFenceWin32HandleInfoKHR pImportFenceWin32HandleInfo);
    // File: C:\VulkanSDK\1.1.101.0\Include\vulkan/vulkan_win32.h Line: 212 Column: 30
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate Result PFN_vkGetFenceWin32HandleKHR([In] AdamantiumVulkan.Core.Interop.VkDevice_T device,  AdamantiumVulkan.Windows.Interop.VkFenceGetWin32HandleInfoKHR pGetWin32HandleInfo, [In, Out] System.IntPtr pHandle);
    // File: C:\VulkanSDK\1.1.101.0\Include\vulkan/vulkan_win32.h Line: 244 Column: 30
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate Result PFN_vkGetMemoryWin32HandleNV([In] AdamantiumVulkan.Core.Interop.VkDevice_T device, [In] AdamantiumVulkan.Core.Interop.VkDeviceMemory_T memory, [In] uint handleType, [In, Out] System.IntPtr pHandle);

}

