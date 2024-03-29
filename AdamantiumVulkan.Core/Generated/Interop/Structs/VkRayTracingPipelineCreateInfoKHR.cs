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
public unsafe partial struct VkRayTracingPipelineCreateInfoKHR
{
    public StructureType sType;
    public void* pNext;
    public VkPipelineCreateFlags flags;
    public uint stageCount;
    public VkPipelineShaderStageCreateInfo* pStages;
    public uint groupCount;
    public VkRayTracingShaderGroupCreateInfoKHR* pGroups;
    public uint maxPipelineRayRecursionDepth;
    public VkPipelineLibraryCreateInfoKHR* pLibraryInfo;
    public VkRayTracingPipelineInterfaceCreateInfoKHR* pLibraryInterface;
    public VkPipelineDynamicStateCreateInfo* pDynamicState;
    public VkPipelineLayout_T layout;
    public VkPipeline_T basePipelineHandle;
    public int basePipelineIndex;
}



