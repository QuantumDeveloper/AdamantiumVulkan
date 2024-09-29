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

public unsafe partial class LayerSettingsCreateInfoEXT : QBDisposableObject
{
    private NativeStruct<AdamantiumVulkan.Core.Interop.VkLayerSettingEXT> _pSettings;

    public LayerSettingsCreateInfoEXT()
    {
    }

    public LayerSettingsCreateInfoEXT(AdamantiumVulkan.Core.Interop.VkLayerSettingsCreateInfoEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        SettingCount = _internal.settingCount;
        PSettings = new LayerSettingEXT(*_internal.pSettings);
        NativeUtils.Free(_internal.pSettings);
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public uint SettingCount { get; set; }
    public LayerSettingEXT PSettings { get; set; }

    public AdamantiumVulkan.Core.Interop.VkLayerSettingsCreateInfoEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkLayerSettingsCreateInfoEXT();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (SettingCount != default)
        {
            _internal.settingCount = SettingCount;
        }
        _pSettings.Dispose();
        if (PSettings != default)
        {
            var struct0 = PSettings.ToNative();
            _pSettings = new NativeStruct<AdamantiumVulkan.Core.Interop.VkLayerSettingEXT>(struct0);
            _internal.pSettings = _pSettings.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        _pSettings.Dispose();
    }


    public static implicit operator LayerSettingsCreateInfoEXT(AdamantiumVulkan.Core.Interop.VkLayerSettingsCreateInfoEXT l)
    {
        return new LayerSettingsCreateInfoEXT(l);
    }

}


