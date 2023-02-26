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

public unsafe partial class DisplayModePropertiesKHR
{
    public DisplayModePropertiesKHR()
    {
    }

    public DisplayModePropertiesKHR(AdamantiumVulkan.Core.Interop.VkDisplayModePropertiesKHR _internal)
    {
        DisplayMode = new DisplayModeKHR(_internal.displayMode);
        Parameters = new DisplayModeParametersKHR(_internal.parameters);
    }

    public DisplayModeKHR DisplayMode { get; set; }
    public DisplayModeParametersKHR Parameters { get; set; }

    public AdamantiumVulkan.Core.Interop.VkDisplayModePropertiesKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkDisplayModePropertiesKHR();
        _internal.displayMode = DisplayMode;
        if (Parameters != null)
        {
            _internal.parameters = Parameters.ToNative();
        }
        return _internal;
    }

    public static implicit operator DisplayModePropertiesKHR(AdamantiumVulkan.Core.Interop.VkDisplayModePropertiesKHR d)
    {
        return new DisplayModePropertiesKHR(d);
    }

}



