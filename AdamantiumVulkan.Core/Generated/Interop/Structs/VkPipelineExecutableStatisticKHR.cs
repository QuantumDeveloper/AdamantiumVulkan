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
public unsafe partial struct VkPipelineExecutableStatisticKHR
{
    public StructureType sType;
    public void* pNext;
    public unsafe fixed sbyte name[256];
    public unsafe fixed sbyte description[256];
    public PipelineExecutableStatisticFormatKHR format;
    public VkPipelineExecutableStatisticValueKHR value;
}


