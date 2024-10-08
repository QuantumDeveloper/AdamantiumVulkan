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

public unsafe partial class PhysicalDeviceVulkan12Features : QBDisposableObject
{
    public PhysicalDeviceVulkan12Features()
    {
    }

    public PhysicalDeviceVulkan12Features(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceVulkan12Features _internal)
    {
        PNext = _internal.pNext;
        SamplerMirrorClampToEdge = _internal.samplerMirrorClampToEdge;
        DrawIndirectCount = _internal.drawIndirectCount;
        StorageBuffer8BitAccess = _internal.storageBuffer8BitAccess;
        UniformAndStorageBuffer8BitAccess = _internal.uniformAndStorageBuffer8BitAccess;
        StoragePushConstant8 = _internal.storagePushConstant8;
        ShaderBufferInt64Atomics = _internal.shaderBufferInt64Atomics;
        ShaderSharedInt64Atomics = _internal.shaderSharedInt64Atomics;
        ShaderFloat16 = _internal.shaderFloat16;
        ShaderInt8 = _internal.shaderInt8;
        DescriptorIndexing = _internal.descriptorIndexing;
        ShaderInputAttachmentArrayDynamicIndexing = _internal.shaderInputAttachmentArrayDynamicIndexing;
        ShaderUniformTexelBufferArrayDynamicIndexing = _internal.shaderUniformTexelBufferArrayDynamicIndexing;
        ShaderStorageTexelBufferArrayDynamicIndexing = _internal.shaderStorageTexelBufferArrayDynamicIndexing;
        ShaderUniformBufferArrayNonUniformIndexing = _internal.shaderUniformBufferArrayNonUniformIndexing;
        ShaderSampledImageArrayNonUniformIndexing = _internal.shaderSampledImageArrayNonUniformIndexing;
        ShaderStorageBufferArrayNonUniformIndexing = _internal.shaderStorageBufferArrayNonUniformIndexing;
        ShaderStorageImageArrayNonUniformIndexing = _internal.shaderStorageImageArrayNonUniformIndexing;
        ShaderInputAttachmentArrayNonUniformIndexing = _internal.shaderInputAttachmentArrayNonUniformIndexing;
        ShaderUniformTexelBufferArrayNonUniformIndexing = _internal.shaderUniformTexelBufferArrayNonUniformIndexing;
        ShaderStorageTexelBufferArrayNonUniformIndexing = _internal.shaderStorageTexelBufferArrayNonUniformIndexing;
        DescriptorBindingUniformBufferUpdateAfterBind = _internal.descriptorBindingUniformBufferUpdateAfterBind;
        DescriptorBindingSampledImageUpdateAfterBind = _internal.descriptorBindingSampledImageUpdateAfterBind;
        DescriptorBindingStorageImageUpdateAfterBind = _internal.descriptorBindingStorageImageUpdateAfterBind;
        DescriptorBindingStorageBufferUpdateAfterBind = _internal.descriptorBindingStorageBufferUpdateAfterBind;
        DescriptorBindingUniformTexelBufferUpdateAfterBind = _internal.descriptorBindingUniformTexelBufferUpdateAfterBind;
        DescriptorBindingStorageTexelBufferUpdateAfterBind = _internal.descriptorBindingStorageTexelBufferUpdateAfterBind;
        DescriptorBindingUpdateUnusedWhilePending = _internal.descriptorBindingUpdateUnusedWhilePending;
        DescriptorBindingPartiallyBound = _internal.descriptorBindingPartiallyBound;
        DescriptorBindingVariableDescriptorCount = _internal.descriptorBindingVariableDescriptorCount;
        RuntimeDescriptorArray = _internal.runtimeDescriptorArray;
        SamplerFilterMinmax = _internal.samplerFilterMinmax;
        ScalarBlockLayout = _internal.scalarBlockLayout;
        ImagelessFramebuffer = _internal.imagelessFramebuffer;
        UniformBufferStandardLayout = _internal.uniformBufferStandardLayout;
        ShaderSubgroupExtendedTypes = _internal.shaderSubgroupExtendedTypes;
        SeparateDepthStencilLayouts = _internal.separateDepthStencilLayouts;
        HostQueryReset = _internal.hostQueryReset;
        TimelineSemaphore = _internal.timelineSemaphore;
        BufferDeviceAddress = _internal.bufferDeviceAddress;
        BufferDeviceAddressCaptureReplay = _internal.bufferDeviceAddressCaptureReplay;
        BufferDeviceAddressMultiDevice = _internal.bufferDeviceAddressMultiDevice;
        VulkanMemoryModel = _internal.vulkanMemoryModel;
        VulkanMemoryModelDeviceScope = _internal.vulkanMemoryModelDeviceScope;
        VulkanMemoryModelAvailabilityVisibilityChains = _internal.vulkanMemoryModelAvailabilityVisibilityChains;
        ShaderOutputViewportIndex = _internal.shaderOutputViewportIndex;
        ShaderOutputLayer = _internal.shaderOutputLayer;
        SubgroupBroadcastDynamicId = _internal.subgroupBroadcastDynamicId;
    }

