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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 19548 Column: 26
public unsafe struct PFN_vkGetShaderModuleIdentifierEXT
{
    public PFN_vkGetShaderModuleIdentifierEXT(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkShaderModule_T, AdamantiumVulkan.Core.Interop.VkShaderModuleIdentifierEXT*, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkShaderModule_T, AdamantiumVulkan.Core.Interop.VkShaderModuleIdentifierEXT*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkShaderModule_T shaderModule, AdamantiumVulkan.Core.Interop.VkShaderModuleIdentifierEXT* pIdentifier)
    {
         InvokeFunc(device, shaderModule, pIdentifier);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkShaderModule_T shaderModule, AdamantiumVulkan.Core.Interop.VkShaderModuleIdentifierEXT* pIdentifier)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkShaderModule_T, AdamantiumVulkan.Core.Interop.VkShaderModuleIdentifierEXT*, void>)ptr)(device, shaderModule, pIdentifier);
    }

    public static explicit operator PFN_vkGetShaderModuleIdentifierEXT(void* ptr) => new(ptr);
}


