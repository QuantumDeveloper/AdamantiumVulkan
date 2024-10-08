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

public unsafe partial class CopyCommandTransformInfoQCOM : QBDisposableObject
{
    public CopyCommandTransformInfoQCOM()
    {
    }

    public CopyCommandTransformInfoQCOM(AdamantiumVulkan.Core.Interop.VkCopyCommandTransformInfoQCOM _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        Transform = _internal.transform;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public SurfaceTransformFlagBitsKHR Transform { get; set; }

    public AdamantiumVulkan.Core.Interop.VkCopyCommandTransformInfoQCOM ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkCopyCommandTransformInfoQCOM();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (Transform != default)
        {
            _internal.transform = Transform;
        }
        return _internal;
    }

    public static implicit operator CopyCommandTransformInfoQCOM(AdamantiumVulkan.Core.Interop.VkCopyCommandTransformInfoQCOM c)
    {
        return new CopyCommandTransformInfoQCOM(c);
    }

}



