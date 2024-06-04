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

// File: C:\VulkanSDK\1.3.275.0\Include\vulkan/vulkan_core.h Line: 15813 Column: 15
[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct VkDescriptorDataEXT
{
    [FieldOffset(0)]
    public VkSampler_T* pSampler;
    [FieldOffset(0)]
    public AdamantiumVulkan.Core.Interop.VkDescriptorImageInfo* pCombinedImageSampler;
    [FieldOffset(0)]
    public AdamantiumVulkan.Core.Interop.VkDescriptorImageInfo* pInputAttachmentImage;
    [FieldOffset(0)]
    public AdamantiumVulkan.Core.Interop.VkDescriptorImageInfo* pSampledImage;
    [FieldOffset(0)]
    public AdamantiumVulkan.Core.Interop.VkDescriptorImageInfo* pStorageImage;
    [FieldOffset(0)]
    public AdamantiumVulkan.Core.Interop.VkDescriptorAddressInfoEXT* pUniformTexelBuffer;
    [FieldOffset(0)]
    public AdamantiumVulkan.Core.Interop.VkDescriptorAddressInfoEXT* pStorageTexelBuffer;
    [FieldOffset(0)]
    public AdamantiumVulkan.Core.Interop.VkDescriptorAddressInfoEXT* pUniformBuffer;
    [FieldOffset(0)]
    public AdamantiumVulkan.Core.Interop.VkDescriptorAddressInfoEXT* pStorageBuffer;
    [FieldOffset(0)]
    public VkDeviceAddress accelerationStructure;
}



