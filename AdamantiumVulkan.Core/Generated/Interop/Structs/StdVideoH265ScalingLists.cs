// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AdamantiumVulkan.Interop;

// File: C:\VulkanSDK\1.4.304.0\Include\vk_video/vulkan_video_codec_h265std.h Line: 203 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct StdVideoH265ScalingLists
{
    public unsafe fixed byte ScalingList4x4[96];
    public unsafe fixed byte ScalingList8x8[384];
    public unsafe fixed byte ScalingList16x16[384];
    public unsafe fixed byte ScalingList32x32[128];
    public unsafe fixed byte ScalingListDCCoef16x16[6];
    public unsafe fixed byte ScalingListDCCoef32x32[2];
}



