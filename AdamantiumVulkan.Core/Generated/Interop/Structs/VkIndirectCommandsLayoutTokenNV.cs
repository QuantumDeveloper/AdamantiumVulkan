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
public unsafe partial struct VkIndirectCommandsLayoutTokenNV
{
    public StructureType sType;
    public void* pNext;
    public IndirectCommandsTokenTypeNV tokenType;
    public uint stream;
    public uint offset;
    public uint vertexBindingUnit;
    public VkBool32 vertexDynamicStride;
    public VkPipelineLayout_T pushconstantPipelineLayout;
    public VkShaderStageFlags pushconstantShaderStageFlags;
    public uint pushconstantOffset;
    public uint pushconstantSize;
    public VkIndirectStateFlagsNV indirectStateFlags;
    public uint indexTypeCount;
    public IndexType* pIndexTypes;
    public uint* pIndexTypeValues;
}



