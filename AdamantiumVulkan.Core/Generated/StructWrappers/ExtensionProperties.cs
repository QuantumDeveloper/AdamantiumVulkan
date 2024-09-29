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

public unsafe partial class ExtensionProperties : QBDisposableObject
{
    public ExtensionProperties()
    {
    }

    public ExtensionProperties(AdamantiumVulkan.Core.Interop.VkExtensionProperties _internal)
    {
        ExtensionName = new string((sbyte*)_internal.extensionName);
        SpecVersion = _internal.specVersion;
    }

    public string ExtensionName { get; set; }
    public uint SpecVersion { get; set; }

    public AdamantiumVulkan.Core.Interop.VkExtensionProperties ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkExtensionProperties();
        if (ExtensionName != default)
        {
            if (ExtensionName.Length > 256)
                throw new System.ArgumentOutOfRangeException(nameof(ExtensionName), "Array is out of bounds. Size should not be more than 256");

            NativeUtils.StringToFixedArray(_internal.extensionName, 256, ExtensionName, false);
        }
        if (SpecVersion != default)
        {
            _internal.specVersion = SpecVersion;
        }
        return _internal;
    }

    public static implicit operator ExtensionProperties(AdamantiumVulkan.Core.Interop.VkExtensionProperties e)
    {
        return new ExtensionProperties(e);
    }

}



