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

public unsafe partial class PhysicalDeviceDeviceGeneratedCommandsPropertiesEXT : QBDisposableObject
{
    public PhysicalDeviceDeviceGeneratedCommandsPropertiesEXT()
    {
    }

    public PhysicalDeviceDeviceGeneratedCommandsPropertiesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceDeviceGeneratedCommandsPropertiesEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        MaxIndirectPipelineCount = _internal.maxIndirectPipelineCount;
        MaxIndirectShaderObjectCount = _internal.maxIndirectShaderObjectCount;
        MaxIndirectSequenceCount = _internal.maxIndirectSequenceCount;
        MaxIndirectCommandsTokenCount = _internal.maxIndirectCommandsTokenCount;
        MaxIndirectCommandsTokenOffset = _internal.maxIndirectCommandsTokenOffset;
        MaxIndirectCommandsIndirectStride = _internal.maxIndirectCommandsIndirectStride;
        SupportedIndirectCommandsInputModes = _internal.supportedIndirectCommandsInputModes;
        SupportedIndirectCommandsShaderStages = _internal.supportedIndirectCommandsShaderStages;
        SupportedIndirectCommandsShaderStagesPipelineBinding = _internal.supportedIndirectCommandsShaderStagesPipelineBinding;
        SupportedIndirectCommandsShaderStagesShaderBinding = _internal.supportedIndirectCommandsShaderStagesShaderBinding;
        DeviceGeneratedCommandsTransformFeedback = _internal.deviceGeneratedCommandsTransformFeedback;
        DeviceGeneratedCommandsMultiDrawIndirectCount = _internal.deviceGeneratedCommandsMultiDrawIndirectCount;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public uint MaxIndirectPipelineCount { get; set; }
    public uint MaxIndirectShaderObjectCount { get; set; }
    public uint MaxIndirectSequenceCount { get; set; }
    public uint MaxIndirectCommandsTokenCount { get; set; }
    public uint MaxIndirectCommandsTokenOffset { get; set; }
    public uint MaxIndirectCommandsIndirectStride { get; set; }
    public VkIndirectCommandsInputModeFlagsEXT SupportedIndirectCommandsInputModes { get; set; }
    public VkShaderStageFlags SupportedIndirectCommandsShaderStages { get; set; }
    public VkShaderStageFlags SupportedIndirectCommandsShaderStagesPipelineBinding { get; set; }
    public VkShaderStageFlags SupportedIndirectCommandsShaderStagesShaderBinding { get; set; }
    public VkBool32 DeviceGeneratedCommandsTransformFeedback { get; set; }
    public VkBool32 DeviceGeneratedCommandsMultiDrawIndirectCount { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceDeviceGeneratedCommandsPropertiesEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceDeviceGeneratedCommandsPropertiesEXT();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (MaxIndirectPipelineCount != default)
        {
            _internal.maxIndirectPipelineCount = MaxIndirectPipelineCount;
        }
        if (MaxIndirectShaderObjectCount != default)
        {
            _internal.maxIndirectShaderObjectCount = MaxIndirectShaderObjectCount;
        }
        if (MaxIndirectSequenceCount != default)
        {
            _internal.maxIndirectSequenceCount = MaxIndirectSequenceCount;
        }
        if (MaxIndirectCommandsTokenCount != default)
        {
            _internal.maxIndirectCommandsTokenCount = MaxIndirectCommandsTokenCount;
        }
        if (MaxIndirectCommandsTokenOffset != default)
        {
            _internal.maxIndirectCommandsTokenOffset = MaxIndirectCommandsTokenOffset;
        }
        if (MaxIndirectCommandsIndirectStride != default)
        {
            _internal.maxIndirectCommandsIndirectStride = MaxIndirectCommandsIndirectStride;
        }
        if (SupportedIndirectCommandsInputModes != (uint)default)
        {
            _internal.supportedIndirectCommandsInputModes = SupportedIndirectCommandsInputModes;
        }
        if (SupportedIndirectCommandsShaderStages != (uint)default)
        {
            _internal.supportedIndirectCommandsShaderStages = SupportedIndirectCommandsShaderStages;
        }
        if (SupportedIndirectCommandsShaderStagesPipelineBinding != (uint)default)
        {
            _internal.supportedIndirectCommandsShaderStagesPipelineBinding = SupportedIndirectCommandsShaderStagesPipelineBinding;
        }
        if (SupportedIndirectCommandsShaderStagesShaderBinding != (uint)default)
        {
            _internal.supportedIndirectCommandsShaderStagesShaderBinding = SupportedIndirectCommandsShaderStagesShaderBinding;
        }
        if (DeviceGeneratedCommandsTransformFeedback != (uint)default)
        {
            _internal.deviceGeneratedCommandsTransformFeedback = DeviceGeneratedCommandsTransformFeedback;
        }
        if (DeviceGeneratedCommandsMultiDrawIndirectCount != (uint)default)
        {
            _internal.deviceGeneratedCommandsMultiDrawIndirectCount = DeviceGeneratedCommandsMultiDrawIndirectCount;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceDeviceGeneratedCommandsPropertiesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceDeviceGeneratedCommandsPropertiesEXT p)
    {
        return new PhysicalDeviceDeviceGeneratedCommandsPropertiesEXT(p);
    }

}



