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
public unsafe partial struct VkPhysicalDeviceConservativeRasterizationPropertiesEXT
{
    public StructureType sType;
    public void* pNext;
    public float primitiveOverestimationSize;
    public float maxExtraPrimitiveOverestimationSize;
    public float extraPrimitiveOverestimationSizeGranularity;
    public VkBool32 primitiveUnderestimation;
    public VkBool32 conservativePointAndLineRasterization;
    public VkBool32 degenerateTrianglesRasterized;
    public VkBool32 degenerateLinesRasterized;
    public VkBool32 fullyCoveredFragmentShaderInputVariable;
    public VkBool32 conservativeRasterizationPostDepthCoverage;
}



