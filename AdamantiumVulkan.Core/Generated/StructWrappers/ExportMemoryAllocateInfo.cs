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

public unsafe partial class ExportMemoryAllocateInfo : QBDisposableObject
{
    public ExportMemoryAllocateInfo()
    {
    }

    public ExportMemoryAllocateInfo(AdamantiumVulkan.Core.Interop.VkExportMemoryAllocateInfo _internal)
    {
        PNext = _internal.pNext;
        HandleTypes = _internal.handleTypes;
    }

    public StructureType SType => StructureType.ExportMemoryAllocateInfo;
    public void* PNext { get; set; }
    public VkExternalMemoryHandleTypeFlags HandleTypes { get; set; }

    public AdamantiumVulkan.Core.Interop.VkExportMemoryAllocateInfo ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkExportMemoryAllocateInfo();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.handleTypes = HandleTypes;
        return _internal;
    }

    public static implicit operator ExportMemoryAllocateInfo(AdamantiumVulkan.Core.Interop.VkExportMemoryAllocateInfo e)
    {
        return new ExportMemoryAllocateInfo(e);
    }

}



