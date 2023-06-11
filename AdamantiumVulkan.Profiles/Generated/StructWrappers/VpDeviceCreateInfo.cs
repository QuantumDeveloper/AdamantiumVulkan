// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System.Runtime.InteropServices;
using QuantumBinding.Utils;
using AdamantiumVulkan.Profiles.Interop;
using AdamantiumVulkan.Core;
using AdamantiumVulkan.Core.Interop;

namespace AdamantiumVulkan.Profiles;

public unsafe partial class VpDeviceCreateInfo : QBDisposableObject
{
    private NativeStruct<AdamantiumVulkan.Core.Interop.VkDeviceCreateInfo> _pCreateInfo;

    private NativeStruct<AdamantiumVulkan.Profiles.Interop.VpProfileProperties> _pProfile;

    public VpDeviceCreateInfo()
    {
    }

    public VpDeviceCreateInfo(AdamantiumVulkan.Profiles.Interop.VpDeviceCreateInfo _internal)
    {
        PCreateInfo = new DeviceCreateInfo(*_internal.pCreateInfo);
        NativeUtils.Free(_internal.pCreateInfo);
        Profile = new VpProfileProperties(*_internal.pProfile);
        NativeUtils.Free(_internal.pProfile);
        Flags = _internal.flags;
    }

    public DeviceCreateInfo PCreateInfo { get; set; }
    public VpProfileProperties Profile { get; set; }
    public VpDeviceCreateFlags Flags { get; set; }

    public AdamantiumVulkan.Profiles.Interop.VpDeviceCreateInfo ToNative()
    {
        var _internal = new AdamantiumVulkan.Profiles.Interop.VpDeviceCreateInfo();
        _pCreateInfo.Dispose();
        if (PCreateInfo != null)
        {
            var struct0 = PCreateInfo.ToNative();
            _pCreateInfo = new NativeStruct<AdamantiumVulkan.Core.Interop.VkDeviceCreateInfo>(struct0);
            _internal.pCreateInfo = _pCreateInfo.Handle;
        }
        _pProfile.Dispose();
        if (Profile != null)
        {
            var struct1 = Profile.ToNative();
            _pProfile = new NativeStruct<AdamantiumVulkan.Profiles.Interop.VpProfileProperties>(struct1);
            _internal.pProfile = _pProfile.Handle;
        }
        _internal.flags = Flags;
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        _pCreateInfo.Dispose();
        _pProfile.Dispose();
    }


    public static implicit operator VpDeviceCreateInfo(AdamantiumVulkan.Profiles.Interop.VpDeviceCreateInfo v)
    {
        return new VpDeviceCreateInfo(v);
    }

}


