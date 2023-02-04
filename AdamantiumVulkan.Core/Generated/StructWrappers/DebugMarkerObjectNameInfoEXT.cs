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

public unsafe partial class DebugMarkerObjectNameInfoEXT : QBDisposableObject
{
    private MarshaledString _pObjectName;

    public DebugMarkerObjectNameInfoEXT()
    {
    }

    public DebugMarkerObjectNameInfoEXT(AdamantiumVulkan.Core.Interop.VkDebugMarkerObjectNameInfoEXT _internal)
    {
        PNext = _internal.pNext;
        ObjectType = _internal.objectType;
        Object = _internal.@object;
        PObjectName = new string(_internal.pObjectName);
    }

    public StructureType SType => StructureType.DebugMarkerObjectNameInfoExt;
    public void* PNext { get; set; }
    public DebugReportObjectTypeEXT ObjectType { get; set; }
    public ulong Object { get; set; }
    public string PObjectName { get; set; }

    public AdamantiumVulkan.Core.Interop.VkDebugMarkerObjectNameInfoEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkDebugMarkerObjectNameInfoEXT();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.objectType = ObjectType;
        _internal.@object = Object;
        _pObjectName.Dispose();
        if (PObjectName != null)
        {
            _pObjectName = new MarshaledString(PObjectName, false);
            _internal.pObjectName = (sbyte*)_pObjectName;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        _pObjectName.Dispose();
    }


    public static implicit operator DebugMarkerObjectNameInfoEXT(AdamantiumVulkan.Core.Interop.VkDebugMarkerObjectNameInfoEXT d)
    {
        return new DebugMarkerObjectNameInfoEXT(d);
    }

}



