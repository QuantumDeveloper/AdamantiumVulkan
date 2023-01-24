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

public unsafe struct PFN_vkGetDeviceImageMemoryRequirements
{
    public PFN_vkGetDeviceImageMemoryRequirements(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkDeviceImageMemoryRequirements*, AdamantiumVulkan.Core.Interop.VkMemoryRequirements2*, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkDeviceImageMemoryRequirements*, AdamantiumVulkan.Core.Interop.VkMemoryRequirements2*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkDeviceImageMemoryRequirements* pInfo, AdamantiumVulkan.Core.Interop.VkMemoryRequirements2* pMemoryRequirements)
    {
         InvokeFunc(device, pInfo, pMemoryRequirements);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkDeviceImageMemoryRequirements* pInfo, AdamantiumVulkan.Core.Interop.VkMemoryRequirements2* pMemoryRequirements)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkDeviceImageMemoryRequirements*, AdamantiumVulkan.Core.Interop.VkMemoryRequirements2*, void>)ptr)(device, pInfo, pMemoryRequirements);
    }

    public static explicit operator PFN_vkGetDeviceImageMemoryRequirements(void* ptr) => new(ptr);
}


