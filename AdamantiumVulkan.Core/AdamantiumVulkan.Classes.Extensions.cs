using System;
using System.Collections.Generic;
using System.Text;

namespace AdamantiumVulkan.Core
{
    public partial class Instance 
    {
        public static uint LayersCount
        {
            get
            {
                uint layersCount = 0;
                var result = VulkanNative.EnumerateInstanceLayerProperties(ref layersCount, null);
                ResultHelper.CheckResult(result, nameof(VulkanNative.EnumerateInstanceLayerProperties));
                return layersCount;
            }
        }

        public static LayerProperties[] EnumerateInstanceLayerProperties()
        {
            var layersCount = LayersCount;
            LayerProperties[] layers = new LayerProperties[layersCount];
            var result = VulkanNative.EnumerateInstanceLayerProperties(ref layersCount, layers);
            ResultHelper.CheckResult(result, nameof(VulkanNative.EnumerateInstanceLayerProperties));
            return layers;
        }

        public static uint ExtensionsCount
        {
            get
            {
                uint propertyCount = 0;
                var result = VulkanNative.EnumerateInstanceExtensionProperties(null, ref propertyCount, null);
                ResultHelper.CheckResult(result, nameof(VulkanNative.EnumerateInstanceExtensionProperties));
                return propertyCount;
            }
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
            var extensionsCount = ExtensionsCount;
            ExtensionProperties[] properties = new ExtensionProperties[extensionsCount];
            var result = VulkanNative.EnumerateInstanceExtensionProperties(null, ref extensionsCount, properties);
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
}
