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

public unsafe partial class PerformanceConfigurationAcquireInfoINTEL : QBDisposableObject
{
    public PerformanceConfigurationAcquireInfoINTEL()
    {
    }

    public PerformanceConfigurationAcquireInfoINTEL(AdamantiumVulkan.Core.Interop.VkPerformanceConfigurationAcquireInfoINTEL _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        Type = _internal.type;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public PerformanceConfigurationTypeINTEL Type { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPerformanceConfigurationAcquireInfoINTEL ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPerformanceConfigurationAcquireInfoINTEL();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (Type != default)
        {
            _internal.type = Type;
        }
        return _internal;
    }

    public static implicit operator PerformanceConfigurationAcquireInfoINTEL(AdamantiumVulkan.Core.Interop.VkPerformanceConfigurationAcquireInfoINTEL p)
    {
        return new PerformanceConfigurationAcquireInfoINTEL(p);
    }

}



