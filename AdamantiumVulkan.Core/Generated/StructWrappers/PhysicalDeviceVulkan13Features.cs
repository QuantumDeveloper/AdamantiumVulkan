// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System.Runtime.InteropServices;
using QuantumBinding.Utils;
using AdamantiumVulkan.Core.Interop;

namespace AdamantiumVulkan.Core;

public unsafe partial class PhysicalDeviceVulkan13Features : QBDisposableObject
{
    public PhysicalDeviceVulkan13Features()
    {
    }

    public PhysicalDeviceVulkan13Features(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceVulkan13Features _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        RobustImageAccess = _internal.robustImageAccess;
        InlineUniformBlock = _internal.inlineUniformBlock;
        DescriptorBindingInlineUniformBlockUpdateAfterBind = _internal.descriptorBindingInlineUniformBlockUpdateAfterBind;
        PipelineCreationCacheControl = _internal.pipelineCreationCacheControl;
        PrivateData = _internal.privateData;
        ShaderDemoteToHelperInvocation = _internal.shaderDemoteToHelperInvocation;
        ShaderTerminateInvocation = _internal.shaderTerminateInvocation;
        SubgroupSizeControl = _internal.subgroupSizeControl;
        ComputeFullSubgroups = _internal.computeFullSubgroups;
        Synchronization2 = _internal.synchronization2;
        TextureCompressionASTC_HDR = _internal.textureCompressionASTC_HDR;
        ShaderZeroInitializeWorkgroupMemory = _internal.shaderZeroInitializeWorkgroupMemory;
        DynamicRendering = _internal.dynamicRendering;
        ShaderIntegerDotProduct = _internal.shaderIntegerDotProduct;
        Maintenance4 = _internal.maintenance4;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 RobustImageAccess { get; set; }
    public VkBool32 InlineUniformBlock { get; set; }
    public VkBool32 DescriptorBindingInlineUniformBlockUpdateAfterBind { get; set; }
    public VkBool32 PipelineCreationCacheControl { get; set; }
    public VkBool32 PrivateData { get; set; }
    public VkBool32 ShaderDemoteToHelperInvocation { get; set; }
    public VkBool32 ShaderTerminateInvocation { get; set; }
    public VkBool32 SubgroupSizeControl { get; set; }
    public VkBool32 ComputeFullSubgroups { get; set; }
    public VkBool32 Synchronization2 { get; set; }
    public VkBool32 TextureCompressionASTC_HDR { get; set; }
    public VkBool32 ShaderZeroInitializeWorkgroupMemory { get; set; }
    public VkBool32 DynamicRendering { get; set; }
    public VkBool32 ShaderIntegerDotProduct { get; set; }
    public VkBool32 Maintenance4 { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceVulkan13Features ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceVulkan13Features();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.robustImageAccess = RobustImageAccess;
        _internal.inlineUniformBlock = InlineUniformBlock;
        _internal.descriptorBindingInlineUniformBlockUpdateAfterBind = DescriptorBindingInlineUniformBlockUpdateAfterBind;
        _internal.pipelineCreationCacheControl = PipelineCreationCacheControl;
        _internal.privateData = PrivateData;
        _internal.shaderDemoteToHelperInvocation = ShaderDemoteToHelperInvocation;
        _internal.shaderTerminateInvocation = ShaderTerminateInvocation;
        _internal.subgroupSizeControl = SubgroupSizeControl;
        _internal.computeFullSubgroups = ComputeFullSubgroups;
        _internal.synchronization2 = Synchronization2;
        _internal.textureCompressionASTC_HDR = TextureCompressionASTC_HDR;
        _internal.shaderZeroInitializeWorkgroupMemory = ShaderZeroInitializeWorkgroupMemory;
        _internal.dynamicRendering = DynamicRendering;
        _internal.shaderIntegerDotProduct = ShaderIntegerDotProduct;
        _internal.maintenance4 = Maintenance4;
        return _internal;
    }

    public static implicit operator PhysicalDeviceVulkan13Features(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceVulkan13Features p)
    {
        return new PhysicalDeviceVulkan13Features(p);
    }

}



