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

// File: C:\VulkanSDK\1.3.283.0\Include\vk_video/vulkan_video_codec_av1std.h Line: 301 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct StdVideoAV1LoopRestoration
{
    public StdVideoAV1FrameRestorationType0__FixedBuffer FrameRestorationType;
    public unsafe fixed ushort LoopRestorationSize[3];

    [StructLayout(LayoutKind.Sequential)]
    public partial struct StdVideoAV1FrameRestorationType0__FixedBuffer
    {
        public StdVideoAV1FrameRestorationType item0;
        public StdVideoAV1FrameRestorationType item1;
        public StdVideoAV1FrameRestorationType item2;

        public StdVideoAV1FrameRestorationType this[int index]
        {
            get => Unsafe.Add(ref item0, index);
            set => Unsafe.Add(ref item0, index) = value;
        }
    }
}



