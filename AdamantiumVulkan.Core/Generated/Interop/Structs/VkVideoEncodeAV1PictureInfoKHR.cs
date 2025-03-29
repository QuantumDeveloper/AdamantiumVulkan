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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 12442 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkVideoEncodeAV1PictureInfoKHR
{
    public StructureType sType;
    public void* pNext;
    public VideoEncodeAV1PredictionModeKHR predictionMode;
    public VideoEncodeAV1RateControlGroupKHR rateControlGroup;
    public uint constantQIndex;
    public AdamantiumVulkan.Interop.StdVideoEncodeAV1PictureInfo* pStdPictureInfo;
    public unsafe fixed int referenceNameSlotIndices[7];
    public VkBool32 primaryReferenceCdfOnly;
    public VkBool32 generateObuExtensionHeader;
}



