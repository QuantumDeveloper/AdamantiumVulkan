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
public unsafe partial struct VkPipelineMultisampleStateCreateInfo
{
    public StructureType sType;
    public void* pNext;
    public VkPipelineMultisampleStateCreateFlags flags;
    public SampleCountFlagBits rasterizationSamples;
    public VkBool32 sampleShadingEnable;
    public float minSampleShading;
    public VkSampleMask* pSampleMask;
    public VkBool32 alphaToCoverageEnable;
    public VkBool32 alphaToOneEnable;
}



