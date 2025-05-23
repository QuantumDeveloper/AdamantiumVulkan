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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 4278 Column: 26
public unsafe struct PFN_vkCmdWaitEvents
{
    public PFN_vkCmdWaitEvents(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, uint, AdamantiumVulkan.Core.Interop.VkEvent_T*, VkPipelineStageFlags, VkPipelineStageFlags, uint, AdamantiumVulkan.Core.Interop.VkMemoryBarrier*, uint, AdamantiumVulkan.Core.Interop.VkBufferMemoryBarrier*, uint, AdamantiumVulkan.Core.Interop.VkImageMemoryBarrier*, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, uint, AdamantiumVulkan.Core.Interop.VkEvent_T*, VkPipelineStageFlags, VkPipelineStageFlags, uint, AdamantiumVulkan.Core.Interop.VkMemoryBarrier*, uint, AdamantiumVulkan.Core.Interop.VkBufferMemoryBarrier*, uint, AdamantiumVulkan.Core.Interop.VkImageMemoryBarrier*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, uint eventCount, AdamantiumVulkan.Core.Interop.VkEvent_T* pEvents, VkPipelineStageFlags srcStageMask, VkPipelineStageFlags dstStageMask, uint memoryBarrierCount, AdamantiumVulkan.Core.Interop.VkMemoryBarrier* pMemoryBarriers, uint bufferMemoryBarrierCount, AdamantiumVulkan.Core.Interop.VkBufferMemoryBarrier* pBufferMemoryBarriers, uint imageMemoryBarrierCount, AdamantiumVulkan.Core.Interop.VkImageMemoryBarrier* pImageMemoryBarriers)
    {
         InvokeFunc(commandBuffer, eventCount, pEvents, srcStageMask, dstStageMask, memoryBarrierCount, pMemoryBarriers, bufferMemoryBarrierCount, pBufferMemoryBarriers, imageMemoryBarrierCount, pImageMemoryBarriers);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkCommandBuffer_T commandBuffer, uint eventCount, AdamantiumVulkan.Core.Interop.VkEvent_T* pEvents, VkPipelineStageFlags srcStageMask, VkPipelineStageFlags dstStageMask, uint memoryBarrierCount, AdamantiumVulkan.Core.Interop.VkMemoryBarrier* pMemoryBarriers, uint bufferMemoryBarrierCount, AdamantiumVulkan.Core.Interop.VkBufferMemoryBarrier* pBufferMemoryBarriers, uint imageMemoryBarrierCount, AdamantiumVulkan.Core.Interop.VkImageMemoryBarrier* pImageMemoryBarriers)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkCommandBuffer_T, uint, AdamantiumVulkan.Core.Interop.VkEvent_T*, VkPipelineStageFlags, VkPipelineStageFlags, uint, AdamantiumVulkan.Core.Interop.VkMemoryBarrier*, uint, AdamantiumVulkan.Core.Interop.VkBufferMemoryBarrier*, uint, AdamantiumVulkan.Core.Interop.VkImageMemoryBarrier*, void>)ptr)(commandBuffer, eventCount, pEvents, srcStageMask, dstStageMask, memoryBarrierCount, pMemoryBarriers, bufferMemoryBarrierCount, pBufferMemoryBarriers, imageMemoryBarrierCount, pImageMemoryBarriers);
    }

    public static explicit operator PFN_vkCmdWaitEvents(void* ptr) => new(ptr);
}


