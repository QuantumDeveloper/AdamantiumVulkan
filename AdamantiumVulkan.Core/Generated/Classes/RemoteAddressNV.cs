// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using QuantumBinding.Utils;
using AdamantiumVulkan.Core.Interop;

namespace AdamantiumVulkan.Core;

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 18037 Column: 15
public unsafe partial class RemoteAddressNV
{
    internal VkRemoteAddressNVImpl __Instance;
    public RemoteAddressNV()
    {
    }

    public RemoteAddressNV(AdamantiumVulkan.Core.Interop.VkRemoteAddressNVImpl __Instance)
    {
        this.__Instance = __Instance;
    }

    public ref readonly VkRemoteAddressNVImpl GetPinnableReference() => ref __Instance;

    public static implicit operator AdamantiumVulkan.Core.Interop.VkRemoteAddressNVImpl(RemoteAddressNV r)
    {
        return r?.__Instance ?? new AdamantiumVulkan.Core.Interop.VkRemoteAddressNVImpl();
    }

    public static implicit operator RemoteAddressNV(AdamantiumVulkan.Core.Interop.VkRemoteAddressNVImpl r)
    {
        return new RemoteAddressNV(r);
    }

}



