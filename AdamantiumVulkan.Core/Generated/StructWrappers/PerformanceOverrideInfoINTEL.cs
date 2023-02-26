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

public unsafe partial class PerformanceOverrideInfoINTEL : QBDisposableObject
{
    public PerformanceOverrideInfoINTEL()
    {
    }

    public PerformanceOverrideInfoINTEL(AdamantiumVulkan.Core.Interop.VkPerformanceOverrideInfoINTEL _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        Type = _internal.type;
        Enable = _internal.enable;
        Parameter = _internal.parameter;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public PerformanceOverrideTypeINTEL Type { get; set; }
    public VkBool32 Enable { get; set; }
    public ulong Parameter { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPerformanceOverrideInfoINTEL ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPerformanceOverrideInfoINTEL();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.type = Type;
        _internal.enable = Enable;
        _internal.parameter = Parameter;
        return _internal;
    }

    public static implicit operator PerformanceOverrideInfoINTEL(AdamantiumVulkan.Core.Interop.VkPerformanceOverrideInfoINTEL p)
    {
        return new PerformanceOverrideInfoINTEL(p);
    }

}



