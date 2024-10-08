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

public unsafe partial class DebugReportCallbackCreateInfoEXT : QBDisposableObject
{
    public DebugReportCallbackCreateInfoEXT()
    {
    }

    public DebugReportCallbackCreateInfoEXT(AdamantiumVulkan.Core.Interop.VkDebugReportCallbackCreateInfoEXT _internal)
    {
        PNext = _internal.pNext;
        Flags = _internal.flags;
        PfnCallback = _internal.pfnCallback;
        PUserData = _internal.pUserData;
    }

    public StructureType SType => StructureType.DebugReportCallbackCreateInfoExt;
    public void* PNext { get; set; }
    public VkDebugReportFlagsEXT Flags { get; set; }
    public delegate* unmanaged<VkDebugReportFlagsEXT, DebugReportObjectTypeEXT, ulong, ulong, int, sbyte*, sbyte*, void*, uint> PfnCallback { get; set; }
    public void* PUserData { get; set; }

    public AdamantiumVulkan.Core.Interop.VkDebugReportCallbackCreateInfoEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkDebugReportCallbackCreateInfoEXT();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (Flags != (uint)default)
        {
            _internal.flags = Flags;
        }
        if (PfnCallback != default)
        {
            _internal.pfnCallback = PfnCallback;
        }
        _internal.pUserData = PUserData;
        return _internal;
    }

    public static implicit operator DebugReportCallbackCreateInfoEXT(AdamantiumVulkan.Core.Interop.VkDebugReportCallbackCreateInfoEXT d)
    {
        return new DebugReportCallbackCreateInfoEXT(d);
    }

}



