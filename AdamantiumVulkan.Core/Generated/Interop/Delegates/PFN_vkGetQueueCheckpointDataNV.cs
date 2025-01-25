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

// File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_core.h Line: 15394 Column: 26
public unsafe struct PFN_vkGetQueueCheckpointDataNV
{
    public PFN_vkGetQueueCheckpointDataNV(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkQueue_T, ref uint*, AdamantiumVulkan.Core.Interop.VkCheckpointDataNV*, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkQueue_T, ref uint*, AdamantiumVulkan.Core.Interop.VkCheckpointDataNV*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkQueue_T queue, ref uint* pCheckpointDataCount, AdamantiumVulkan.Core.Interop.VkCheckpointDataNV* pCheckpointData)
    {
         InvokeFunc(queue, ref pCheckpointDataCount, pCheckpointData);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkQueue_T queue, ref uint* pCheckpointDataCount, AdamantiumVulkan.Core.Interop.VkCheckpointDataNV* pCheckpointData)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkQueue_T, ref uint*, AdamantiumVulkan.Core.Interop.VkCheckpointDataNV*, void>)ptr)(queue, ref pCheckpointDataCount, pCheckpointData);
    }

    public static explicit operator PFN_vkGetQueueCheckpointDataNV(void* ptr) => new(ptr);
}


