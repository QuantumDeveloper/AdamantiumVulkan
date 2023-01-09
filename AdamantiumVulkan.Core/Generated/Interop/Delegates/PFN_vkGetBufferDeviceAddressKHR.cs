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

public unsafe struct PFN_vkGetBufferDeviceAddressKHR
{
    public PFN_vkGetBufferDeviceAddressKHR(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkDevice_T, VkBufferDeviceAddressInfo*, ulong>)ptr;
    }

    private delegate* unmanaged<VkDevice_T, VkBufferDeviceAddressInfo*, ulong> InvokeFunc;

    public void* NativePointer { get; }

    public ulong Invoke(VkDevice_T device, VkBufferDeviceAddressInfo* pInfo)
    {
        return InvokeFunc(device, pInfo);
    }
    public static ulong Invoke(void* ptr, VkDevice_T device, VkBufferDeviceAddressInfo* pInfo)
    {
        return ((delegate* unmanaged<VkDevice_T, VkBufferDeviceAddressInfo*, ulong>)ptr)(device, pInfo);
    }

    public static explicit operator PFN_vkGetBufferDeviceAddressKHR(void* ptr) => new(ptr);
}

