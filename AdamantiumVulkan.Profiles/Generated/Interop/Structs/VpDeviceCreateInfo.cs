// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AdamantiumVulkan.Core.Interop;

namespace AdamantiumVulkan.Profiles.Interop;

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VpDeviceCreateInfo
{
    public VkDeviceCreateInfo* pCreateInfo;
    public VpProfileProperties* pProfile;
    public VpDeviceCreateFlags flags;
}



