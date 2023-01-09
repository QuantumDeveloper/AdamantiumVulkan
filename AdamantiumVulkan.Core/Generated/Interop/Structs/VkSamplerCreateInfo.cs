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

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkSamplerCreateInfo
{
    public StructureType sType;
    public void* pNext;
    public VkSamplerCreateFlags flags;
    public Filter magFilter;
    public Filter minFilter;
    public SamplerMipmapMode mipmapMode;
    public SamplerAddressMode addressModeU;
    public SamplerAddressMode addressModeV;
    public SamplerAddressMode addressModeW;
    public float mipLodBias;
    public VkBool32 anisotropyEnable;
    public float maxAnisotropy;
    public VkBool32 compareEnable;
    public CompareOp compareOp;
    public float minLod;
    public float maxLod;
    public BorderColor borderColor;
    public VkBool32 unnormalizedCoordinates;
}


