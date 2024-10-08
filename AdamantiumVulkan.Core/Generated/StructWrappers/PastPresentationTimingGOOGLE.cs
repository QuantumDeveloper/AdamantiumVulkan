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

public unsafe partial class PastPresentationTimingGOOGLE : QBDisposableObject
{
    public PastPresentationTimingGOOGLE()
    {
    }

    public PastPresentationTimingGOOGLE(AdamantiumVulkan.Core.Interop.VkPastPresentationTimingGOOGLE _internal)
    {
        PresentID = _internal.presentID;
        DesiredPresentTime = _internal.desiredPresentTime;
        ActualPresentTime = _internal.actualPresentTime;
        EarliestPresentTime = _internal.earliestPresentTime;
        PresentMargin = _internal.presentMargin;
    }

    public uint PresentID { get; set; }
    public ulong DesiredPresentTime { get; set; }
    public ulong ActualPresentTime { get; set; }
    public ulong EarliestPresentTime { get; set; }
    public ulong PresentMargin { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPastPresentationTimingGOOGLE ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPastPresentationTimingGOOGLE();
        if (PresentID != default)
        {
            _internal.presentID = PresentID;
        }
        if (DesiredPresentTime != default)
        {
            _internal.desiredPresentTime = DesiredPresentTime;
        }
        if (ActualPresentTime != default)
        {
            _internal.actualPresentTime = ActualPresentTime;
        }
        if (EarliestPresentTime != default)
        {
            _internal.earliestPresentTime = EarliestPresentTime;
        }
        if (PresentMargin != default)
        {
            _internal.presentMargin = PresentMargin;
        }
        return _internal;
    }

    public static implicit operator PastPresentationTimingGOOGLE(AdamantiumVulkan.Core.Interop.VkPastPresentationTimingGOOGLE p)
    {
        return new PastPresentationTimingGOOGLE(p);
    }

}



