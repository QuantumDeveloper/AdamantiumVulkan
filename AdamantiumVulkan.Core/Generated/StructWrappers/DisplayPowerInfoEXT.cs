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

public unsafe partial class DisplayPowerInfoEXT : QBDisposableObject
{
    public DisplayPowerInfoEXT()
    {
    }

    public DisplayPowerInfoEXT(AdamantiumVulkan.Core.Interop.VkDisplayPowerInfoEXT _internal)
    {
        PNext = _internal.pNext;
        PowerState = _internal.powerState;
    }

    public StructureType SType => StructureType.DisplayPowerInfoExt;
    public void* PNext { get; set; }
    public DisplayPowerStateEXT PowerState { get; set; }

    public AdamantiumVulkan.Core.Interop.VkDisplayPowerInfoEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkDisplayPowerInfoEXT();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.powerState = PowerState;
        return _internal;
    }

    public static implicit operator DisplayPowerInfoEXT(AdamantiumVulkan.Core.Interop.VkDisplayPowerInfoEXT d)
    {
        return new DisplayPowerInfoEXT(d);
    }

}



