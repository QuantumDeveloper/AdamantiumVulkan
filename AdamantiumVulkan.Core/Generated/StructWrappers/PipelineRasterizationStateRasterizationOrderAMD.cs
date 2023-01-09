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

public unsafe partial class PipelineRasterizationStateRasterizationOrderAMD : QBDisposableObject
{
    public PipelineRasterizationStateRasterizationOrderAMD()
    {
    }

    public PipelineRasterizationStateRasterizationOrderAMD(AdamantiumVulkan.Core.Interop.VkPipelineRasterizationStateRasterizationOrderAMD _internal)
    {
        PNext = _internal.pNext;
        RasterizationOrder = _internal.rasterizationOrder;
    }

    public StructureType SType => StructureType.PipelineRasterizationStateRasterizationOrderAmd;
    public void* PNext { get; set; }
    public RasterizationOrderAMD RasterizationOrder { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPipelineRasterizationStateRasterizationOrderAMD ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPipelineRasterizationStateRasterizationOrderAMD();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.rasterizationOrder = RasterizationOrder;
        return _internal;
    }

    public static implicit operator PipelineRasterizationStateRasterizationOrderAMD(AdamantiumVulkan.Core.Interop.VkPipelineRasterizationStateRasterizationOrderAMD p)
    {
        return new PipelineRasterizationStateRasterizationOrderAMD(p);
    }

}


