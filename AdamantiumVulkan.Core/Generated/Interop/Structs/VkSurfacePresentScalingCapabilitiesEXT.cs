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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 16445 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkSurfacePresentScalingCapabilitiesEXT
{
    public StructureType sType;
    public void* pNext;
    public VkPresentScalingFlagsEXT supportedPresentScaling;
    public VkPresentGravityFlagsEXT supportedPresentGravityX;
    public VkPresentGravityFlagsEXT supportedPresentGravityY;
    public VkExtent2D minScaledImageExtent;
    public VkExtent2D maxScaledImageExtent;
}



