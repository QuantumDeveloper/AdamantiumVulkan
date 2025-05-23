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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 11147 Column: 26
public unsafe struct PFN_vkCmdSetFragmentShadingRateKHR
{
    public PFN_vkCmdSetFragmentShadingRateKHR(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, AdamantiumVulkan.Core.Interop.VkExtent2D*, FragmentShadingRateCombinerOpKHR[], void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, AdamantiumVulkan.Core.Interop.VkExtent2D*, FragmentShadingRateCombinerOpKHR[], void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, AdamantiumVulkan.Core.Interop.VkExtent2D* pFragmentSize, FragmentShadingRateCombinerOpKHR[] combinerOps)
    {
         InvokeFunc(commandBuffer, pFragmentSize, combinerOps);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, AdamantiumVulkan.Core.Interop.VkExtent2D* pFragmentSize, FragmentShadingRateCombinerOpKHR[] combinerOps)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, AdamantiumVulkan.Core.Interop.VkExtent2D*, FragmentShadingRateCombinerOpKHR[], void>)ptr)(commandBuffer, pFragmentSize, combinerOps);
    }

    public static explicit operator PFN_vkCmdSetFragmentShadingRateKHR(void* ptr) => new(ptr);
}


