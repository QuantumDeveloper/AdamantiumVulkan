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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 21800 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkPhysicalDeviceMeshShaderPropertiesEXT
{
    public StructureType sType;
    public void* pNext;
    public uint maxTaskWorkGroupTotalCount;
    public unsafe fixed uint maxTaskWorkGroupCount[3];
    public uint maxTaskWorkGroupInvocations;
    public unsafe fixed uint maxTaskWorkGroupSize[3];
    public uint maxTaskPayloadSize;
    public uint maxTaskSharedMemorySize;
    public uint maxTaskPayloadAndSharedMemorySize;
    public uint maxMeshWorkGroupTotalCount;
    public unsafe fixed uint maxMeshWorkGroupCount[3];
    public uint maxMeshWorkGroupInvocations;
    public unsafe fixed uint maxMeshWorkGroupSize[3];
    public uint maxMeshSharedMemorySize;
    public uint maxMeshPayloadAndSharedMemorySize;
    public uint maxMeshOutputMemorySize;
    public uint maxMeshPayloadAndOutputMemorySize;
    public uint maxMeshOutputComponents;
    public uint maxMeshOutputVertices;
    public uint maxMeshOutputPrimitives;
    public uint maxMeshOutputLayers;
    public uint maxMeshMultiviewViewCount;
    public uint meshOutputPerVertexGranularity;
    public uint meshOutputPerPrimitiveGranularity;
    public uint maxPreferredTaskWorkGroupInvocations;
    public uint maxPreferredMeshWorkGroupInvocations;
    public VkBool32 prefersLocalInvocationVertexOutput;
    public VkBool32 prefersLocalInvocationPrimitiveOutput;
    public VkBool32 prefersCompactVertexOutput;
    public VkBool32 prefersCompactPrimitiveOutput;
}



