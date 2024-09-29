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

public unsafe partial class PhysicalDeviceTransformFeedbackPropertiesEXT : QBDisposableObject
{
    public PhysicalDeviceTransformFeedbackPropertiesEXT()
    {
    }

    public PhysicalDeviceTransformFeedbackPropertiesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceTransformFeedbackPropertiesEXT _internal)
    {
        PNext = _internal.pNext;
        MaxTransformFeedbackStreams = _internal.maxTransformFeedbackStreams;
        MaxTransformFeedbackBuffers = _internal.maxTransformFeedbackBuffers;
        MaxTransformFeedbackBufferSize = _internal.maxTransformFeedbackBufferSize;
        MaxTransformFeedbackStreamDataSize = _internal.maxTransformFeedbackStreamDataSize;
        MaxTransformFeedbackBufferDataSize = _internal.maxTransformFeedbackBufferDataSize;
        MaxTransformFeedbackBufferDataStride = _internal.maxTransformFeedbackBufferDataStride;
        TransformFeedbackQueries = _internal.transformFeedbackQueries;
        TransformFeedbackStreamsLinesTriangles = _internal.transformFeedbackStreamsLinesTriangles;
        TransformFeedbackRasterizationStreamSelect = _internal.transformFeedbackRasterizationStreamSelect;
        TransformFeedbackDraw = _internal.transformFeedbackDraw;
    }

    public StructureType SType => StructureType.PhysicalDeviceTransformFeedbackPropertiesExt;
    public void* PNext { get; set; }
    public uint MaxTransformFeedbackStreams { get; set; }
    public uint MaxTransformFeedbackBuffers { get; set; }
    public VkDeviceSize MaxTransformFeedbackBufferSize { get; set; }
    public uint MaxTransformFeedbackStreamDataSize { get; set; }
    public uint MaxTransformFeedbackBufferDataSize { get; set; }
    public uint MaxTransformFeedbackBufferDataStride { get; set; }
    public VkBool32 TransformFeedbackQueries { get; set; }
    public VkBool32 TransformFeedbackStreamsLinesTriangles { get; set; }
    public VkBool32 TransformFeedbackRasterizationStreamSelect { get; set; }
    public VkBool32 TransformFeedbackDraw { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceTransformFeedbackPropertiesEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceTransformFeedbackPropertiesEXT();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (MaxTransformFeedbackStreams != default)
        {
            _internal.maxTransformFeedbackStreams = MaxTransformFeedbackStreams;
        }
        if (MaxTransformFeedbackBuffers != default)
        {
            _internal.maxTransformFeedbackBuffers = MaxTransformFeedbackBuffers;
        }
        if (MaxTransformFeedbackBufferSize != (ulong)default)
        {
            _internal.maxTransformFeedbackBufferSize = MaxTransformFeedbackBufferSize;
        }
        if (MaxTransformFeedbackStreamDataSize != default)
        {
            _internal.maxTransformFeedbackStreamDataSize = MaxTransformFeedbackStreamDataSize;
        }
        if (MaxTransformFeedbackBufferDataSize != default)
        {
            _internal.maxTransformFeedbackBufferDataSize = MaxTransformFeedbackBufferDataSize;
        }
        if (MaxTransformFeedbackBufferDataStride != default)
        {
            _internal.maxTransformFeedbackBufferDataStride = MaxTransformFeedbackBufferDataStride;
        }
        if (TransformFeedbackQueries != (uint)default)
        {
            _internal.transformFeedbackQueries = TransformFeedbackQueries;
        }
        if (TransformFeedbackStreamsLinesTriangles != (uint)default)
        {
            _internal.transformFeedbackStreamsLinesTriangles = TransformFeedbackStreamsLinesTriangles;
        }
        if (TransformFeedbackRasterizationStreamSelect != (uint)default)
        {
            _internal.transformFeedbackRasterizationStreamSelect = TransformFeedbackRasterizationStreamSelect;
        }
        if (TransformFeedbackDraw != (uint)default)
        {
            _internal.transformFeedbackDraw = TransformFeedbackDraw;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceTransformFeedbackPropertiesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceTransformFeedbackPropertiesEXT p)
    {
        return new PhysicalDeviceTransformFeedbackPropertiesEXT(p);
    }

}



