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
using AdamantiumVulkan.Interop;

namespace AdamantiumVulkan.Core.Interop;

// File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_core.h Line: 9999 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkVideoDecodeH265PictureInfoKHR
{
    public StructureType sType;
    public void* pNext;
    public AdamantiumVulkan.Interop.StdVideoDecodeH265PictureInfo* pStdPictureInfo;
    public uint sliceSegmentCount;
    public uint* pSliceSegmentOffsets;
}


