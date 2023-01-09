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

public unsafe struct PFN_vkGetGeneratedCommandsMemoryRequirementsNV
{
    public PFN_vkGetGeneratedCommandsMemoryRequirementsNV(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkDevice_T, VkGeneratedCommandsMemoryRequirementsInfoNV*, VkMemoryRequirements2*, void>)ptr;
    }

    private delegate* unmanaged<VkDevice_T, VkGeneratedCommandsMemoryRequirementsInfoNV*, VkMemoryRequirements2*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(VkDevice_T device, VkGeneratedCommandsMemoryRequirementsInfoNV* pInfo, VkMemoryRequirements2* pMemoryRequirements)
    {
         InvokeFunc(device, pInfo, pMemoryRequirements);
    }
    public static void Invoke(void* ptr, VkDevice_T device, VkGeneratedCommandsMemoryRequirementsInfoNV* pInfo, VkMemoryRequirements2* pMemoryRequirements)
    {
         ((delegate* unmanaged<VkDevice_T, VkGeneratedCommandsMemoryRequirementsInfoNV*, VkMemoryRequirements2*, void>)ptr)(device, pInfo, pMemoryRequirements);
    }

    public static explicit operator PFN_vkGetGeneratedCommandsMemoryRequirementsNV(void* ptr) => new(ptr);
}


