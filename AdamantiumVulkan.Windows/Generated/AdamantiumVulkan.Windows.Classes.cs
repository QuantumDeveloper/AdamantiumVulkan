// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

namespace AdamantiumVulkan.Windows
{
    using System;
    using System.Runtime.InteropServices;
    using AdamantiumVulkan.Common;
    using AdamantiumVulkan.Core;
    using AdamantiumVulkan.Windows.Interop;
    using AdamantiumVulkan.Core.Interop;

    public static partial class InstanceExtension
    {
        public static Result CreateWin32SurfaceKHR(this AdamantiumVulkan.Core.Instance instance, in Win32SurfaceCreateInfoKHR pCreateInfo, in AllocationCallbacks pAllocator, out AdamantiumVulkan.Core.SurfaceKHR pSurface)
        {
            var arg0 = instance;
            var arg1 = ReferenceEquals(pCreateInfo, null) ? System.IntPtr.Zero : MarshalUtils.MarshalStructToPtr(pCreateInfo.ToInternal());
            var arg2 = ReferenceEquals(pAllocator, null) ? System.IntPtr.Zero : MarshalUtils.MarshalStructToPtr(pAllocator.ToInternal());
            VkSurfaceKHR_T arg3;
            var result = AdamantiumVulkan.Windows.Interop.VulkanInterop.vkCreateWin32SurfaceKHR(arg0, arg1, arg2, out arg3);
            pCreateInfo?.Dispose();
            Marshal.FreeHGlobal(arg1);
            pAllocator?.Dispose();
            Marshal.FreeHGlobal(arg2);
            pSurface = new SurfaceKHR(arg3);
            return result;
        }

    }

    public static partial class PhysicalDeviceExtension
    {
        public static bool GetPhysicalDeviceWin32PresentationSupportKHR(this AdamantiumVulkan.Core.PhysicalDevice physicalDevice, uint queueFamilyIndex)
        {
            var arg0 = physicalDevice;
            return AdamantiumVulkan.Windows.Interop.VulkanInterop.vkGetPhysicalDeviceWin32PresentationSupportKHR(arg0, queueFamilyIndex);
        }

        public static Result GetPhysicalDeviceSurfacePresentModes2EXT(this AdamantiumVulkan.Core.PhysicalDevice physicalDevice, in PhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, ref uint pPresentModeCount, ref PresentModeKHR pPresentModes)
        {
            var arg0 = physicalDevice;
            var arg1 = ReferenceEquals(pSurfaceInfo, null) ? System.IntPtr.Zero : MarshalUtils.MarshalStructToPtr(pSurfaceInfo.ToInternal());
            var arg2 = (uint)pPresentModes;
            var result = AdamantiumVulkan.Windows.Interop.VulkanInterop.vkGetPhysicalDeviceSurfacePresentModes2EXT(arg0, arg1, ref pPresentModeCount, ref arg2);
            pSurfaceInfo?.Dispose();
            Marshal.FreeHGlobal(arg1);
            pPresentModes = (PresentModeKHR)arg2;
            return result;
        }

    }

    public static partial class DeviceExtension
    {
        public static Result GetMemoryWin32HandleKHR(this AdamantiumVulkan.Core.Device device, in MemoryGetWin32HandleInfoKHR pGetWin32HandleInfo, ref System.IntPtr pHandle)
        {
            var arg0 = device;
            var arg1 = ReferenceEquals(pGetWin32HandleInfo, null) ? System.IntPtr.Zero : MarshalUtils.MarshalStructToPtr(pGetWin32HandleInfo.ToInternal());
            var result = AdamantiumVulkan.Windows.Interop.VulkanInterop.vkGetMemoryWin32HandleKHR(arg0, arg1, pHandle);
            pGetWin32HandleInfo?.Dispose();
            Marshal.FreeHGlobal(arg1);
            return result;
        }

        public static Result GetMemoryWin32HandlePropertiesKHR(this AdamantiumVulkan.Core.Device device, ExternalMemoryHandleTypeFlagBits handleType, System.IntPtr handle, MemoryWin32HandlePropertiesKHR pMemoryWin32HandleProperties)
        {
            var arg0 = device;
            var arg1 = ReferenceEquals(pMemoryWin32HandleProperties, null) ? System.IntPtr.Zero : MarshalUtils.MarshalStructToPtr(pMemoryWin32HandleProperties.ToInternal());
            var result = AdamantiumVulkan.Windows.Interop.VulkanInterop.vkGetMemoryWin32HandlePropertiesKHR(arg0, handleType, handle, arg1);
            pMemoryWin32HandleProperties?.Dispose();
            Marshal.FreeHGlobal(arg1);
            return result;
        }

