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

public unsafe struct PFN_vkGetMemoryRemoteAddressNV
{
    public PFN_vkGetMemoryRemoteAddressNV(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkMemoryGetRemoteAddressInfoNV*, out AdamantiumVulkan.Core.Interop.VkRemoteAddressNVImpl, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkMemoryGetRemoteAddressInfoNV*, out AdamantiumVulkan.Core.Interop.VkRemoteAddressNVImpl, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkMemoryGetRemoteAddressInfoNV* pMemoryGetRemoteAddressInfo, out AdamantiumVulkan.Core.Interop.VkRemoteAddressNVImpl pAddress)
    {
        return InvokeFunc(device, pMemoryGetRemoteAddressInfo, out pAddress);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkMemoryGetRemoteAddressInfoNV* pMemoryGetRemoteAddressInfo, out AdamantiumVulkan.Core.Interop.VkRemoteAddressNVImpl pAddress)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkMemoryGetRemoteAddressInfoNV*, out AdamantiumVulkan.Core.Interop.VkRemoteAddressNVImpl, Result>)ptr)(device, pMemoryGetRemoteAddressInfo, out pAddress);
    }

    public static explicit operator PFN_vkGetMemoryRemoteAddressNV(void* ptr) => new(ptr);
}


