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

public unsafe partial class DisplayModeProperties2KHR : QBDisposableObject
{
    public DisplayModeProperties2KHR()
    {
    }

    public DisplayModeProperties2KHR(AdamantiumVulkan.Core.Interop.VkDisplayModeProperties2KHR _internal)
    {
        PNext = _internal.pNext;
        DisplayModeProperties = new DisplayModePropertiesKHR(_internal.displayModeProperties);
    }

    public StructureType SType => StructureType.DisplayModeProperties2Khr;
    public void* PNext { get; set; }
    public DisplayModePropertiesKHR DisplayModeProperties { get; set; }

    public AdamantiumVulkan.Core.Interop.VkDisplayModeProperties2KHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkDisplayModeProperties2KHR();
        _internal.sType = SType;
        _internal.pNext = PNext;
        if (DisplayModeProperties != null)
        {
            _internal.displayModeProperties = DisplayModeProperties.ToNative();
        }
        return _internal;
    }

    public static implicit operator DisplayModeProperties2KHR(AdamantiumVulkan.Core.Interop.VkDisplayModeProperties2KHR d)
    {
        return new DisplayModeProperties2KHR(d);
    }

}



