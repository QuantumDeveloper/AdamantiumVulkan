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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 21440 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkAccelerationStructureBuildGeometryInfoKHR
{
    public StructureType sType;
    public void* pNext;
    public AccelerationStructureTypeKHR type;
    public BuildAccelerationStructureFlagBitsKHR flags;
    public BuildAccelerationStructureModeKHR mode;
    public VkAccelerationStructureKHR_T srcAccelerationStructure;
    public VkAccelerationStructureKHR_T dstAccelerationStructure;
    public uint geometryCount;
    public AdamantiumVulkan.Core.Interop.VkAccelerationStructureGeometryKHR* pGeometries;
    public AdamantiumVulkan.Core.Interop.VkAccelerationStructureGeometryKHR* ppGeometries;
    public VkDeviceOrHostAddressKHR scratchData;
}



