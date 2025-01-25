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

namespace AdamantiumVulkan.Core.Interop;

// File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_core.h Line: 19988 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkLatencyTimingsFrameReportNV
{
    public StructureType sType;
    public void* pNext;
    public ulong presentID;
    public ulong inputSampleTimeUs;
    public ulong simStartTimeUs;
    public ulong simEndTimeUs;
    public ulong renderSubmitStartTimeUs;
    public ulong renderSubmitEndTimeUs;
    public ulong presentStartTimeUs;
    public ulong presentEndTimeUs;
    public ulong driverStartTimeUs;
    public ulong driverEndTimeUs;
    public ulong osRenderQueueStartTimeUs;
    public ulong osRenderQueueEndTimeUs;
    public ulong gpuRenderStartTimeUs;
    public ulong gpuRenderEndTimeUs;
}



