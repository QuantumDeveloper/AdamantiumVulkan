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

public unsafe partial class PhysicalDeviceOpticalFlowPropertiesNV : QBDisposableObject
{
    public PhysicalDeviceOpticalFlowPropertiesNV()
    {
    }

    public PhysicalDeviceOpticalFlowPropertiesNV(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceOpticalFlowPropertiesNV _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        SupportedOutputGridSizes = _internal.supportedOutputGridSizes;
        SupportedHintGridSizes = _internal.supportedHintGridSizes;
        HintSupported = _internal.hintSupported;
        CostSupported = _internal.costSupported;
        BidirectionalFlowSupported = _internal.bidirectionalFlowSupported;
        GlobalFlowSupported = _internal.globalFlowSupported;
        MinWidth = _internal.minWidth;
        MinHeight = _internal.minHeight;
        MaxWidth = _internal.maxWidth;
        MaxHeight = _internal.maxHeight;
        MaxNumRegionsOfInterest = _internal.maxNumRegionsOfInterest;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkOpticalFlowGridSizeFlagsNV SupportedOutputGridSizes { get; set; }
    public VkOpticalFlowGridSizeFlagsNV SupportedHintGridSizes { get; set; }
    public VkBool32 HintSupported { get; set; }
    public VkBool32 CostSupported { get; set; }
    public VkBool32 BidirectionalFlowSupported { get; set; }
    public VkBool32 GlobalFlowSupported { get; set; }
    public uint MinWidth { get; set; }
    public uint MinHeight { get; set; }
    public uint MaxWidth { get; set; }
    public uint MaxHeight { get; set; }
    public uint MaxNumRegionsOfInterest { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceOpticalFlowPropertiesNV ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceOpticalFlowPropertiesNV();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.supportedOutputGridSizes = SupportedOutputGridSizes;
        _internal.supportedHintGridSizes = SupportedHintGridSizes;
        _internal.hintSupported = HintSupported;
        _internal.costSupported = CostSupported;
        _internal.bidirectionalFlowSupported = BidirectionalFlowSupported;
        _internal.globalFlowSupported = GlobalFlowSupported;
        _internal.minWidth = MinWidth;
        _internal.minHeight = MinHeight;
        _internal.maxWidth = MaxWidth;
        _internal.maxHeight = MaxHeight;
        _internal.maxNumRegionsOfInterest = MaxNumRegionsOfInterest;
        return _internal;
    }

    public static implicit operator PhysicalDeviceOpticalFlowPropertiesNV(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceOpticalFlowPropertiesNV p)
    {
        return new PhysicalDeviceOpticalFlowPropertiesNV(p);
    }

}


