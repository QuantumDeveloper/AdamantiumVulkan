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
    private NativeStruct<VkSemaphore_T> pSemaphores;

    private NativeStruct<ulong> pValues;

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
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.flags = Flags;
        _internal.semaphoreCount = SemaphoreCount;
        pSemaphores.Dispose();
        if (PSemaphores != null)
        {
            AdamantiumVulkan.Core.Interop.VkSemaphore_T struct0 = PSemaphores;
            pSemaphores = new NativeStruct<VkSemaphore_T>(struct0);
            _internal.pSemaphores = pSemaphores.Handle;
        }
        pValues.Dispose();
        if (PValues.HasValue)
        {
            pValues = new NativeStruct<ulong>(PValues.Value);
            _internal.pValues = pValues.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        pSemaphores.Dispose();
        pValues.Dispose();
    }


    public static implicit operator SemaphoreWaitInfo(AdamantiumVulkan.Core.Interop.VkSemaphoreWaitInfo s)
    {
        return new SemaphoreWaitInfo(s);
    }

}



