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
public unsafe partial struct VkPhysicalDeviceMeshShaderPropertiesNV
{
    public StructureType sType;
    public void* pNext;
    public uint maxDrawMeshTasksCount;
    public uint maxTaskWorkGroupInvocations;
    public unsafe fixed uint maxTaskWorkGroupSize[3];
    public uint maxTaskTotalMemorySize;
    public uint maxTaskOutputCount;
    public uint maxMeshWorkGroupInvocations;
    public unsafe fixed uint maxMeshWorkGroupSize[3];
    public uint maxMeshTotalMemorySize;
    public uint maxMeshOutputVertices;
    public uint maxMeshOutputPrimitives;
    public uint maxMeshMultiviewViewCount;
    public uint meshOutputPerVertexGranularity;
    public uint meshOutputPerPrimitiveGranularity;
}



