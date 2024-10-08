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

public unsafe partial class PresentTimesInfoGOOGLE : QBDisposableObject
{
    private NativeStruct<AdamantiumVulkan.Core.Interop.VkPresentTimeGOOGLE> _pTimes;

    public PresentTimesInfoGOOGLE()
    {
    }

    public PresentTimesInfoGOOGLE(AdamantiumVulkan.Core.Interop.VkPresentTimesInfoGOOGLE _internal)
    {
        PNext = _internal.pNext;
        SwapchainCount = _internal.swapchainCount;
        PTimes = new PresentTimeGOOGLE(*_internal.pTimes);
        NativeUtils.Free(_internal.pTimes);
    }

    public StructureType SType => StructureType.PresentTimesInfoGoogle;
    public void* PNext { get; set; }
    public uint SwapchainCount { get; set; }
    public PresentTimeGOOGLE PTimes { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPresentTimesInfoGOOGLE ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPresentTimesInfoGOOGLE();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (SwapchainCount != default)
        {
            _internal.swapchainCount = SwapchainCount;
        }
        _pTimes.Dispose();
        if (PTimes != default)
        {
            var struct0 = PTimes.ToNative();
            _pTimes = new NativeStruct<AdamantiumVulkan.Core.Interop.VkPresentTimeGOOGLE>(struct0);
            _internal.pTimes = _pTimes.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        _pTimes.Dispose();
    }


    public static implicit operator PresentTimesInfoGOOGLE(AdamantiumVulkan.Core.Interop.VkPresentTimesInfoGOOGLE p)
    {
        return new PresentTimesInfoGOOGLE(p);
    }

}



