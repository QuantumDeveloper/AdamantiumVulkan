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
public unsafe partial struct VkDisplaySurfaceCreateInfoKHR
{
    public StructureType sType;
    public void* pNext;
    public VkDisplaySurfaceCreateFlagsKHR flags;
    public VkDisplayModeKHR_T displayMode;
    public uint planeIndex;
    public uint planeStackIndex;
    public SurfaceTransformFlagBitsKHR transform;
    public float globalAlpha;
    public DisplayPlaneAlphaFlagBitsKHR alphaMode;
    public VkExtent2D imageExtent;
}



