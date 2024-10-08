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

public unsafe partial class SemaphoreTypeCreateInfo : QBDisposableObject
{
    public SemaphoreTypeCreateInfo()
    {
    }

    public SemaphoreTypeCreateInfo(AdamantiumVulkan.Core.Interop.VkSemaphoreTypeCreateInfo _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        SemaphoreType = _internal.semaphoreType;
        InitialValue = _internal.initialValue;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public SemaphoreType SemaphoreType { get; set; }
    public ulong InitialValue { get; set; }

    public AdamantiumVulkan.Core.Interop.VkSemaphoreTypeCreateInfo ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkSemaphoreTypeCreateInfo();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (SemaphoreType != default)
        {
            _internal.semaphoreType = SemaphoreType;
        }
        if (InitialValue != default)
        {
            _internal.initialValue = InitialValue;
        }
        return _internal;
    }

    public static implicit operator SemaphoreTypeCreateInfo(AdamantiumVulkan.Core.Interop.VkSemaphoreTypeCreateInfo s)
    {
        return new SemaphoreTypeCreateInfo(s);
    }

}



