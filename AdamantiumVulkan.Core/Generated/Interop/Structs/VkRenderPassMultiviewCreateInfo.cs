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
public unsafe partial struct VkRenderPassMultiviewCreateInfo
{
    public StructureType sType;
    public void* pNext;
    public uint subpassCount;
    public uint* pViewMasks;
    public uint dependencyCount;
    public int* pViewOffsets;
    public uint correlationMaskCount;
    public uint* pCorrelationMasks;
}



