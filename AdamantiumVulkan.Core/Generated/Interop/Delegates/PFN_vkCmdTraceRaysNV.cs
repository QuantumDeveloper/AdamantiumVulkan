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

public unsafe struct PFN_vkCmdTraceRaysNV
{
    public PFN_vkCmdTraceRaysNV(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, AdamantiumVulkan.Core.Interop.VkBuffer_T, VkDeviceSize, AdamantiumVulkan.Core.Interop.VkBuffer_T, VkDeviceSize, VkDeviceSize, AdamantiumVulkan.Core.Interop.VkBuffer_T, VkDeviceSize, VkDeviceSize, AdamantiumVulkan.Core.Interop.VkBuffer_T, VkDeviceSize, VkDeviceSize, uint, uint, uint, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, AdamantiumVulkan.Core.Interop.VkBuffer_T, VkDeviceSize, AdamantiumVulkan.Core.Interop.VkBuffer_T, VkDeviceSize, VkDeviceSize, AdamantiumVulkan.Core.Interop.VkBuffer_T, VkDeviceSize, VkDeviceSize, AdamantiumVulkan.Core.Interop.VkBuffer_T, VkDeviceSize, VkDeviceSize, uint, uint, uint, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, AdamantiumVulkan.Core.Interop.VkBuffer_T raygenShaderBindingTableBuffer, VkDeviceSize raygenShaderBindingOffset, AdamantiumVulkan.Core.Interop.VkBuffer_T missShaderBindingTableBuffer, VkDeviceSize missShaderBindingOffset, VkDeviceSize missShaderBindingStride, AdamantiumVulkan.Core.Interop.VkBuffer_T hitShaderBindingTableBuffer, VkDeviceSize hitShaderBindingOffset, VkDeviceSize hitShaderBindingStride, AdamantiumVulkan.Core.Interop.VkBuffer_T callableShaderBindingTableBuffer, VkDeviceSize callableShaderBindingOffset, VkDeviceSize callableShaderBindingStride, uint width, uint height, uint depth)
    {
         InvokeFunc(commandBuffer, raygenShaderBindingTableBuffer, raygenShaderBindingOffset, missShaderBindingTableBuffer, missShaderBindingOffset, missShaderBindingStride, hitShaderBindingTableBuffer, hitShaderBindingOffset, hitShaderBindingStride, callableShaderBindingTableBuffer, callableShaderBindingOffset, callableShaderBindingStride, width, height, depth);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, AdamantiumVulkan.Core.Interop.VkBuffer_T raygenShaderBindingTableBuffer, VkDeviceSize raygenShaderBindingOffset, AdamantiumVulkan.Core.Interop.VkBuffer_T missShaderBindingTableBuffer, VkDeviceSize missShaderBindingOffset, VkDeviceSize missShaderBindingStride, AdamantiumVulkan.Core.Interop.VkBuffer_T hitShaderBindingTableBuffer, VkDeviceSize hitShaderBindingOffset, VkDeviceSize hitShaderBindingStride, AdamantiumVulkan.Core.Interop.VkBuffer_T callableShaderBindingTableBuffer, VkDeviceSize callableShaderBindingOffset, VkDeviceSize callableShaderBindingStride, uint width, uint height, uint depth)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, AdamantiumVulkan.Core.Interop.VkBuffer_T, VkDeviceSize, AdamantiumVulkan.Core.Interop.VkBuffer_T, VkDeviceSize, VkDeviceSize, AdamantiumVulkan.Core.Interop.VkBuffer_T, VkDeviceSize, VkDeviceSize, AdamantiumVulkan.Core.Interop.VkBuffer_T, VkDeviceSize, VkDeviceSize, uint, uint, uint, void>)ptr)(commandBuffer, raygenShaderBindingTableBuffer, raygenShaderBindingOffset, missShaderBindingTableBuffer, missShaderBindingOffset, missShaderBindingStride, hitShaderBindingTableBuffer, hitShaderBindingOffset, hitShaderBindingStride, callableShaderBindingTableBuffer, callableShaderBindingOffset, callableShaderBindingStride, width, height, depth);
    }

    public static explicit operator PFN_vkCmdTraceRaysNV(void* ptr) => new(ptr);
}


