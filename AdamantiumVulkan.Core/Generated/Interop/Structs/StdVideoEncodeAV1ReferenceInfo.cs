// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AdamantiumVulkan;

namespace AdamantiumVulkan.Interop;

// File: C:\VulkanSDK\1.4.309.0\Include\vk_video/vulkan_video_codec_av1std_encode.h Line: 129 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct StdVideoEncodeAV1ReferenceInfo
{
    public StdVideoEncodeAV1ReferenceInfoFlags flags;
    public uint RefFrameId;
    public StdVideoAV1FrameType frame_type;
    public byte OrderHint;
    public unsafe fixed byte reserved1[3];
    public AdamantiumVulkan.Interop.StdVideoEncodeAV1ExtensionHeader* pExtensionHeader;
}



