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

// File: C:\VulkanSDK\1.4.304.0\Include\vk_video/vulkan_video_codec_av1std_decode.h Line: 96 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct StdVideoDecodeAV1ReferenceInfo
{
    public StdVideoDecodeAV1ReferenceInfoFlags flags;
    public byte frame_type;
    public byte RefFrameSignBias;
    public byte OrderHint;
    public unsafe fixed byte SavedOrderHints[8];
}



