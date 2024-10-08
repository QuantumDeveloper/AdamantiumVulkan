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

public unsafe partial class SemaphoreWaitInfo : QBDisposableObject
{
    private NativeStruct<AdamantiumVulkan.Core.Interop.VkSemaphore_T> _pSemaphores;

    private NativeStruct<ulong> _pValues;

    public SemaphoreWaitInfo()
    {
    }

    public SemaphoreWaitInfo(AdamantiumVulkan.Core.Interop.VkSemaphoreWaitInfo _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        Flags = _internal.flags;
        SemaphoreCount = _internal.semaphoreCount;
        PSemaphores = new Semaphore(*_internal.pSemaphores);
        NativeUtils.Free(_internal.pSemaphores);
        if (_internal.pValues != null)
        {
            PValues = *_internal.pValues;
            NativeUtils.Free(_internal.pValues);
        }
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkSemaphoreWaitFlags Flags { get; set; }
    public uint SemaphoreCount { get; set; }
    public Semaphore PSemaphores { get; set; }
    public ulong? PValues { get; set; }

    public AdamantiumVulkan.Core.Interop.VkSemaphoreWaitInfo ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkSemaphoreWaitInfo();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (Flags != (uint)default)
        {
            _internal.flags = Flags;
        }
        if (SemaphoreCount != default)
        {
            _internal.semaphoreCount = SemaphoreCount;
        }
        _pSemaphores.Dispose();
        if (PSemaphores != default)
        {
            AdamantiumVulkan.Core.Interop.VkSemaphore_T struct0 = PSemaphores;
            _pSemaphores = new NativeStruct<AdamantiumVulkan.Core.Interop.VkSemaphore_T>(struct0);
            _internal.pSemaphores = _pSemaphores.Handle;
        }
        _pValues.Dispose();
        if (PValues.HasValue)
        {
            _pValues = new NativeStruct<ulong>(PValues.Value);
            _internal.pValues = _pValues.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        _pSemaphores.Dispose();
        _pValues.Dispose();
    }


    public static implicit operator SemaphoreWaitInfo(AdamantiumVulkan.Core.Interop.VkSemaphoreWaitInfo s)
    {
        return new SemaphoreWaitInfo(s);
    }

}



