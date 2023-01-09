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

public unsafe partial class InitializePerformanceApiInfoINTEL : QBDisposableObject
{
    public InitializePerformanceApiInfoINTEL()
    {
    }

    public InitializePerformanceApiInfoINTEL(AdamantiumVulkan.Core.Interop.VkInitializePerformanceApiInfoINTEL _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        PUserData = _internal.pUserData;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public void* PUserData { get; set; }

    public AdamantiumVulkan.Core.Interop.VkInitializePerformanceApiInfoINTEL ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkInitializePerformanceApiInfoINTEL();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.pUserData = PUserData;
        return _internal;
    }

    public static implicit operator InitializePerformanceApiInfoINTEL(AdamantiumVulkan.Core.Interop.VkInitializePerformanceApiInfoINTEL i)
    {
        return new InitializePerformanceApiInfoINTEL(i);
    }

}


