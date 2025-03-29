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

namespace AdamantiumVulkan.Core.Interop;

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 3428 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkDeviceCreateInfo
{
    public StructureType sType;
    public void* pNext;
    public VkDeviceCreateFlags flags;
    public uint queueCreateInfoCount;
    public AdamantiumVulkan.Core.Interop.VkDeviceQueueCreateInfo* pQueueCreateInfos;
    ///<summary>
    /// enabledLayerCount is deprecated and should not be used
    ///</summary>
    public uint enabledLayerCount;
    ///<summary>
    /// ppEnabledLayerNames is deprecated and should not be used
    ///</summary>
    public sbyte** ppEnabledLayerNames;
    public uint enabledExtensionCount;
    public sbyte** ppEnabledExtensionNames;
    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceFeatures* pEnabledFeatures;
}



