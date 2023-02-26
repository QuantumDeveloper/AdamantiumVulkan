// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System.Security;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using QuantumBinding.Utils;
using AdamantiumVulkan.Core;

namespace AdamantiumVulkan.Core.Interop;

public unsafe struct PFN_vkGetBufferOpaqueCaptureAddressKHR
{
    public PFN_vkGetBufferOpaqueCaptureAddressKHR(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkBufferDeviceAddressInfo*, ulong>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkBufferDeviceAddressInfo*, ulong> InvokeFunc;

    public void* NativePointer { get; }

    public ulong Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkBufferDeviceAddressInfo* pInfo)
    {
        return InvokeFunc(device, pInfo);
    }
    public static ulong Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkBufferDeviceAddressInfo* pInfo)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkBufferDeviceAddressInfo*, ulong>)ptr)(device, pInfo);
    }

    public static explicit operator PFN_vkGetBufferOpaqueCaptureAddressKHR(void* ptr) => new(ptr);
}


