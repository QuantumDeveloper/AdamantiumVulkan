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

public unsafe struct PFN_vkGetImageMemoryRequirements
{
    public PFN_vkGetImageMemoryRequirements(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkImage_T, AdamantiumVulkan.Core.Interop.VkMemoryRequirements*, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkImage_T, AdamantiumVulkan.Core.Interop.VkMemoryRequirements*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkImage_T image, AdamantiumVulkan.Core.Interop.VkMemoryRequirements* pMemoryRequirements)
    {
         InvokeFunc(device, image, pMemoryRequirements);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkImage_T image, AdamantiumVulkan.Core.Interop.VkMemoryRequirements* pMemoryRequirements)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkImage_T, AdamantiumVulkan.Core.Interop.VkMemoryRequirements*, void>)ptr)(device, image, pMemoryRequirements);
    }

    public static explicit operator PFN_vkGetImageMemoryRequirements(void* ptr) => new(ptr);
}


