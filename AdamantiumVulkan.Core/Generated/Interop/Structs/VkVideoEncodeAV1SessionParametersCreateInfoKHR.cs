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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 12433 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkVideoEncodeAV1SessionParametersCreateInfoKHR
{
    public StructureType sType;
    public void* pNext;
    public AdamantiumVulkan.Interop.StdVideoAV1SequenceHeader* pStdSequenceHeader;
    public AdamantiumVulkan.Interop.StdVideoEncodeAV1DecoderModelInfo* pStdDecoderModelInfo;
    public uint stdOperatingPointCount;
    public AdamantiumVulkan.Interop.StdVideoEncodeAV1OperatingPointInfo* pStdOperatingPoints;
}



