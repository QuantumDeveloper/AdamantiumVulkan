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

// File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_core.h Line: 7874 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkDisplayPropertiesKHR
{
    public VkDisplayKHR_T display;
    public sbyte* displayName;
    public VkExtent2D physicalDimensions;
    public VkExtent2D physicalResolution;
    public VkSurfaceTransformFlagsKHR supportedTransforms;
    public VkBool32 planeReorderPossible;
    public VkBool32 persistentContent;
}



