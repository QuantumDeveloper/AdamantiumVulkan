// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System.Runtime.InteropServices;
using QuantumBinding.Utils;
using AdamantiumVulkan.Profiles.Interop;

namespace AdamantiumVulkan.Profiles;

public unsafe partial class VpProfileProperties
{
    public VpProfileProperties()
    {
    }

    public VpProfileProperties(AdamantiumVulkan.Profiles.Interop.VpProfileProperties _internal)
    {
        ProfileName = new string((sbyte*)_internal.profileName);
        SpecVersion = _internal.specVersion;
    }

    public string ProfileName { get; set; }
    public uint SpecVersion { get; set; }

    public AdamantiumVulkan.Profiles.Interop.VpProfileProperties ToNative()
    {
        var _internal = new AdamantiumVulkan.Profiles.Interop.VpProfileProperties();
        if(ProfileName != null)
        {
            if (ProfileName.Length > 256)
                throw new System.ArgumentOutOfRangeException(nameof(ProfileName), "Array is out of bounds. Size should not be more than 256");

            NativeUtils.StringToFixedArray(_internal.profileName, 256, ProfileName, false);
        }
        _internal.specVersion = SpecVersion;
        return _internal;
    }

    public static implicit operator VpProfileProperties(AdamantiumVulkan.Profiles.Interop.VpProfileProperties v)
    {
        return new VpProfileProperties(v);
    }

}


