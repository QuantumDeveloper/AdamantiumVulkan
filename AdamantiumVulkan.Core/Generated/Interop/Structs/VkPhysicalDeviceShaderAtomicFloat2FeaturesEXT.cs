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
public unsafe partial struct VkPhysicalDeviceShaderAtomicFloat2FeaturesEXT
{
    public StructureType sType;
    public void* pNext;
    public VkBool32 shaderBufferFloat16Atomics;
    public VkBool32 shaderBufferFloat16AtomicAdd;
    public VkBool32 shaderBufferFloat16AtomicMinMax;
    public VkBool32 shaderBufferFloat32AtomicMinMax;
    public VkBool32 shaderBufferFloat64AtomicMinMax;
    public VkBool32 shaderSharedFloat16Atomics;
    public VkBool32 shaderSharedFloat16AtomicAdd;
    public VkBool32 shaderSharedFloat16AtomicMinMax;
    public VkBool32 shaderSharedFloat32AtomicMinMax;
    public VkBool32 shaderSharedFloat64AtomicMinMax;
    public VkBool32 shaderImageFloat32AtomicMinMax;
    public VkBool32 sparseImageFloat32AtomicMinMax;
}


