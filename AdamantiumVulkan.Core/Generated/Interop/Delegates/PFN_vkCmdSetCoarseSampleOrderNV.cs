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

public unsafe struct PFN_vkCmdSetCoarseSampleOrderNV
{
    public PFN_vkCmdSetCoarseSampleOrderNV(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkCommandBuffer_T, CoarseSampleOrderTypeNV, uint, VkCoarseSampleOrderCustomNV*, void>)ptr;
    }

    private delegate* unmanaged<VkCommandBuffer_T, CoarseSampleOrderTypeNV, uint, VkCoarseSampleOrderCustomNV*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(VkCommandBuffer_T commandBuffer, CoarseSampleOrderTypeNV sampleOrderType, uint customSampleOrderCount, VkCoarseSampleOrderCustomNV* pCustomSampleOrders)
    {
         InvokeFunc(commandBuffer, sampleOrderType, customSampleOrderCount, pCustomSampleOrders);
    }
    public static void Invoke(void* ptr, VkCommandBuffer_T commandBuffer, CoarseSampleOrderTypeNV sampleOrderType, uint customSampleOrderCount, VkCoarseSampleOrderCustomNV* pCustomSampleOrders)
    {
         ((delegate* unmanaged<VkCommandBuffer_T, CoarseSampleOrderTypeNV, uint, VkCoarseSampleOrderCustomNV*, void>)ptr)(commandBuffer, sampleOrderType, customSampleOrderCount, pCustomSampleOrders);
    }

    public static explicit operator PFN_vkCmdSetCoarseSampleOrderNV(void* ptr) => new(ptr);
}


