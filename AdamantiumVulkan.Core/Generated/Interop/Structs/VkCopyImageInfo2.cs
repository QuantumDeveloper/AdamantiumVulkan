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

// File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_core.h Line: 7047 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkCopyImageInfo2
{
    public StructureType sType;
    public void* pNext;
    public VkImage_T srcImage;
    public ImageLayout srcImageLayout;
    public VkImage_T dstImage;
    public ImageLayout dstImageLayout;
    public uint regionCount;
    public AdamantiumVulkan.Core.Interop.VkImageCopy2* pRegions;
}



