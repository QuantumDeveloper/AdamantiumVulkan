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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 21167 Column: 26
public unsafe struct PFN_vkUpdateIndirectExecutionSetShaderEXT
{
    public PFN_vkUpdateIndirectExecutionSetShaderEXT(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkIndirectExecutionSetEXT_T, uint, AdamantiumVulkan.Core.Interop.VkWriteIndirectExecutionSetShaderEXT*, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkIndirectExecutionSetEXT_T, uint, AdamantiumVulkan.Core.Interop.VkWriteIndirectExecutionSetShaderEXT*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkIndirectExecutionSetEXT_T indirectExecutionSet, uint executionSetWriteCount, AdamantiumVulkan.Core.Interop.VkWriteIndirectExecutionSetShaderEXT* pExecutionSetWrites)
    {
         InvokeFunc(device, indirectExecutionSet, executionSetWriteCount, pExecutionSetWrites);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkIndirectExecutionSetEXT_T indirectExecutionSet, uint executionSetWriteCount, AdamantiumVulkan.Core.Interop.VkWriteIndirectExecutionSetShaderEXT* pExecutionSetWrites)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkIndirectExecutionSetEXT_T, uint, AdamantiumVulkan.Core.Interop.VkWriteIndirectExecutionSetShaderEXT*, void>)ptr)(device, indirectExecutionSet, executionSetWriteCount, pExecutionSetWrites);
    }

    public static explicit operator PFN_vkUpdateIndirectExecutionSetShaderEXT(void* ptr) => new(ptr);
}


