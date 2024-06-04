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

// File: C:\VulkanSDK\1.3.275.0\Include\vulkan/vulkan_core.h Line: 15650 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkCudaLaunchInfoNV
{
    public StructureType sType;
    public void* pNext;
    public VkCudaFunctionNV_T function;
    public uint gridDimX;
    public uint gridDimY;
    public uint gridDimZ;
    public uint blockDimX;
    public uint blockDimY;
    public uint blockDimZ;
    public uint sharedMemBytes;
    public ulong paramCount;
    public void** pParams;
    public ulong extraCount;
    public void** pExtras;
}



