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
using AdamantiumVulkan.Interop;

namespace AdamantiumVulkan.Core.Interop;

// File: C:\VulkanSDK\1.3.275.0\Include\vulkan/vulkan_core.h Line: 8386 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkVideoEncodeH264SessionParametersAddInfoKHR
{
    public StructureType sType;
    public void* pNext;
    public uint stdSPSCount;
    public AdamantiumVulkan.Interop.StdVideoH264SequenceParameterSet* pStdSPSs;
    public uint stdPPSCount;
    public AdamantiumVulkan.Interop.StdVideoH264PictureParameterSet* pStdPPSs;
}



