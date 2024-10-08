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

public unsafe partial class LayerSettingEXT : QBDisposableObject
{
    private MarshaledString _pLayerName;

    private MarshaledString _pSettingName;

    public LayerSettingEXT()
    {
    }

    public LayerSettingEXT(AdamantiumVulkan.Core.Interop.VkLayerSettingEXT _internal)
    {
        PLayerName = new string(_internal.pLayerName);
        PSettingName = new string(_internal.pSettingName);
        Type = _internal.type;
        ValueCount = _internal.valueCount;
        PValues = _internal.pValues;
    }

    public string PLayerName { get; set; }
    public string PSettingName { get; set; }
    public LayerSettingTypeEXT Type { get; set; }
    public uint ValueCount { get; set; }
    public void* PValues { get; set; }

    public AdamantiumVulkan.Core.Interop.VkLayerSettingEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkLayerSettingEXT();
        _pLayerName.Dispose();
        if (PLayerName != default)
        {
            _pLayerName = new MarshaledString(PLayerName, false);
            _internal.pLayerName = (sbyte*)_pLayerName;
        }
        _pSettingName.Dispose();
        if (PSettingName != default)
        {
            _pSettingName = new MarshaledString(PSettingName, false);
            _internal.pSettingName = (sbyte*)_pSettingName;
        }
        if (Type != default)
        {
            _internal.type = Type;
        }
        if (ValueCount != default)
        {
            _internal.valueCount = ValueCount;
        }
        _internal.pValues = PValues;
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        _pLayerName.Dispose();
        _pSettingName.Dispose();
    }


    public static implicit operator LayerSettingEXT(AdamantiumVulkan.Core.Interop.VkLayerSettingEXT l)
    {
        return new LayerSettingEXT(l);
    }

}



