using System;
using System.Collections.Generic;
using System.Text;

namespace AdamantiumVulkan.Core
{
    public partial class Instance 
    {
        public static LayerProperties[] EnumerateInstanceLayerProperties()
        {
            uint layersCount = 0;
            var result = VulkanNative.EnumerateInstanceLayerProperties(ref layersCount, null);
            ResultHelper.CheckResult(result, nameof(VulkanNative.EnumerateInstanceLayerProperties));

            LayerProperties[] layers = new LayerProperties[layersCount];
            result = VulkanNative.EnumerateInstanceLayerProperties(ref layersCount, layers);
            ResultHelper.CheckResult(result, nameof(VulkanNative.EnumerateInstanceLayerProperties));
            return layers;
        }

        public static ExtensionProperties[] EnumerateInstanceExtensionProperties(string layerName)
        {
            uint propertyCount = 0;
            var result = VulkanNative.EnumerateInstanceExtensionProperties(layerName, ref propertyCount, null);
            ResultHelper.CheckResult(result, nameof(VulkanNative.EnumerateInstanceExtensionProperties));

            ExtensionProperties[] properties = new ExtensionProperties[propertyCount];
            result = VulkanNative.EnumerateInstanceExtensionProperties(layerName, ref propertyCount, properties);
            ResultHelper.CheckResult(result, nameof(EnumeratePhysicalDevices));
            return properties;
        }

        public static ExtensionProperties[] EnumerateInstanceExtensionProperties()
        {
            uint extensionsCount = 0;
            var result = VulkanNative.EnumerateInstanceExtensionProperties(null, ref extensionsCount, null);
            ResultHelper.CheckResult(result, nameof(VulkanNative.EnumerateInstanceExtensionProperties));

            ExtensionProperties[] properties = new ExtensionProperties[extensionsCount];
            result = VulkanNative.EnumerateInstanceExtensionProperties(null, ref extensionsCount, properties);
            ResultHelper.CheckResult(result, nameof(EnumeratePhysicalDevices));
            return properties;
        }

        public static Instance Create(in InstanceCreateInfo createInfo, in AllocationCallbacks allocator = null)
        {
            VulkanNative.CreateInstance(createInfo, allocator, out var instance);
            return instance;
        }

        public uint PhysicalDeviceCount
        {
            get
            {
                uint physicalDeviceCount = 0;
                var result = EnumeratePhysicalDevices(ref physicalDeviceCount, null);
                ResultHelper.CheckResult(result, nameof(EnumeratePhysicalDevices));
                return physicalDeviceCount;
            }
        }

        public PhysicalDevice[] EnumeratePhysicalDevices()
        {
            var physicalDeviceCount = PhysicalDeviceCount;
            PhysicalDevice[] pPhysicalDevices = new PhysicalDevice[physicalDeviceCount];
            var result = EnumeratePhysicalDevices(ref physicalDeviceCount, pPhysicalDevices);
            ResultHelper.CheckResult(result, nameof(EnumeratePhysicalDevices));

            return pPhysicalDevices;
        }
    }

    public partial class PhysicalDevice
    {
        public PhysicalDeviceMemoryProperties GetPhysicalDeviceMemoryProperties()
        {
            GetPhysicalDeviceMemoryProperties(out var memoryProperties);
            return memoryProperties;
        }

        public PhysicalDeviceProperties GetPhysicalDeviceProperties()
        {
            GetPhysicalDeviceProperties(out var deviceProperties);
            return deviceProperties;
        }

        public PhysicalDeviceFeatures GetPhysicalDeviceFeatures()
        {
            GetPhysicalDeviceFeatures(out var deviceFeatures);
            return deviceFeatures;
        }

        public Device CreateDevice(DeviceCreateInfo createInfo, AllocationCallbacks allocator = null)
        {
            var result = CreateDevice(createInfo, null, out var logicalDevice);
            ResultHelper.CheckResult(result, nameof(CreateDevice));
            return logicalDevice;
        }

        public SurfaceCapabilitiesKHR GetPhysicalDeviceSurfaceCapabilitiesKHR(SurfaceKHR surface)
        {
            var result = GetPhysicalDeviceSurfaceCapabilitiesKHR(surface, out var surfaceCapabilities);
            ResultHelper.CheckResult(result, nameof(GetPhysicalDeviceSurfaceCapabilitiesKHR));
            return surfaceCapabilities;
        }

        public SurfaceFormatKHR[] GetPhysicalDeviceSurfaceFormatsKHR(SurfaceKHR surface)
        {
            uint formatCount = 0;
            var result = GetPhysicalDeviceSurfaceFormatsKHR(surface, ref formatCount, null);
            ResultHelper.CheckResult(result, nameof(GetPhysicalDeviceSurfaceFormatsKHR));

            if (formatCount != 0)
            {
                var formats = new SurfaceFormatKHR[formatCount];
                result = GetPhysicalDeviceSurfaceFormatsKHR(surface, ref formatCount, formats);
                ResultHelper.CheckResult(result, nameof(GetPhysicalDeviceSurfaceFormatsKHR));
                return formats;
            }

            return new SurfaceFormatKHR[0];
        }

        public PresentModeKHR[] GetPhysicalDeviceSurfacePresentModesKHR(SurfaceKHR surface)
        {
            uint presentModeCount = 0;
            var result = GetPhysicalDeviceSurfacePresentModesKHR(surface, ref presentModeCount, null);
            ResultHelper.CheckResult(result, nameof(GetPhysicalDeviceSurfacePresentModesKHR));

            if (presentModeCount != 0)
            {
                var presentModes = new PresentModeKHR[presentModeCount];
                result = GetPhysicalDeviceSurfacePresentModesKHR(surface, ref presentModeCount, presentModes);
                ResultHelper.CheckResult(result, nameof(GetPhysicalDeviceSurfacePresentModesKHR));
                return presentModes;
            }

            return new PresentModeKHR[0];
        }
    }

    public partial class Device
    {
        public Queue GetDeviceQueue(uint queueFamilyIndex, uint queueIndex)
        {
            GetDeviceQueue(queueFamilyIndex, queueIndex, out Queue queue);
            return queue;
        }

        public Queue GetDeviceQueue2(DeviceQueueInfo2 queueInfo)
        {
            GetDeviceQueue2(queueInfo, out Queue pQueue);
            return pQueue;
        }

        public SwapchainKHR CreateSwapchainKHR(SwapchainCreateInfoKHR createInfo, AllocationCallbacks allocator = null)
        {
            var result = CreateSwapchainKHR(createInfo, allocator, out SwapchainKHR swapchain);
            ResultHelper.CheckResult(result, nameof(CreateSwapchainKHR));
            return swapchain;
        }

        public Image[] GetSwapchainImagesKHR(SwapchainKHR swapchain)
        {
            uint imageCount = 0;
            var result = GetSwapchainImagesKHR(swapchain, ref imageCount, null);
            ResultHelper.CheckResult(result, nameof(GetSwapchainImagesKHR));

            var swapchainImages = new Image[imageCount];
            result = GetSwapchainImagesKHR(swapchain, ref imageCount, swapchainImages);
            ResultHelper.CheckResult(result, nameof(GetSwapchainImagesKHR));

            return swapchainImages;
        }
    }
}
