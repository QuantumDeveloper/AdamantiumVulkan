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

public unsafe partial class ExternalSemaphoreProperties : QBDisposableObject
{
    public ExternalSemaphoreProperties()
    {
    }

    public ExternalSemaphoreProperties(AdamantiumVulkan.Core.Interop.VkExternalSemaphoreProperties _internal)
    {
        PNext = _internal.pNext;
        ExportFromImportedHandleTypes = _internal.exportFromImportedHandleTypes;
        CompatibleHandleTypes = _internal.compatibleHandleTypes;
        ExternalSemaphoreFeatures = _internal.externalSemaphoreFeatures;
    }

    public StructureType SType => StructureType.ExternalSemaphoreProperties;
    public void* PNext { get; set; }
    public VkExternalSemaphoreHandleTypeFlags ExportFromImportedHandleTypes { get; set; }
    public VkExternalSemaphoreHandleTypeFlags CompatibleHandleTypes { get; set; }
    public VkExternalSemaphoreFeatureFlags ExternalSemaphoreFeatures { get; set; }

    public AdamantiumVulkan.Core.Interop.VkExternalSemaphoreProperties ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkExternalSemaphoreProperties();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (ExportFromImportedHandleTypes != (uint)default)
        {
            _internal.exportFromImportedHandleTypes = ExportFromImportedHandleTypes;
        }
        if (CompatibleHandleTypes != (uint)default)
        {
            _internal.compatibleHandleTypes = CompatibleHandleTypes;
        }
        if (ExternalSemaphoreFeatures != (uint)default)
        {
            _internal.externalSemaphoreFeatures = ExternalSemaphoreFeatures;
        }
        return _internal;
    }

    public static implicit operator ExternalSemaphoreProperties(AdamantiumVulkan.Core.Interop.VkExternalSemaphoreProperties e)
    {
        return new ExternalSemaphoreProperties(e);
    }

}



