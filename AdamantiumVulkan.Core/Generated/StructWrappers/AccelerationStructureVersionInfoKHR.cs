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

public unsafe partial class AccelerationStructureVersionInfoKHR : QBDisposableObject
{
    private NativeStruct<byte> _pVersionData;

    public AccelerationStructureVersionInfoKHR()
    {
    }

    public AccelerationStructureVersionInfoKHR(AdamantiumVulkan.Core.Interop.VkAccelerationStructureVersionInfoKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        if (_internal.pVersionData != null)
        {
            PVersionData = *_internal.pVersionData;
            NativeUtils.Free(_internal.pVersionData);
        }
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public byte? PVersionData { get; set; }

    public AdamantiumVulkan.Core.Interop.VkAccelerationStructureVersionInfoKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkAccelerationStructureVersionInfoKHR();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _pVersionData.Dispose();
        if (PVersionData.HasValue)
        {
            _pVersionData = new NativeStruct<byte>(PVersionData.Value);
            _internal.pVersionData = _pVersionData.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        _pVersionData.Dispose();
    }


    public static implicit operator AccelerationStructureVersionInfoKHR(AdamantiumVulkan.Core.Interop.VkAccelerationStructureVersionInfoKHR a)
    {
        return new AccelerationStructureVersionInfoKHR(a);
    }

}



