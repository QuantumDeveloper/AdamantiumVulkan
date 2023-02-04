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

public unsafe partial class DisplayPropertiesKHR : QBDisposableObject
{
    private MarshaledString _displayName;

    public DisplayPropertiesKHR()
    {
    }

    public DisplayPropertiesKHR(AdamantiumVulkan.Core.Interop.VkDisplayPropertiesKHR _internal)
    {
        Display = new DisplayKHR(_internal.display);
        DisplayName = new string(_internal.displayName);
        PhysicalDimensions = new Extent2D(_internal.physicalDimensions);
        PhysicalResolution = new Extent2D(_internal.physicalResolution);
        SupportedTransforms = _internal.supportedTransforms;
        PlaneReorderPossible = _internal.planeReorderPossible;
        PersistentContent = _internal.persistentContent;
    }

    public DisplayKHR Display { get; set; }
    public string DisplayName { get; set; }
    public Extent2D PhysicalDimensions { get; set; }
    public Extent2D PhysicalResolution { get; set; }
    public VkSurfaceTransformFlagsKHR SupportedTransforms { get; set; }
    public VkBool32 PlaneReorderPossible { get; set; }
    public VkBool32 PersistentContent { get; set; }

    public AdamantiumVulkan.Core.Interop.VkDisplayPropertiesKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkDisplayPropertiesKHR();
        _internal.display = Display;
        _displayName.Dispose();
        if (DisplayName != null)
        {
            _displayName = new MarshaledString(DisplayName, false);
            _internal.displayName = (sbyte*)_displayName;
        }
        if (PhysicalDimensions != null)
        {
            _internal.physicalDimensions = PhysicalDimensions.ToNative();
        }
        if (PhysicalResolution != null)
        {
            _internal.physicalResolution = PhysicalResolution.ToNative();
        }
        _internal.supportedTransforms = SupportedTransforms;
        _internal.planeReorderPossible = PlaneReorderPossible;
        _internal.persistentContent = PersistentContent;
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        _displayName.Dispose();
    }


    public static implicit operator DisplayPropertiesKHR(AdamantiumVulkan.Core.Interop.VkDisplayPropertiesKHR d)
    {
        return new DisplayPropertiesKHR(d);
    }

}



