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
public unsafe partial struct VkPhysicalDeviceVulkan13Features
{
    public StructureType sType;
    public void* pNext;
    public VkBool32 robustImageAccess;
    public VkBool32 inlineUniformBlock;
    public VkBool32 descriptorBindingInlineUniformBlockUpdateAfterBind;
    public VkBool32 pipelineCreationCacheControl;
    public VkBool32 privateData;
    public VkBool32 shaderDemoteToHelperInvocation;
    public VkBool32 shaderTerminateInvocation;
    public VkBool32 subgroupSizeControl;
    public VkBool32 computeFullSubgroups;
    public VkBool32 synchronization2;
    public VkBool32 textureCompressionASTC_HDR;
    public VkBool32 shaderZeroInitializeWorkgroupMemory;
    public VkBool32 dynamicRendering;
    public VkBool32 shaderIntegerDotProduct;
    public VkBool32 maintenance4;
}