    public StructureType SType => StructureType.PhysicalDeviceVulkan12Features;
    public void* PNext { get; set; }
    public VkBool32 SamplerMirrorClampToEdge { get; set; }
    public VkBool32 DrawIndirectCount { get; set; }
    public VkBool32 StorageBuffer8BitAccess { get; set; }
    public VkBool32 UniformAndStorageBuffer8BitAccess { get; set; }
    public VkBool32 StoragePushConstant8 { get; set; }
    public VkBool32 ShaderBufferInt64Atomics { get; set; }
    public VkBool32 ShaderSharedInt64Atomics { get; set; }
    public VkBool32 ShaderFloat16 { get; set; }
    public VkBool32 ShaderInt8 { get; set; }
    public VkBool32 DescriptorIndexing { get; set; }
    public VkBool32 ShaderInputAttachmentArrayDynamicIndexing { get; set; }
    public VkBool32 ShaderUniformTexelBufferArrayDynamicIndexing { get; set; }
    public VkBool32 ShaderStorageTexelBufferArrayDynamicIndexing { get; set; }
    public VkBool32 ShaderUniformBufferArrayNonUniformIndexing { get; set; }
    public VkBool32 ShaderSampledImageArrayNonUniformIndexing { get; set; }
    public VkBool32 ShaderStorageBufferArrayNonUniformIndexing { get; set; }
    public VkBool32 ShaderStorageImageArrayNonUniformIndexing { get; set; }
    public VkBool32 ShaderInputAttachmentArrayNonUniformIndexing { get; set; }
    public VkBool32 ShaderUniformTexelBufferArrayNonUniformIndexing { get; set; }
    public VkBool32 ShaderStorageTexelBufferArrayNonUniformIndexing { get; set; }
    public VkBool32 DescriptorBindingUniformBufferUpdateAfterBind { get; set; }
    public VkBool32 DescriptorBindingSampledImageUpdateAfterBind { get; set; }
    public VkBool32 DescriptorBindingStorageImageUpdateAfterBind { get; set; }
    public VkBool32 DescriptorBindingStorageBufferUpdateAfterBind { get; set; }
    public VkBool32 DescriptorBindingUniformTexelBufferUpdateAfterBind { get; set; }
    public VkBool32 DescriptorBindingStorageTexelBufferUpdateAfterBind { get; set; }
    public VkBool32 DescriptorBindingUpdateUnusedWhilePending { get; set; }
    public VkBool32 DescriptorBindingPartiallyBound { get; set; }
    public VkBool32 DescriptorBindingVariableDescriptorCount { get; set; }
    public VkBool32 RuntimeDescriptorArray { get; set; }
    public VkBool32 SamplerFilterMinmax { get; set; }
    public VkBool32 ScalarBlockLayout { get; set; }
    public VkBool32 ImagelessFramebuffer { get; set; }
    public VkBool32 UniformBufferStandardLayout { get; set; }
    public VkBool32 ShaderSubgroupExtendedTypes { get; set; }
    public VkBool32 SeparateDepthStencilLayouts { get; set; }
    public VkBool32 HostQueryReset { get; set; }
    public VkBool32 TimelineSemaphore { get; set; }
    public VkBool32 BufferDeviceAddress { get; set; }
    public VkBool32 BufferDeviceAddressCaptureReplay { get; set; }
    public VkBool32 BufferDeviceAddressMultiDevice { get; set; }
    public VkBool32 VulkanMemoryModel { get; set; }
    public VkBool32 VulkanMemoryModelDeviceScope { get; set; }
    public VkBool32 VulkanMemoryModelAvailabilityVisibilityChains { get; set; }
    public VkBool32 ShaderOutputViewportIndex { get; set; }
    public VkBool32 ShaderOutputLayer { get; set; }
    public VkBool32 SubgroupBroadcastDynamicId { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceVulkan12Features ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceVulkan12Features();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (SamplerMirrorClampToEdge != (uint)default)
        {
            _internal.samplerMirrorClampToEdge = SamplerMirrorClampToEdge;
        }
        if (DrawIndirectCount != (uint)default)
        {
            _internal.drawIndirectCount = DrawIndirectCount;
        }
        if (StorageBuffer8BitAccess != (uint)default)
        {
            _internal.storageBuffer8BitAccess = StorageBuffer8BitAccess;
        }
        if (UniformAndStorageBuffer8BitAccess != (uint)default)
        {
            _internal.uniformAndStorageBuffer8BitAccess = UniformAndStorageBuffer8BitAccess;
        }
        if (StoragePushConstant8 != (uint)default)
        {
            _internal.storagePushConstant8 = StoragePushConstant8;
        }
        if (ShaderBufferInt64Atomics != (uint)default)
        {
            _internal.shaderBufferInt64Atomics = ShaderBufferInt64Atomics;
        }
        if (ShaderSharedInt64Atomics != (uint)default)
        {
            _internal.shaderSharedInt64Atomics = ShaderSharedInt64Atomics;
        }
        if (ShaderFloat16 != (uint)default)
        {
            _internal.shaderFloat16 = ShaderFloat16;
        }
        if (ShaderInt8 != (uint)default)
        {
            _internal.shaderInt8 = ShaderInt8;
        }
        if (DescriptorIndexing != (uint)default)
        {
            _internal.descriptorIndexing = DescriptorIndexing;
        }
        if (ShaderInputAttachmentArrayDynamicIndexing != (uint)default)
        {
            _internal.shaderInputAttachmentArrayDynamicIndexing = ShaderInputAttachmentArrayDynamicIndexing;
        }
        if (ShaderUniformTexelBufferArrayDynamicIndexing != (uint)default)
        {
            _internal.shaderUniformTexelBufferArrayDynamicIndexing = ShaderUniformTexelBufferArrayDynamicIndexing;
        }
        if (ShaderStorageTexelBufferArrayDynamicIndexing != (uint)default)
        {
            _internal.shaderStorageTexelBufferArrayDynamicIndexing = ShaderStorageTexelBufferArrayDynamicIndexing;
        }
        if (ShaderUniformBufferArrayNonUniformIndexing != (uint)default)
        {
            _internal.shaderUniformBufferArrayNonUniformIndexing = ShaderUniformBufferArrayNonUniformIndexing;
        }
        if (ShaderSampledImageArrayNonUniformIndexing != (uint)default)
        {
            _internal.shaderSampledImageArrayNonUniformIndexing = ShaderSampledImageArrayNonUniformIndexing;
        }
        if (ShaderStorageBufferArrayNonUniformIndexing != (uint)default)
        {
            _internal.shaderStorageBufferArrayNonUniformIndexing = ShaderStorageBufferArrayNonUniformIndexing;
        }
        if (ShaderStorageImageArrayNonUniformIndexing != (uint)default)
        {
            _internal.shaderStorageImageArrayNonUniformIndexing = ShaderStorageImageArrayNonUniformIndexing;
        }
        if (ShaderInputAttachmentArrayNonUniformIndexing != (uint)default)
        {
            _internal.shaderInputAttachmentArrayNonUniformIndexing = ShaderInputAttachmentArrayNonUniformIndexing;
        }
        if (ShaderUniformTexelBufferArrayNonUniformIndexing != (uint)default)
        {
            _internal.shaderUniformTexelBufferArrayNonUniformIndexing = ShaderUniformTexelBufferArrayNonUniformIndexing;
        }
        if (ShaderStorageTexelBufferArrayNonUniformIndexing != (uint)default)
        {
            _internal.shaderStorageTexelBufferArrayNonUniformIndexing = ShaderStorageTexelBufferArrayNonUniformIndexing;
        }
        if (DescriptorBindingUniformBufferUpdateAfterBind != (uint)default)
        {
            _internal.descriptorBindingUniformBufferUpdateAfterBind = DescriptorBindingUniformBufferUpdateAfterBind;
        }
        if (DescriptorBindingSampledImageUpdateAfterBind != (uint)default)
        {
            _internal.descriptorBindingSampledImageUpdateAfterBind = DescriptorBindingSampledImageUpdateAfterBind;
        }
        if (DescriptorBindingStorageImageUpdateAfterBind != (uint)default)
        {
            _internal.descriptorBindingStorageImageUpdateAfterBind = DescriptorBindingStorageImageUpdateAfterBind;
        }
        if (DescriptorBindingStorageBufferUpdateAfterBind != (uint)default)
        {
            _internal.descriptorBindingStorageBufferUpdateAfterBind = DescriptorBindingStorageBufferUpdateAfterBind;
        }
        if (DescriptorBindingUniformTexelBufferUpdateAfterBind != (uint)default)
        {
            _internal.descriptorBindingUniformTexelBufferUpdateAfterBind = DescriptorBindingUniformTexelBufferUpdateAfterBind;
        }
        if (DescriptorBindingStorageTexelBufferUpdateAfterBind != (uint)default)
        {
            _internal.descriptorBindingStorageTexelBufferUpdateAfterBind = DescriptorBindingStorageTexelBufferUpdateAfterBind;
        }
        if (DescriptorBindingUpdateUnusedWhilePending != (uint)default)
        {
            _internal.descriptorBindingUpdateUnusedWhilePending = DescriptorBindingUpdateUnusedWhilePending;
        }
        if (DescriptorBindingPartiallyBound != (uint)default)
        {
            _internal.descriptorBindingPartiallyBound = DescriptorBindingPartiallyBound;
        }
        if (DescriptorBindingVariableDescriptorCount != (uint)default)
        {
            _internal.descriptorBindingVariableDescriptorCount = DescriptorBindingVariableDescriptorCount;
        }
        if (RuntimeDescriptorArray != (uint)default)
        {
            _internal.runtimeDescriptorArray = RuntimeDescriptorArray;
        }
        if (SamplerFilterMinmax != (uint)default)
        {
            _internal.samplerFilterMinmax = SamplerFilterMinmax;
        }
        if (ScalarBlockLayout != (uint)default)
        {
            _internal.scalarBlockLayout = ScalarBlockLayout;
        }
        if (ImagelessFramebuffer != (uint)default)
        {
            _internal.imagelessFramebuffer = ImagelessFramebuffer;
        }
        if (UniformBufferStandardLayout != (uint)default)
        {
            _internal.uniformBufferStandardLayout = UniformBufferStandardLayout;
        }
        if (ShaderSubgroupExtendedTypes != (uint)default)
        {
            _internal.shaderSubgroupExtendedTypes = ShaderSubgroupExtendedTypes;
        }
        if (SeparateDepthStencilLayouts != (uint)default)
        {
            _internal.separateDepthStencilLayouts = SeparateDepthStencilLayouts;
        }
        if (HostQueryReset != (uint)default)
        {
            _internal.hostQueryReset = HostQueryReset;
        }
        if (TimelineSemaphore != (uint)default)
        {
            _internal.timelineSemaphore = TimelineSemaphore;
        }
        if (BufferDeviceAddress != (uint)default)
        {
            _internal.bufferDeviceAddress = BufferDeviceAddress;
        }
        if (BufferDeviceAddressCaptureReplay != (uint)default)
        {
            _internal.bufferDeviceAddressCaptureReplay = BufferDeviceAddressCaptureReplay;
        }
        if (BufferDeviceAddressMultiDevice != (uint)default)
        {
            _internal.bufferDeviceAddressMultiDevice = BufferDeviceAddressMultiDevice;
        }
        if (VulkanMemoryModel != (uint)default)
        {
            _internal.vulkanMemoryModel = VulkanMemoryModel;
        }
        if (VulkanMemoryModelDeviceScope != (uint)default)
        {
            _internal.vulkanMemoryModelDeviceScope = VulkanMemoryModelDeviceScope;
        }
        if (VulkanMemoryModelAvailabilityVisibilityChains != (uint)default)
        {
            _internal.vulkanMemoryModelAvailabilityVisibilityChains = VulkanMemoryModelAvailabilityVisibilityChains;
        }
        if (ShaderOutputViewportIndex != (uint)default)
        {
            _internal.shaderOutputViewportIndex = ShaderOutputViewportIndex;
        }
        if (ShaderOutputLayer != (uint)default)
        {
            _internal.shaderOutputLayer = ShaderOutputLayer;
        }
        if (SubgroupBroadcastDynamicId != (uint)default)
        {
            _internal.subgroupBroadcastDynamicId = SubgroupBroadcastDynamicId;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceVulkan12Features(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceVulkan12Features p)
    {
        return new PhysicalDeviceVulkan12Features(p);
    }

}



