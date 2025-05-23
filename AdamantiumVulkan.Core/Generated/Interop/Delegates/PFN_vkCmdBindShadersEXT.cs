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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 19872 Column: 26
public unsafe struct PFN_vkCmdBindShadersEXT
{
    public PFN_vkCmdBindShadersEXT(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, uint, ShaderStageFlagBits*, AdamantiumVulkan.Core.Interop.VkShaderEXT_T*, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, uint, ShaderStageFlagBits*, AdamantiumVulkan.Core.Interop.VkShaderEXT_T*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, uint stageCount, ShaderStageFlagBits* pStages, AdamantiumVulkan.Core.Interop.VkShaderEXT_T* pShaders)
    {
         InvokeFunc(commandBuffer, stageCount, pStages, pShaders);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, uint stageCount, ShaderStageFlagBits* pStages, AdamantiumVulkan.Core.Interop.VkShaderEXT_T* pShaders)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, uint, ShaderStageFlagBits*, AdamantiumVulkan.Core.Interop.VkShaderEXT_T*, void>)ptr)(commandBuffer, stageCount, pStages, pShaders);
    }

    public static explicit operator PFN_vkCmdBindShadersEXT(void* ptr) => new(ptr);
}


