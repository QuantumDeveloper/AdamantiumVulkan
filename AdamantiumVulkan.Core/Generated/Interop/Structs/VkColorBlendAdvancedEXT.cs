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
public unsafe partial struct VkColorBlendAdvancedEXT
{
    public BlendOp advancedBlendOp;
    public VkBool32 srcPremultiplied;
    public VkBool32 dstPremultiplied;
    public BlendOverlapEXT blendOverlap;
    public VkBool32 clampResults;
}


