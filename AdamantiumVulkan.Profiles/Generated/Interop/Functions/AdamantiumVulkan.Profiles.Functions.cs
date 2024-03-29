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

namespace AdamantiumVulkan.Profiles.Interop;

internal static unsafe partial class VulkanInterop
{
    public const string LibraryPath = "vulkan-1";

    ///<summary>
    /// Create a VkDevice with the profile features and device extensions enabled
    ///</summary>
    [DllImport(LibraryPath, EntryPoint = "vpCreateDevice", ExactSpelling = true)]
    internal static extern Result vpCreateDevice(AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, AdamantiumVulkan.Profiles.Interop.VpDeviceCreateInfo* pCreateInfo, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks* pAllocator, out AdamantiumVulkan.Core.Interop.VkDevice_T pDevice);

    ///<summary>
    /// Create a VkInstance with the profile instance extensions enabled
    ///</summary>
    [DllImport(LibraryPath, EntryPoint = "vpCreateInstance", ExactSpelling = true)]
    internal static extern Result vpCreateInstance(AdamantiumVulkan.Profiles.Interop.VpInstanceCreateInfo* pCreateInfo, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks* pAllocator, out AdamantiumVulkan.Core.Interop.VkInstance_T pInstance);

    ///<summary>
    /// Check whether a profile is supported at the instance level
    ///</summary>
    [DllImport(LibraryPath, EntryPoint = "vpGetInstanceProfileSupport", ExactSpelling = true)]
    internal static extern Result vpGetInstanceProfileSupport(sbyte* pLayerName, AdamantiumVulkan.Profiles.Interop.VpProfileProperties* pProfile, VkBool32* pSupported);

    ///<summary>
    /// Check whether a profile is supported by the physical device
    ///</summary>
    [DllImport(LibraryPath, EntryPoint = "vpGetPhysicalDeviceProfileSupport", ExactSpelling = true)]
    internal static extern Result vpGetPhysicalDeviceProfileSupport(AdamantiumVulkan.Core.Interop.VkInstance_T instance, AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, AdamantiumVulkan.Profiles.Interop.VpProfileProperties* pProfile, VkBool32* pSupported);

    ///<summary>
    /// Query the list of device extensions of a profile
    ///</summary>
    [DllImport(LibraryPath, EntryPoint = "vpGetProfileDeviceExtensionProperties", ExactSpelling = true)]
    internal static extern Result vpGetProfileDeviceExtensionProperties(AdamantiumVulkan.Profiles.Interop.VpProfileProperties* pProfile, uint* pPropertyCount, AdamantiumVulkan.Core.Interop.VkExtensionProperties* pProperties);

    ///<summary>
    /// List the recommended fallback profiles of a profile
    ///</summary>
    [DllImport(LibraryPath, EntryPoint = "vpGetProfileFallbacks", ExactSpelling = true)]
    internal static extern Result vpGetProfileFallbacks(AdamantiumVulkan.Profiles.Interop.VpProfileProperties* pProfile, uint* pPropertyCount, AdamantiumVulkan.Profiles.Interop.VpProfileProperties* pProperties);

    ///<summary>
    /// Fill the feature structures with the requirements of a profile
    ///</summary>
    [DllImport(LibraryPath, EntryPoint = "vpGetProfileFeatures", ExactSpelling = true)]
    internal static extern void vpGetProfileFeatures(AdamantiumVulkan.Profiles.Interop.VpProfileProperties* pProfile, void* pNext);

    ///<summary>
    /// Query the list of feature structure types specified by the profile
    ///</summary>
    [DllImport(LibraryPath, EntryPoint = "vpGetProfileFeatureStructureTypes", ExactSpelling = true)]
    internal static extern Result vpGetProfileFeatureStructureTypes(AdamantiumVulkan.Profiles.Interop.VpProfileProperties* pProfile, uint* pStructureTypeCount, StructureType* pStructureTypes);

    ///<summary>
    /// Query the requirements of a format for a profile
    ///</summary>
    [DllImport(LibraryPath, EntryPoint = "vpGetProfileFormatProperties", ExactSpelling = true)]
    internal static extern void vpGetProfileFormatProperties(AdamantiumVulkan.Profiles.Interop.VpProfileProperties* pProfile, Format format, void* pNext);

    ///<summary>
    /// Query the list of formats with specified requirements by a profile
    ///</summary>
    [DllImport(LibraryPath, EntryPoint = "vpGetProfileFormats", ExactSpelling = true)]
    internal static extern Result vpGetProfileFormats(AdamantiumVulkan.Profiles.Interop.VpProfileProperties* pProfile, uint* pFormatCount, Format* pFormats);

    ///<summary>
    /// Query the list of format structure types specified by the profile
    ///</summary>
    [DllImport(LibraryPath, EntryPoint = "vpGetProfileFormatStructureTypes", ExactSpelling = true)]
    internal static extern Result vpGetProfileFormatStructureTypes(AdamantiumVulkan.Profiles.Interop.VpProfileProperties* pProfile, uint* pStructureTypeCount, StructureType* pStructureTypes);

    ///<summary>
    /// Query the list of instance extensions of a profile
    ///</summary>
    [DllImport(LibraryPath, EntryPoint = "vpGetProfileInstanceExtensionProperties", ExactSpelling = true)]
    internal static extern Result vpGetProfileInstanceExtensionProperties(AdamantiumVulkan.Profiles.Interop.VpProfileProperties* pProfile, uint* pPropertyCount, AdamantiumVulkan.Core.Interop.VkExtensionProperties* pProperties);

    ///<summary>
    /// Fill the property structures with the requirements of a profile
    ///</summary>
    [DllImport(LibraryPath, EntryPoint = "vpGetProfileProperties", ExactSpelling = true)]
    internal static extern void vpGetProfileProperties(AdamantiumVulkan.Profiles.Interop.VpProfileProperties* pProfile, void* pNext);

    ///<summary>
    /// Query the list of property structure types specified by the profile
    ///</summary>
    [DllImport(LibraryPath, EntryPoint = "vpGetProfilePropertyStructureTypes", ExactSpelling = true)]
    internal static extern Result vpGetProfilePropertyStructureTypes(AdamantiumVulkan.Profiles.Interop.VpProfileProperties* pProfile, uint* pStructureTypeCount, StructureType* pStructureTypes);

    ///<summary>
    /// Query the requirements of queue families by a profile
    ///</summary>
    [DllImport(LibraryPath, EntryPoint = "vpGetProfileQueueFamilyProperties", ExactSpelling = true)]
    internal static extern Result vpGetProfileQueueFamilyProperties(AdamantiumVulkan.Profiles.Interop.VpProfileProperties* pProfile, uint* pPropertyCount, AdamantiumVulkan.Core.Interop.VkQueueFamilyProperties2* pProperties);

    ///<summary>
    /// Query the list of query family structure types specified by the profile
    ///</summary>
    [DllImport(LibraryPath, EntryPoint = "vpGetProfileQueueFamilyStructureTypes", ExactSpelling = true)]
    internal static extern Result vpGetProfileQueueFamilyStructureTypes(AdamantiumVulkan.Profiles.Interop.VpProfileProperties* pProfile, uint* pStructureTypeCount, StructureType* pStructureTypes);

    ///<summary>
    /// Query the list of available profiles in the library
    ///</summary>
    [DllImport(LibraryPath, EntryPoint = "vpGetProfiles", ExactSpelling = true)]
    internal static extern Result vpGetProfiles(uint* pPropertyCount, AdamantiumVulkan.Profiles.Interop.VpProfileProperties* pProperties);

}



