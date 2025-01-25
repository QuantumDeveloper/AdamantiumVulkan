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

// File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_core.h Line: 19489 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkOpticalFlowSessionCreateInfoNV
{
    public StructureType sType;
    public void* pNext;
    public uint width;
    public uint height;
    public Format imageFormat;
    public Format flowVectorFormat;
    public Format costFormat;
    public VkOpticalFlowGridSizeFlagsNV outputGridSize;
    public VkOpticalFlowGridSizeFlagsNV hintGridSize;
    public OpticalFlowPerformanceLevelNV performanceLevel;
    public VkOpticalFlowSessionCreateFlagsNV flags;
}



