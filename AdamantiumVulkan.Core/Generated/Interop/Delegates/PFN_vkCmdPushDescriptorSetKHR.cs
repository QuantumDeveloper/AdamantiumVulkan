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

public unsafe struct PFN_vkCmdPushDescriptorSetKHR
{
    public PFN_vkCmdPushDescriptorSetKHR(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkCommandBuffer_T, PipelineBindPoint, VkPipelineLayout_T, uint, uint, VkWriteDescriptorSet*, void>)ptr;
    }

    private delegate* unmanaged<VkCommandBuffer_T, PipelineBindPoint, VkPipelineLayout_T, uint, uint, VkWriteDescriptorSet*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(VkCommandBuffer_T commandBuffer, PipelineBindPoint pipelineBindPoint, VkPipelineLayout_T layout, uint set, uint descriptorWriteCount, VkWriteDescriptorSet* pDescriptorWrites)
    {
         InvokeFunc(commandBuffer, pipelineBindPoint, layout, set, descriptorWriteCount, pDescriptorWrites);
    }
    public static void Invoke(void* ptr, VkCommandBuffer_T commandBuffer, PipelineBindPoint pipelineBindPoint, VkPipelineLayout_T layout, uint set, uint descriptorWriteCount, VkWriteDescriptorSet* pDescriptorWrites)
    {
         ((delegate* unmanaged<VkCommandBuffer_T, PipelineBindPoint, VkPipelineLayout_T, uint, uint, VkWriteDescriptorSet*, void>)ptr)(commandBuffer, pipelineBindPoint, layout, set, descriptorWriteCount, pDescriptorWrites);
    }

    public static explicit operator PFN_vkCmdPushDescriptorSetKHR(void* ptr) => new(ptr);
}


