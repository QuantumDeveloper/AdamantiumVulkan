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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 17160 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkPhysicalDeviceDescriptorBufferPropertiesEXT
{
    public StructureType sType;
    public void* pNext;
    public VkBool32 combinedImageSamplerDescriptorSingleArray;
    public VkBool32 bufferlessPushDescriptors;
    public VkBool32 allowSamplerImageViewPostSubmitCreation;
    public VkDeviceSize descriptorBufferOffsetAlignment;
    public uint maxDescriptorBufferBindings;
    public uint maxResourceDescriptorBufferBindings;
    public uint maxSamplerDescriptorBufferBindings;
    public uint maxEmbeddedImmutableSamplerBindings;
    public uint maxEmbeddedImmutableSamplers;
    public ulong bufferCaptureReplayDescriptorDataSize;
    public ulong imageCaptureReplayDescriptorDataSize;
    public ulong imageViewCaptureReplayDescriptorDataSize;
    public ulong samplerCaptureReplayDescriptorDataSize;
    public ulong accelerationStructureCaptureReplayDescriptorDataSize;
    public ulong samplerDescriptorSize;
    public ulong combinedImageSamplerDescriptorSize;
    public ulong sampledImageDescriptorSize;
    public ulong storageImageDescriptorSize;
    public ulong uniformTexelBufferDescriptorSize;
    public ulong robustUniformTexelBufferDescriptorSize;
    public ulong storageTexelBufferDescriptorSize;
    public ulong robustStorageTexelBufferDescriptorSize;
    public ulong uniformBufferDescriptorSize;
    public ulong robustUniformBufferDescriptorSize;
    public ulong storageBufferDescriptorSize;
    public ulong robustStorageBufferDescriptorSize;
    public ulong inputAttachmentDescriptorSize;
    public ulong accelerationStructureDescriptorSize;
    public VkDeviceSize maxSamplerDescriptorBufferRange;
    public VkDeviceSize maxResourceDescriptorBufferRange;
    public VkDeviceSize samplerDescriptorBufferAddressSpaceSize;
    public VkDeviceSize resourceDescriptorBufferAddressSpaceSize;
    public VkDeviceSize descriptorBufferAddressSpaceSize;
}



