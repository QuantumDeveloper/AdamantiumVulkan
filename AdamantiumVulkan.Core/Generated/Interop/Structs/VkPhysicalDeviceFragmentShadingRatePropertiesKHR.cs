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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 11109 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkPhysicalDeviceFragmentShadingRatePropertiesKHR
{
    public StructureType sType;
    public void* pNext;
    public VkExtent2D minFragmentShadingRateAttachmentTexelSize;
    public VkExtent2D maxFragmentShadingRateAttachmentTexelSize;
    public uint maxFragmentShadingRateAttachmentTexelSizeAspectRatio;
    public VkBool32 primitiveFragmentShadingRateWithMultipleViewports;
    public VkBool32 layeredShadingRateAttachments;
    public VkBool32 fragmentShadingRateNonTrivialCombinerOps;
    public VkExtent2D maxFragmentSize;
    public uint maxFragmentSizeAspectRatio;
    public uint maxFragmentShadingRateCoverageSamples;
    public SampleCountFlagBits maxFragmentShadingRateRasterizationSamples;
    public VkBool32 fragmentShadingRateWithShaderDepthStencilWrites;
    public VkBool32 fragmentShadingRateWithSampleMask;
    public VkBool32 fragmentShadingRateWithShaderSampleMask;
    public VkBool32 fragmentShadingRateWithConservativeRasterization;
    public VkBool32 fragmentShadingRateWithFragmentShaderInterlock;
    public VkBool32 fragmentShadingRateWithCustomSampleLocations;
    public VkBool32 fragmentShadingRateStrictMultiplyCombiner;
}



