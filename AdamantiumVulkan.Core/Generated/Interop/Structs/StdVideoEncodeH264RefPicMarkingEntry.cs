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

// File: C:\VulkanSDK\1.4.309.0\Include\vk_video/vulkan_video_codec_h264std_encode.h Line: 83 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct StdVideoEncodeH264RefPicMarkingEntry
{
    public StdVideoH264MemMgmtControlOp memory_management_control_operation;
    public ushort difference_of_pic_nums_minus1;
    public ushort long_term_pic_num;
    public ushort long_term_frame_idx;
    public ushort max_long_term_frame_idx_plus1;
}



