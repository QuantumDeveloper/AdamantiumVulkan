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

// File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_core.h Line: 6135 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkPhysicalDeviceFloatControlsProperties
{
    public StructureType sType;
    public void* pNext;
    public ShaderFloatControlsIndependence denormBehaviorIndependence;
    public ShaderFloatControlsIndependence roundingModeIndependence;
    public VkBool32 shaderSignedZeroInfNanPreserveFloat16;
    public VkBool32 shaderSignedZeroInfNanPreserveFloat32;
    public VkBool32 shaderSignedZeroInfNanPreserveFloat64;
    public VkBool32 shaderDenormPreserveFloat16;
    public VkBool32 shaderDenormPreserveFloat32;
    public VkBool32 shaderDenormPreserveFloat64;
    public VkBool32 shaderDenormFlushToZeroFloat16;
    public VkBool32 shaderDenormFlushToZeroFloat32;
    public VkBool32 shaderDenormFlushToZeroFloat64;
    public VkBool32 shaderRoundingModeRTEFloat16;
    public VkBool32 shaderRoundingModeRTEFloat32;
    public VkBool32 shaderRoundingModeRTEFloat64;
    public VkBool32 shaderRoundingModeRTZFloat16;
    public VkBool32 shaderRoundingModeRTZFloat32;
    public VkBool32 shaderRoundingModeRTZFloat64;
}