        public static Result ImportSemaphoreWin32HandleKHR(this AdamantiumVulkan.Core.Device device, in ImportSemaphoreWin32HandleInfoKHR pImportSemaphoreWin32HandleInfo)
        {
            var arg0 = device;
            var arg1 = ReferenceEquals(pImportSemaphoreWin32HandleInfo, null) ? System.IntPtr.Zero : MarshalUtils.MarshalStructToPtr(pImportSemaphoreWin32HandleInfo.ToInternal());
            var result = AdamantiumVulkan.Windows.Interop.VulkanInterop.vkImportSemaphoreWin32HandleKHR(arg0, arg1);
            pImportSemaphoreWin32HandleInfo?.Dispose();
            Marshal.FreeHGlobal(arg1);
            return result;
        }

        public static Result GetSemaphoreWin32HandleKHR(this AdamantiumVulkan.Core.Device device, in SemaphoreGetWin32HandleInfoKHR pGetWin32HandleInfo, ref System.IntPtr pHandle)
        {
            var arg0 = device;
            var arg1 = ReferenceEquals(pGetWin32HandleInfo, null) ? System.IntPtr.Zero : MarshalUtils.MarshalStructToPtr(pGetWin32HandleInfo.ToInternal());
            var result = AdamantiumVulkan.Windows.Interop.VulkanInterop.vkGetSemaphoreWin32HandleKHR(arg0, arg1, pHandle);
            pGetWin32HandleInfo?.Dispose();
            Marshal.FreeHGlobal(arg1);
            return result;
        }

        public static Result ImportFenceWin32HandleKHR(this AdamantiumVulkan.Core.Device device, in ImportFenceWin32HandleInfoKHR pImportFenceWin32HandleInfo)
        {
            var arg0 = device;
            var arg1 = ReferenceEquals(pImportFenceWin32HandleInfo, null) ? System.IntPtr.Zero : MarshalUtils.MarshalStructToPtr(pImportFenceWin32HandleInfo.ToInternal());
            var result = AdamantiumVulkan.Windows.Interop.VulkanInterop.vkImportFenceWin32HandleKHR(arg0, arg1);
            pImportFenceWin32HandleInfo?.Dispose();
            Marshal.FreeHGlobal(arg1);
            return result;
        }

        public static Result GetFenceWin32HandleKHR(this AdamantiumVulkan.Core.Device device, in FenceGetWin32HandleInfoKHR pGetWin32HandleInfo, ref System.IntPtr pHandle)
        {
            var arg0 = device;
            var arg1 = ReferenceEquals(pGetWin32HandleInfo, null) ? System.IntPtr.Zero : MarshalUtils.MarshalStructToPtr(pGetWin32HandleInfo.ToInternal());
            var result = AdamantiumVulkan.Windows.Interop.VulkanInterop.vkGetFenceWin32HandleKHR(arg0, arg1, pHandle);
            pGetWin32HandleInfo?.Dispose();
            Marshal.FreeHGlobal(arg1);
            return result;
        }

        public static Result GetMemoryWin32HandleNV(this AdamantiumVulkan.Core.Device device, AdamantiumVulkan.Core.DeviceMemory memory, uint handleType, ref System.IntPtr pHandle)
        {
            var arg0 = device;
            var arg1 = ReferenceEquals(memory, null) ? new VkDeviceMemory_T() : (VkDeviceMemory_T)memory;
            return AdamantiumVulkan.Windows.Interop.VulkanInterop.vkGetMemoryWin32HandleNV(arg0, arg1, handleType, pHandle);
        }

        public static Result AcquireFullScreenExclusiveModeEXT(this AdamantiumVulkan.Core.Device device, AdamantiumVulkan.Core.SwapchainKHR swapchain)
        {
            var arg0 = device;
            var arg1 = ReferenceEquals(swapchain, null) ? new VkSwapchainKHR_T() : (VkSwapchainKHR_T)swapchain;
            return AdamantiumVulkan.Windows.Interop.VulkanInterop.vkAcquireFullScreenExclusiveModeEXT(arg0, arg1);
        }

        public static Result ReleaseFullScreenExclusiveModeEXT(this AdamantiumVulkan.Core.Device device, AdamantiumVulkan.Core.SwapchainKHR swapchain)
        {
            var arg0 = device;
            var arg1 = ReferenceEquals(swapchain, null) ? new VkSwapchainKHR_T() : (VkSwapchainKHR_T)swapchain;
            return AdamantiumVulkan.Windows.Interop.VulkanInterop.vkReleaseFullScreenExclusiveModeEXT(arg0, arg1);
        }

        public static Result GetDeviceGroupSurfacePresentModes2EXT(this AdamantiumVulkan.Core.Device device, in PhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, ref uint pModes)
        {
            var arg0 = device;
            var arg1 = ReferenceEquals(pSurfaceInfo, null) ? System.IntPtr.Zero : MarshalUtils.MarshalStructToPtr(pSurfaceInfo.ToInternal());
            var result = AdamantiumVulkan.Windows.Interop.VulkanInterop.vkGetDeviceGroupSurfacePresentModes2EXT(arg0, arg1, ref pModes);
            pSurfaceInfo?.Dispose();
            Marshal.FreeHGlobal(arg1);
            return result;
        }

    }


}

