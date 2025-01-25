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

// File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_core.h Line: 8591 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkSwapchainCreateInfoKHR
{
    public StructureType sType;
    public void* pNext;
    public VkSwapchainCreateFlagsKHR flags;
    public VkSurfaceKHR_T surface;
    public uint minImageCount;
    public Format imageFormat;
    public ColorSpaceKHR imageColorSpace;
    public VkExtent2D imageExtent;
    public uint imageArrayLayers;
    public ImageUsageFlagBits imageUsage;
    public SharingMode imageSharingMode;
    public uint queueFamilyIndexCount;
    public uint* pQueueFamilyIndices;
    public SurfaceTransformFlagBitsKHR preTransform;
    public CompositeAlphaFlagBitsKHR compositeAlpha;
    public PresentModeKHR presentMode;
    public VkBool32 clipped;
    public VkSwapchainKHR_T oldSwapchain;
}



