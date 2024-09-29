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

public unsafe partial class PresentTimeGOOGLE : QBDisposableObject
{
    public PresentTimeGOOGLE()
    {
    }

    public PresentTimeGOOGLE(AdamantiumVulkan.Core.Interop.VkPresentTimeGOOGLE _internal)
    {
        PresentID = _internal.presentID;
        DesiredPresentTime = _internal.desiredPresentTime;
    }

    public uint PresentID { get; set; }
    public ulong DesiredPresentTime { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPresentTimeGOOGLE ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPresentTimeGOOGLE();
        if (PresentID != default)
        {
            _internal.presentID = PresentID;
        }
        if (DesiredPresentTime != default)
        {
            _internal.desiredPresentTime = DesiredPresentTime;
        }
        return _internal;
    }

    public static implicit operator PresentTimeGOOGLE(AdamantiumVulkan.Core.Interop.VkPresentTimeGOOGLE p)
    {
        return new PresentTimeGOOGLE(p);
    }

}



