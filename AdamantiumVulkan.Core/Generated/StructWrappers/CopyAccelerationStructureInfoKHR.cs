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

public unsafe partial class CopyAccelerationStructureInfoKHR : QBDisposableObject
{
    public CopyAccelerationStructureInfoKHR()
    {
    }

    public CopyAccelerationStructureInfoKHR(AdamantiumVulkan.Core.Interop.VkCopyAccelerationStructureInfoKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        Src = new AccelerationStructureKHR(_internal.src);
        Dst = new AccelerationStructureKHR(_internal.dst);
        Mode = _internal.mode;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public AccelerationStructureKHR Src { get; set; }
    public AccelerationStructureKHR Dst { get; set; }
    public CopyAccelerationStructureModeKHR Mode { get; set; }

    public AdamantiumVulkan.Core.Interop.VkCopyAccelerationStructureInfoKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkCopyAccelerationStructureInfoKHR();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.src = Src;
        _internal.dst = Dst;
        _internal.mode = Mode;
        return _internal;
    }

    public static implicit operator CopyAccelerationStructureInfoKHR(AdamantiumVulkan.Core.Interop.VkCopyAccelerationStructureInfoKHR c)
    {
        return new CopyAccelerationStructureInfoKHR(c);
    }

}



