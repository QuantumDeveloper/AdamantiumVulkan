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

// File: C:\VulkanSDK\1.3.283.0\Include\vk_video/vulkan_video_codec_av1std.h Line: 279 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct StdVideoAV1TileInfo
{
    public StdVideoAV1TileInfoFlags flags;
    public byte TileCols;
    public byte TileRows;
    public ushort context_update_tile_id;
    public byte tile_size_bytes_minus_1;
    public unsafe fixed byte reserved1[7];
    public ushort* pMiColStarts;
    public ushort* pMiRowStarts;
    public ushort* pWidthInSbsMinus1;
    public ushort* pHeightInSbsMinus1;
}



