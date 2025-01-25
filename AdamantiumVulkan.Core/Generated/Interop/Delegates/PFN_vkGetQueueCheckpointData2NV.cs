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

// File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_core.h Line: 15395 Column: 26
public unsafe struct PFN_vkGetQueueCheckpointData2NV
{
    public PFN_vkGetQueueCheckpointData2NV(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkQueue_T, ref uint*, AdamantiumVulkan.Core.Interop.VkCheckpointData2NV*, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkQueue_T, ref uint*, AdamantiumVulkan.Core.Interop.VkCheckpointData2NV*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkQueue_T queue, ref uint* pCheckpointDataCount, AdamantiumVulkan.Core.Interop.VkCheckpointData2NV* pCheckpointData)
    {
         InvokeFunc(queue, ref pCheckpointDataCount, pCheckpointData);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkQueue_T queue, ref uint* pCheckpointDataCount, AdamantiumVulkan.Core.Interop.VkCheckpointData2NV* pCheckpointData)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkQueue_T, ref uint*, AdamantiumVulkan.Core.Interop.VkCheckpointData2NV*, void>)ptr)(queue, ref pCheckpointDataCount, pCheckpointData);
    }

    public static explicit operator PFN_vkGetQueueCheckpointData2NV(void* ptr) => new(ptr);
}


