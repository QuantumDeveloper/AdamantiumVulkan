// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AdamantiumVulkan.Core.Interop;

// File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_core.h Line: 11833 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkTraceRaysIndirectCommand2KHR
{
    public VkDeviceAddress raygenShaderRecordAddress;
    public VkDeviceSize raygenShaderRecordSize;
    public VkDeviceAddress missShaderBindingTableAddress;
    public VkDeviceSize missShaderBindingTableSize;
    public VkDeviceSize missShaderBindingTableStride;
    public VkDeviceAddress hitShaderBindingTableAddress;
    public VkDeviceSize hitShaderBindingTableSize;
    public VkDeviceSize hitShaderBindingTableStride;
    public VkDeviceAddress callableShaderBindingTableAddress;
    public VkDeviceSize callableShaderBindingTableSize;
    public VkDeviceSize callableShaderBindingTableStride;
    public uint width;
    public uint height;
    public uint depth;
}



