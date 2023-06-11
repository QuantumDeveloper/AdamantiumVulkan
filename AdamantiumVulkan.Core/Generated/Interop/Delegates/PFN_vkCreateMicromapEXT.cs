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

public unsafe struct PFN_vkCreateMicromapEXT
{
    public PFN_vkCreateMicromapEXT(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkMicromapCreateInfoEXT*, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks*, out AdamantiumVulkan.Core.Interop.VkMicromapEXT_T, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkMicromapCreateInfoEXT*, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks*, out AdamantiumVulkan.Core.Interop.VkMicromapEXT_T, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkMicromapCreateInfoEXT* pCreateInfo, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks* pAllocator, out AdamantiumVulkan.Core.Interop.VkMicromapEXT_T pMicromap)
    {
        return InvokeFunc(device, pCreateInfo, pAllocator, out pMicromap);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkMicromapCreateInfoEXT* pCreateInfo, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks* pAllocator, out AdamantiumVulkan.Core.Interop.VkMicromapEXT_T pMicromap)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkMicromapCreateInfoEXT*, AdamantiumVulkan.Core.Interop.VkAllocationCallbacks*, out AdamantiumVulkan.Core.Interop.VkMicromapEXT_T, Result>)ptr)(device, pCreateInfo, pAllocator, out pMicromap);
    }

    public static explicit operator PFN_vkCreateMicromapEXT(void* ptr) => new(ptr);
}

