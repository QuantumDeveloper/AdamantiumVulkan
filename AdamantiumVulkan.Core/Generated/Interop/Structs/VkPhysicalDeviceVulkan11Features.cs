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
public unsafe partial struct VkPhysicalDeviceVulkan11Features
{
    public StructureType sType;
    public void* pNext;
    public VkBool32 storageBuffer16BitAccess;
    public VkBool32 uniformAndStorageBuffer16BitAccess;
    public VkBool32 storagePushConstant16;
    public VkBool32 storageInputOutput16;
    public VkBool32 multiview;
    public VkBool32 multiviewGeometryShader;
    public VkBool32 multiviewTessellationShader;
    public VkBool32 variablePointersStorageBuffer;
    public VkBool32 variablePointers;
    public VkBool32 protectedMemory;
    public VkBool32 samplerYcbcrConversion;
    public VkBool32 shaderDrawParameters;
}



