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

public unsafe partial class SubpassResolvePerformanceQueryEXT : QBDisposableObject
{
    public SubpassResolvePerformanceQueryEXT()
    {
    }

    public SubpassResolvePerformanceQueryEXT(AdamantiumVulkan.Core.Interop.VkSubpassResolvePerformanceQueryEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        Optimal = _internal.optimal;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 Optimal { get; set; }

    public AdamantiumVulkan.Core.Interop.VkSubpassResolvePerformanceQueryEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkSubpassResolvePerformanceQueryEXT();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.optimal = Optimal;
        return _internal;
    }

    public static implicit operator SubpassResolvePerformanceQueryEXT(AdamantiumVulkan.Core.Interop.VkSubpassResolvePerformanceQueryEXT s)
    {
        return new SubpassResolvePerformanceQueryEXT(s);
    }

}



