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

// File: C:\VulkanSDK\1.4.309.0\Include\vk_video/vulkan_video_codec_av1std.h Line: 294 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct StdVideoAV1CDEF
{
    public byte cdef_damping_minus_3;
    public byte cdef_bits;
    public unsafe fixed byte cdef_y_pri_strength[8];
    public unsafe fixed byte cdef_y_sec_strength[8];
    public unsafe fixed byte cdef_uv_pri_strength[8];
    public unsafe fixed byte cdef_uv_sec_strength[8];
}



