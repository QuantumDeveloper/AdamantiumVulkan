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

// File: C:\VulkanSDK\1.4.309.0\Include\vk_video/vulkan_video_codec_h265std.h Line: 131 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct StdVideoH265SubLayerHrdParameters
{
    public unsafe fixed uint bit_rate_value_minus1[32];
    public unsafe fixed uint cpb_size_value_minus1[32];
    public unsafe fixed uint cpb_size_du_value_minus1[32];
    public unsafe fixed uint bit_rate_du_value_minus1[32];
    public uint cbr_flag;
}



