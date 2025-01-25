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

// File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_core.h Line: 21097 Column: 26
public unsafe struct PFN_vkCmdTraceRaysIndirectKHR
{
    public PFN_vkCmdTraceRaysIndirectKHR(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, AdamantiumVulkan.Core.Interop.VkStridedDeviceAddressRegionKHR*, AdamantiumVulkan.Core.Interop.VkStridedDeviceAddressRegionKHR*, AdamantiumVulkan.Core.Interop.VkStridedDeviceAddressRegionKHR*, AdamantiumVulkan.Core.Interop.VkStridedDeviceAddressRegionKHR*, VkDeviceAddress, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, AdamantiumVulkan.Core.Interop.VkStridedDeviceAddressRegionKHR*, AdamantiumVulkan.Core.Interop.VkStridedDeviceAddressRegionKHR*, AdamantiumVulkan.Core.Interop.VkStridedDeviceAddressRegionKHR*, AdamantiumVulkan.Core.Interop.VkStridedDeviceAddressRegionKHR*, VkDeviceAddress, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, AdamantiumVulkan.Core.Interop.VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, AdamantiumVulkan.Core.Interop.VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, AdamantiumVulkan.Core.Interop.VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, AdamantiumVulkan.Core.Interop.VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, VkDeviceAddress indirectDeviceAddress)
    {
         InvokeFunc(commandBuffer, pRaygenShaderBindingTable, pMissShaderBindingTable, pHitShaderBindingTable, pCallableShaderBindingTable, indirectDeviceAddress);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, AdamantiumVulkan.Core.Interop.VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable, AdamantiumVulkan.Core.Interop.VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable, AdamantiumVulkan.Core.Interop.VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable, AdamantiumVulkan.Core.Interop.VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable, VkDeviceAddress indirectDeviceAddress)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, AdamantiumVulkan.Core.Interop.VkStridedDeviceAddressRegionKHR*, AdamantiumVulkan.Core.Interop.VkStridedDeviceAddressRegionKHR*, AdamantiumVulkan.Core.Interop.VkStridedDeviceAddressRegionKHR*, AdamantiumVulkan.Core.Interop.VkStridedDeviceAddressRegionKHR*, VkDeviceAddress, void>)ptr)(commandBuffer, pRaygenShaderBindingTable, pMissShaderBindingTable, pHitShaderBindingTable, pCallableShaderBindingTable, indirectDeviceAddress);
    }

    public static explicit operator PFN_vkCmdTraceRaysIndirectKHR(void* ptr) => new(ptr);
}


