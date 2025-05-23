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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 17763 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkDeviceFaultVendorBinaryHeaderVersionOneEXT
{
    public uint headerSize;
    public DeviceFaultVendorBinaryHeaderVersionEXT headerVersion;
    public uint vendorID;
    public uint deviceID;
    public uint driverVersion;
    public unsafe fixed byte pipelineCacheUUID[16];
    public uint applicationNameOffset;
    public uint applicationVersion;
    public uint engineNameOffset;
    public uint engineVersion;
    public uint apiVersion;
}



