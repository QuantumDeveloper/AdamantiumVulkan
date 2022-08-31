using System;
using System.Collections.Generic;
using QuantumBinding.Generator;
using QuantumBinding.Generator.AST;
using QuantumBinding.Generator.ProcessingFluentApi;
using QuantumBinding.Generator.Processors;
using QuantumBinding.Generator.Types;

namespace AdamantiumVulkan.Generator;

public class VulkanBindings
{
    public static List<StructurePredefinedInput> GetStructuresPredefinedValues()
    {
        var predefinedValues = new List<StructurePredefinedInput>();

        var values = new StructurePredefinedInput() { StructType = "VkApplicationInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.ApplicationInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkInstanceCreateInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.InstanceCreateInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkDeviceQueueCreateInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.DeviceQueueCreateInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkDeviceCreateInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.DeviceCreateInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkSubmitInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput() { Value = "StructureType.SubmitInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkMemoryAllocateInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.MemoryAllocateInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkMappedMemoryRange" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.MappedMemoryRange", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkBindSparseInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.BindSparseInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkFenceCreateInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.FenceCreateInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkSemaphoreCreateInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.SemaphoreCreateInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkEventCreateInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.EventCreateInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkQueryPoolCreateInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.QueryPoolCreateInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkBufferCreateInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.BufferCreateInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkBufferViewCreateInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.BufferViewCreateInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkImageCreateInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.ImageCreateInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkImageViewCreateInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.ImageViewCreateInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkShaderModuleCreateInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.ShaderModuleCreateInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPipelineCacheCreateInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PipelineCacheCreateInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPipelineShaderStageCreateInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PipelineShaderStageCreateInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPipelineVertexInputStateCreateInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PipelineVertexInputStateCreateInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPipelineInputAssemblyStateCreateInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PipelineInputAssemblyStateCreateInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPipelineTessellationStateCreateInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PipelineTessellationStateCreateInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPipelineViewportStateCreateInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PipelineViewportStateCreateInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPipelineRasterizationStateCreateInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PipelineRasterizationStateCreateInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPipelineMultisampleStateCreateInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PipelineMultisampleStateCreateInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPipelineDepthStencilStateCreateInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PipelineDepthStencilStateCreateInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPipelineColorBlendStateCreateInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PipelineColorBlendStateCreateInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPipelineDynamicStateCreateInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PipelineDynamicStateCreateInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkGraphicsPipelineCreateInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.GraphicsPipelineCreateInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkComputePipelineCreateInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.ComputePipelineCreateInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPipelineLayoutCreateInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PipelineLayoutCreateInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkSamplerCreateInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.SamplerCreateInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkDescriptorSetLayoutCreateInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.DescriptorSetLayoutCreateInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkDescriptorPoolCreateInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.DescriptorPoolCreateInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkDescriptorSetAllocateInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.DescriptorSetAllocateInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkWriteDescriptorSet" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.WriteDescriptorSet", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkCopyDescriptorSet" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.CopyDescriptorSet", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkFramebufferCreateInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.FramebufferCreateInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkRenderPassCreateInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.RenderPassCreateInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkCommandPoolCreateInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.CommandPoolCreateInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkCommandBufferAllocateInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.CommandBufferAllocateInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkCommandBufferInheritanceInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.CommandBufferInheritanceInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkCommandBufferBeginInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.CommandBufferBeginInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkMemoryBarrier" };
        values.FieldValues["sType"] = new PredefinedFieldInput() { Value = "StructureType.MemoryBarrier", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkBufferMemoryBarrier" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.BufferMemoryBarrier", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkImageMemoryBarrier" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.ImageMemoryBarrier", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkRenderPassBeginInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.RenderPassBeginInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceSubgroupProperties" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceSubgroupProperties", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkBindBufferMemoryInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.BindBufferMemoryInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkBindImageMemoryInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.BindImageMemoryInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDevice16BitStorageFeatures" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDevice16bitStorageFeatures", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkMemoryDedicatedRequirements" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.MemoryDedicatedRequirements", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkMemoryDedicatedAllocateInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.MemoryDedicatedAllocateInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkMemoryAllocateFlagsInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.MemoryAllocateFlagsInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkDeviceGroupRenderPassBeginInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.DeviceGroupRenderPassBeginInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkDeviceGroupCommandBufferBeginInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.DeviceGroupCommandBufferBeginInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkDeviceGroupSubmitInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.DeviceGroupSubmitInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkDeviceGroupBindSparseInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.DeviceGroupBindSparseInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkBindBufferMemoryDeviceGroupInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.BindBufferMemoryDeviceGroupInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkBindImageMemoryDeviceGroupInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.BindImageMemoryDeviceGroupInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceGroupProperties" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceGroupProperties", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkDeviceGroupDeviceCreateInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.DeviceGroupDeviceCreateInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkBufferMemoryRequirementsInfo2" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.BufferMemoryRequirementsInfo2", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkImageMemoryRequirementsInfo2" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.ImageMemoryRequirementsInfo2", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkImageSparseMemoryRequirementsInfo2" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.ImageSparseMemoryRequirementsInfo2", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkMemoryRequirements2" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.MemoryRequirements2", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkSparseImageMemoryRequirements2" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.SparseImageMemoryRequirements2", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceFeatures2" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceFeatures2", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceProperties2" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceProperties2", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkFormatProperties2" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.FormatProperties2", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkImageFormatProperties2" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.ImageFormatProperties2", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceImageFormatInfo2" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceImageFormatInfo2", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkQueueFamilyProperties2" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.QueueFamilyProperties2", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceMemoryProperties2" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceMemoryProperties2", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkSparseImageFormatProperties2" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.SparseImageFormatProperties2", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceSparseImageFormatInfo2" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceSparseImageFormatInfo2", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDevicePointClippingProperties" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDevicePointClippingProperties", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkRenderPassInputAttachmentAspectCreateInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.RenderPassInputAttachmentAspectCreateInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkImageViewUsageCreateInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.ImageViewUsageCreateInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPipelineTessellationDomainOriginStateCreateInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PipelineTessellationDomainOriginStateCreateInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkRenderPassMultiviewCreateInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.RenderPassMultiviewCreateInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceMultiviewFeatures" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceMultiviewFeatures", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceMultiviewProperties" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceMultiviewProperties", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceVariablePointersFeatures" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceVariablePointersFeatures", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceProtectedMemoryFeatures" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceProtectedMemoryFeatures", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceProtectedMemoryProperties" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceProtectedMemoryProperties", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkDeviceQueueInfo2" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.DeviceQueueInfo2", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkProtectedSubmitInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.ProtectedSubmitInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkSamplerYcbcrConversionCreateInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.SamplerYcbcrConversionCreateInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkSamplerYcbcrConversionInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.SamplerYcbcrConversionInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkBindImagePlaneMemoryInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.BindImagePlaneMemoryInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkImagePlaneMemoryRequirementsInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.ImagePlaneMemoryRequirementsInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceSamplerYcbcrConversionFeatures" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceSamplerYcbcrConversionFeatures", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkSamplerYcbcrConversionImageFormatProperties" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.SamplerYcbcrConversionImageFormatProperties", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkDescriptorUpdateTemplateCreateInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.DescriptorUpdateTemplateCreateInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceExternalImageFormatInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceExternalImageFormatInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkExternalImageFormatProperties" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.ExternalImageFormatProperties", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceExternalBufferInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceExternalBufferInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkExternalBufferProperties" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.ExternalBufferProperties", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceIDProperties" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceIdProperties", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkExternalMemoryImageCreateInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.ExternalMemoryImageCreateInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkExternalMemoryBufferCreateInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.ExternalMemoryBufferCreateInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkExportMemoryAllocateInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.ExportMemoryAllocateInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceExternalFenceInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceExternalFenceInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkExternalFenceProperties" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.ExternalFenceProperties", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkExportFenceCreateInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.ExportFenceCreateInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkExportSemaphoreCreateInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.ExportSemaphoreCreateInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceExternalSemaphoreInfo" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceExternalSemaphoreInfo", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkExternalSemaphoreProperties" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.ExternalSemaphoreProperties", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceMaintenance3Properties" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceMaintenance3Properties", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkDescriptorSetLayoutSupport" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.DescriptorSetLayoutSupport", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceShaderDrawParametersFeatures" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceShaderDrawParametersFeatures", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkSwapchainCreateInfoKHR" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.SwapchainCreateInfoKhr", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPresentInfoKHR" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PresentInfoKhr", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkImageSwapchainCreateInfoKHR" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.ImageSwapchainCreateInfoKhr", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkBindImageMemorySwapchainInfoKHR" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.BindImageMemorySwapchainInfoKhr", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkAcquireNextImageInfoKHR" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.AcquireNextImageInfoKhr", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkDeviceGroupPresentCapabilitiesKHR" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.DeviceGroupPresentCapabilitiesKhr", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkDeviceGroupPresentInfoKHR" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.DeviceGroupPresentInfoKhr", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkDeviceGroupSwapchainCreateInfoKHR" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.DeviceGroupSwapchainCreateInfoKhr", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkDisplayModeCreateInfoKHR" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.DisplayModeCreateInfoKhr", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkDisplaySurfaceCreateInfoKHR" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.DisplaySurfaceCreateInfoKhr", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkDisplayPresentInfoKHR" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.DisplayPresentInfoKhr", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkImportMemoryFdInfoKHR" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.ImportMemoryFdInfoKhr", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkMemoryFdPropertiesKHR" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.MemoryFdPropertiesKhr", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkMemoryGetFdInfoKHR" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.MemoryGetFdInfoKhr", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkImportSemaphoreFdInfoKHR" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.ImportSemaphoreFdInfoKhr", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkSemaphoreGetFdInfoKHR" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.SemaphoreGetFdInfoKhr", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDevicePushDescriptorPropertiesKhr" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDevicePushDescriptorPropertiesKhr", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceShaderFloat16Int8FeaturesKHR" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceShaderFloat16Int8FeaturesKhr", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPresentRegionsKHR" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PresentRegionsKhr", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkAttachmentDescription2KHR" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.AttachmentDescription2Khr", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkAttachmentReference2KHR" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.AttachmentReference2Khr", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkSubpassDescription2KHR" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.SubpassDescription2Khr", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkSubpassDependency2KHR" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.SubpassDependency2Khr", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkRenderPassCreateInfo2KHR" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.RenderPassCreateInfo2Khr", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkSubpassBeginInfoKHR" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.SubpassBeginInfoKhr", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkSubpassEndInfoKHR" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.SubpassEndInfoKhr", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkSharedPresentSurfaceCapabilitiesKHR" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.SharedPresentSurfaceCapabilitiesKhr", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkImportFenceFdInfoKHR" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.ImportFenceFdInfoKhr", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkFenceGetFdInfoKHR" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.FenceGetFdInfoKhr", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceSurfaceInfo2KHR" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceSurfaceInfo2Khr", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkSurfaceCapabilities2KHR" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.SurfaceCapabilities2Khr", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkSurfaceFormat2KHR" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.SurfaceFormat2Khr", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkDisplayProperties2KHR" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.DisplayProperties2Khr", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkDisplayPlaneProperties2KHR" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.DisplayPlaneProperties2Khr", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkDisplayModeProperties2KHR" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.DisplayModeProperties2Khr", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkDisplayPlaneInfo2KHR" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.DisplayPlaneInfo2Khr", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkDisplayPlaneCapabilities2KHR" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.DisplayPlaneCapabilities2Khr", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkImageFormatListCreateInfoKHR" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.ImageFormatListCreateInfoKhr", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDevice8BitStorageFeaturesKHR" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDevice8bitStorageFeaturesKhr", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceShaderAtomicInt64FeaturesKHR" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceShaderAtomicInt64FeaturesKhr", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceDriverPropertiesKHR" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceDriverPropertiesKhr", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceFloatControlsPropertiesKHR" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceFloatControlsPropertiesKhr", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkSubpassDescriptionDepthStencilResolveKHR" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.SubpassDescriptionDepthStencilResolveKhr", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceDepthStencilResolvePropertiesKHR" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceDepthStencilResolvePropertiesKhr", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceVulkanMemoryModelFeaturesKHR" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceVulkanMemoryModelFeaturesKhr", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkDebugReportCallbackCreateInfoEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.DebugReportCallbackCreateInfoExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPipelineRasterizationStateRasterizationOrderAMD" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PipelineRasterizationStateRasterizationOrderAmd", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkDebugMarkerObjectNameInfoEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.DebugMarkerObjectNameInfoExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkDebugMarkerObjectTagInfoEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.DebugMarkerObjectTagInfoExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkDebugMarkerMarkerInfoEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.DebugMarkerMarkerInfoExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkDedicatedAllocationImageCreateInfoNV" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.DedicatedAllocationImageCreateInfoNv", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkDedicatedAllocationBufferCreateInfoNV" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.DedicatedAllocationBufferCreateInfoNv", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkDedicatedAllocationMemoryAllocateInfoNV" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.DedicatedAllocationMemoryAllocateInfoNv", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceTransformFeedbackFeaturesEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceTransformFeedbackFeaturesExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceTransformFeedbackPropertiesEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceTransformFeedbackPropertiesExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPipelineRasterizationStateStreamCreateInfoEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PipelineRasterizationStateStreamCreateInfoExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkTextureLODGatherFormatPropertiesAMD" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.TextureLodGatherFormatPropertiesAmd", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceCornerSampledImageFeaturesNV" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceCornerSampledImageFeaturesNv", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkExternalMemoryImageCreateInfoNV" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.ExternalMemoryImageCreateInfoNv", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkExportMemoryAllocateInfoNV" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.ExportMemoryAllocateInfoNv", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkValidationFlagsEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.ValidationFlagsExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkImageViewASTCDecodeModeEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.ImageViewAstcDecodeModeExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceASTCDecodeFeaturesEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceAstcDecodeFeaturesExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkConditionalRenderingBeginInfoEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.ConditionalRenderingBeginInfoExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceConditionalRenderingFeaturesEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceConditionalRenderingFeaturesExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkCommandBufferInheritanceConditionalRenderingInfoEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.CommandBufferInheritanceConditionalRenderingInfoExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkDeviceGeneratedCommandsFeaturesNVX" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.DeviceGeneratedCommandsFeaturesNvx", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkDeviceGeneratedCommandsLimitsNVX" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.DeviceGeneratedCommandsLimitsNvx", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkIndirectCommandsLayoutCreateInfoNVX" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.IndirectCommandsLayoutCreateInfoNvx", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkCmdProcessCommandsInfoNVX" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.CmdProcessCommandsInfoNvx", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkCmdReserveSpaceForCommandsInfoNVX" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.CmdReserveSpaceForCommandsInfoNvx", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkObjectTableCreateInfoNVX" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.ObjectTableCreateInfoNvx", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPipelineViewportWScalingStateCreateInfoNV" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PipelineViewportWScalingStateCreateInfoNv", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkSurfaceCapabilities2EXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.SurfaceCapabilities2Ext", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkDisplayPowerInfoEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.DisplayPowerInfoExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkDeviceEventInfoEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.DeviceEventInfoExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkSwapchainCounterCreateInfoEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.SwapchainCounterCreateInfoExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPresentTimesInfoGOOGLE" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PresentTimesInfoGoogle", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceMultiviewPerViewAttributesPropertiesNvx", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPipelineViewportSwizzleStateCreateInfoNV" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PipelineViewportSwizzleStateCreateInfoNv", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceDiscardRectanglePropertiesEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceDiscardRectanglePropertiesExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPipelineDiscardRectangleStateCreateInfoEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PipelineDiscardRectangleStateCreateInfoExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceConservativeRasterizationPropertiesEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceConservativeRasterizationPropertiesExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPipelineRasterizationConservativeStateCreateInfoEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PipelineRasterizationConservativeStateCreateInfoExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceDepthClipEnableFeaturesEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceDepthClipEnableFeaturesExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPipelineRasterizationDepthClipStateCreateInfoEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PipelineRasterizationDepthClipStateCreateInfoExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkHdrMetadataEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.HdrMetadataExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkDebugUtilsObjectNameInfoEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.DebugUtilsObjectNameInfoExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkDebugUtilsObjectTagInfoEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.DebugUtilsObjectTagInfoExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkDebugUtilsLabelEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.DebugUtilsLabelExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkDebugUtilsMessengerCallbackDataEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.DebugUtilsMessengerCallbackDataExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkDebugUtilsMessengerCreateInfoEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.DebugUtilsMessengerCreateInfoExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkSamplerReductionModeCreateInfoEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.SamplerReductionModeCreateInfoExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceSamplerFilterMinmaxPropertiesEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceSamplerFilterMinmaxPropertiesExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceInlineUniformBlockFeaturesEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceInlineUniformBlockFeaturesExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceInlineUniformBlockPropertiesEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceInlineUniformBlockPropertiesExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkWriteDescriptorSetInlineUniformBlockEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.WriteDescriptorSetInlineUniformBlockExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkDescriptorPoolInlineUniformBlockCreateInfoEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.DescriptorPoolInlineUniformBlockCreateInfoExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkSampleLocationsInfoEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.SampleLocationsInfoExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkRenderPassSampleLocationsBeginInfoEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.RenderPassSampleLocationsBeginInfoExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPipelineSampleLocationsStateCreateInfoEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PipelineSampleLocationsStateCreateInfoExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceSampleLocationsPropertiesEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceSampleLocationsPropertiesExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkMultisamplePropertiesEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.MultisamplePropertiesExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceBlendOperationAdvancedFeaturesExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceBlendOperationAdvancedPropertiesExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPipelineColorBlendAdvancedStateCreateInfoEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PipelineColorBlendAdvancedStateCreateInfoExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPipelineCoverageToColorStateCreateInfoNV" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PipelineCoverageToColorStateCreateInfoNv", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPipelineCoverageModulationStateCreateInfoNV" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PipelineCoverageModulationStateCreateInfoNv", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkDrmFormatModifierPropertiesListEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.DrmFormatModifierPropertiesListExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceImageDrmFormatModifierInfoEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceImageDrmFormatModifierInfoExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkImageDrmFormatModifierListCreateInfoEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.ImageDrmFormatModifierListCreateInfoExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkImageDrmFormatModifierExplicitCreateInfoEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.ImageDrmFormatModifierExplicitCreateInfoExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkImageDrmFormatModifierPropertiesEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.ImageDrmFormatModifierPropertiesExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkValidationCacheCreateInfoEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.ValidationCacheCreateInfoExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkShaderModuleValidationCacheCreateInfoEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.ShaderModuleValidationCacheCreateInfoExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkDescriptorSetLayoutBindingFlagsCreateInfoEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.DescriptorSetLayoutBindingFlagsCreateInfoExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceDescriptorIndexingFeaturesEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceDescriptorIndexingFeaturesExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceDescriptorIndexingPropertiesEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceDescriptorIndexingPropertiesExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkDescriptorSetVariableDescriptorCountAllocateInfoEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.DescriptorSetVariableDescriptorCountAllocateInfoExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkDescriptorSetVariableDescriptorCountLayoutSupportEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.DescriptorSetVariableDescriptorCountLayoutSupportExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPipelineViewportShadingRateImageStateCreateInfoNV" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PipelineViewportShadingRateImageStateCreateInfoNv", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceShadingRateImageFeaturesNV" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceShadingRateImageFeaturesNv", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceShadingRateImagePropertiesNV" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceShadingRateImagePropertiesNv", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPipelineViewportCoarseSampleOrderStateCreateInfoNV" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PipelineViewportCoarseSampleOrderStateCreateInfoNv", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkRayTracingShaderGroupCreateInfoNV" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.RayTracingShaderGroupCreateInfoNv", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkRayTracingPipelineCreateInfoNV" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.RayTracingPipelineCreateInfoNv", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkGeometryTrianglesNV" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.GeometryTrianglesNv", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkGeometryAABBNV" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.GeometryAabbNv", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkGeometryNV" };
        values.FieldValues["sType"] = new PredefinedFieldInput() { Value = "StructureType.GeometryNv", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkAccelerationStructureInfoNV" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.AccelerationStructureInfoNv", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkAccelerationStructureCreateInfoNV" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.AccelerationStructureCreateInfoNv", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkBindAccelerationStructureMemoryInfoNV" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.BindAccelerationStructureMemoryInfoNv", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkWriteDescriptorSetAccelerationStructureNV" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.WriteDescriptorSetAccelerationStructureNv", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkAccelerationStructureMemoryRequirementsInfoNV" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.AccelerationStructureMemoryRequirementsInfoNv", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceRayTracingPropertiesNV" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceRayTracingPropertiesNv", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceRepresentativeFragmentTestFeaturesNv", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPipelineRepresentativeFragmentTestStateCreateInfoNV" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PipelineRepresentativeFragmentTestStateCreateInfoNv", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceImageViewImageFormatInfoEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceImageViewImageFormatInfoExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkFilterCubicImageViewImageFormatPropertiesEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.FilterCubicImageViewImageFormatPropertiesExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkDeviceQueueGlobalPriorityCreateInfoEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.DeviceQueueGlobalPriorityCreateInfoExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkImportMemoryHostPointerInfoEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.ImportMemoryHostPointerInfoExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkMemoryHostPointerPropertiesEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.MemoryHostPointerPropertiesExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceExternalMemoryHostPropertiesEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceExternalMemoryHostPropertiesExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkCalibratedTimestampInfoEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.CalibratedTimestampInfoExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceShaderCorePropertiesAMD" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceShaderCorePropertiesAmd", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkDeviceMemoryOverallocationCreateInfoAMD" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.DeviceMemoryOverallocationCreateInfoAmd", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceVertexAttributeDivisorPropertiesExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPipelineVertexInputDivisorStateCreateInfoEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PipelineVertexInputDivisorStateCreateInfoExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceVertexAttributeDivisorFeaturesExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceComputeShaderDerivativesFeaturesNV" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceComputeShaderDerivativesFeaturesNv", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceMeshShaderFeaturesNV" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceMeshShaderFeaturesNv", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceMeshShaderPropertiesNV" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceMeshShaderPropertiesNv", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceFragmentShaderBarycentricFeaturesNV" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceFragmentShaderBarycentricFeaturesNv", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceShaderImageFootprintFeaturesNV" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceShaderImageFootprintFeaturesNv", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPipelineViewportExclusiveScissorStateCreateInfoNV" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PipelineViewportExclusiveScissorStateCreateInfoNv", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceExclusiveScissorFeaturesNV" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceExclusiveScissorFeaturesNv", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkQueueFamilyCheckpointPropertiesNV" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.QueueFamilyCheckpointPropertiesNv", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkCheckpointDataNV" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.CheckpointDataNv", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDevicePCIBusInfoPropertiesEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDevicePciBusInfoPropertiesExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceFragmentDensityMapFeaturesEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceFragmentDensityMapFeaturesExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceFragmentDensityMapPropertiesEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceFragmentDensityMapPropertiesExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkRenderPassFragmentDensityMapCreateInfoEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.RenderPassFragmentDensityMapCreateInfoExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceScalarBlockLayoutFeaturesEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceScalarBlockLayoutFeaturesExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceMemoryBudgetPropertiesEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceMemoryBudgetPropertiesExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceMemoryPriorityFeaturesEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceMemoryPriorityFeaturesExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkMemoryPriorityAllocateInfoEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.MemoryPriorityAllocateInfoExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceDedicatedAllocationImageAliasingFeaturesNv", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceBufferDeviceAddressFeaturesEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceBufferDeviceAddressFeaturesExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkBufferDeviceAddressInfoEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.BufferDeviceAddressInfoExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkBufferDeviceAddressCreateInfoEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.BufferDeviceAddressCreateInfoExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkImageStencilUsageCreateInfoEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.ImageStencilUsageCreateInfoExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkValidationFeaturesEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.ValidationFeaturesExt", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkCooperativeMatrixPropertiesNV" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.CooperativeMatrixPropertiesNv", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceCooperativeMatrixFeaturesNV" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceCooperativeMatrixFeaturesNv", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkPhysicalDeviceCooperativeMatrixPropertiesNV" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.PhysicalDeviceCooperativeMatrixPropertiesNv", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkWin32SurfaceCreateInfoKHR" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.Win32SurfaceCreateInfoKhr", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkMacOSSurfaceCreateInfoMVK" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.MacosSurfaceCreateInfoMvk", IsReadOnly = true };
        predefinedValues.Add(values);
        values = new StructurePredefinedInput() { StructType = "VkHeadlessSurfaceCreateInfoEXT" };
        values.FieldValues["sType"] = new PredefinedFieldInput()
            { Value = "StructureType.HeadlessSurfaceCreateInfoExt", IsReadOnly = true };
        predefinedValues.Add(values);

        return predefinedValues;
    }
   
    public static MacroFunction CreateMakeApiVersionFunction()
    {
        var function = new MacroFunction();
        var variant = new Parameter() { Type = new BuiltinType(PrimitiveType.Byte), Name = "variant", ParameterKind = ParameterKind.In };
        var major = new Parameter() { Type = new BuiltinType(PrimitiveType.Byte), Name = "major", ParameterKind = ParameterKind.In};
        var minor = new Parameter() { Type = new BuiltinType(PrimitiveType.Byte), Name = "minor", ParameterKind = ParameterKind.In };
        var patch = new Parameter() { Type = new BuiltinType(PrimitiveType.Byte), Name = "patch", ParameterKind = ParameterKind.In };
        function.Parameters.Add(variant);
        function.Parameters.Add(major);
        function.Parameters.Add(minor);
        function.Parameters.Add(patch);
        function.FunctionBody =
            $"var version = variant << 29 | major << 22 | minor << 12 | patch;{Environment.NewLine}return (uint)version;";
        function.ReturnType = new BuiltinType(PrimitiveType.UInt32);

        return function;
    }
    
    public static MacroFunction CreateApiVersion()
    {
        var function = new MacroFunction();
        function.ReturnType = new BuiltinType(PrimitiveType.UInt32);
        function.ApplyOnlyReturnType = true;
        return function;
    }

    public static MacroFunction CreateApiVersionFor(string paramName)
    {
        var function = new MacroFunction();
        var param = new Parameter() { Type = new BuiltinType(PrimitiveType.Byte), Name = paramName };
        function.Parameters.Add(param);
        switch (paramName)
        {
            case "variant":
                function.FunctionBody = $"return (uint)({paramName}>>29);";
                break;
            case "major":
                function.FunctionBody = $"return ((uint)({paramName}>>22) & 0x7FU);";
                break;
            case "minor":
                function.FunctionBody = $"return ((uint)({paramName}>>12) & 0x3FFU);";
                break;
            case "patch":
                function.FunctionBody = $"return (uint)({paramName} & 0xFFFU);";
                break;
        }
        function.FunctionBody = $"return (uint)({paramName}>>22);";
        function.ReturnType = new BuiltinType(PrimitiveType.UInt32);

        return function;
    }
    
    public static MacroFunction CreateHeaderVersion()
    {
        var function = new MacroFunction();
        function.ReturnType = new BuiltinType(PrimitiveType.Byte);
        function.ApplyOnlyReturnType = true;
        return function;
    }

    public static MacroFunction CreateLodClampNone()
    {
        var function = new MacroFunction();
        function.ReturnType = new BuiltinType(PrimitiveType.Float);
        function.ApplyOnlyReturnType = true;
        return function;
    }

    //public static MacroFunction CreateMaintenanceExtensionName()
    public static MacroFunction CreateStringReturnMacro()
    {
        var func = new MacroFunction();
        func.ReturnType = new BuiltinType(PrimitiveType.String);
        func.ApplyOnlyReturnType = true;
        return func;
    }
    
    public static void ProvideFunctionsForParametersFix(ProcessingContext ctx)
    {
        PostProcessingApi api = new PostProcessingApi();

        api.Class("VkFramebufferAttachmentImageInfoKHR").WithField("pViewFormats")
            .InterpretAsPointerToArray(new CustomType("vkFormat"), true, "viewFormatCount");

        api.Class("VkPipelineViewportStateCreateInfo")
            .WithField("pViewports")
            .InterpretAsPointerToArray(new CustomType("VkViewport"), true, "viewportCount")
            .WithField("pScissors")
            .InterpretAsPointerToArray(new CustomType("VkRect2D"), true, "scissorCount");

        api.Class("VkPipelineColorBlendStateCreateInfo")
            .WithField("pAttachments")
            .InterpretAsPointerToArray(new CustomType("VkPipelineColorBlendAttachmentState"), true,
                "attachmentCount");

        api.Class("VkDescriptorPoolCreateInfo")
            .WithField("pPoolSizes")
            .InterpretAsPointerToArray(new CustomType("VkDescriptorPoolSize"), true, "poolSizeCount");

        api.Class("VkWriteDescriptorSet")
            .WithField("pImageInfo")
            .InterpretAsPointerToArray(new CustomType("VkDescriptorImageInfo"), true, "descriptorCount")
            .WithField("pBufferInfo")
            .InterpretAsPointerToArray(new CustomType("VkDescriptorBufferInfo"), true, "descriptorCount")
            .WithField("pTexelBufferView")
            .InterpretAsPointerToArray(new CustomType("VkBufferView"), true, "descriptorCount");

        api.Function("vkUpdateDescriptorSets")
            .WithParameterName("pDescriptorWrites")
            .InterpretAsPointerToArray(new CustomType("VkWriteDescriptorSet"), true, "descriptorWriteCount")
            .WithParameterName("pDescriptorCopies")
            .InterpretAsPointerToArray(new CustomType("VkCopyDescriptorSet"), true, "descriptorCopyCount")
            .SetParameterKind(ParameterKind.Out);

        api.Function("vkGetDisplayPlaneSupportedDisplaysKHR")
            .WithParameterName("pDisplays")
            .InterpretAsPointerToArray(new CustomType("VkDisplayKHR_T"), true, "pDisplayCount")
            .SetParameterKind(ParameterKind.Out);

        api.Function("vkGetPhysicalDeviceDisplayPlanePropertiesKHR")
            .WithParameterName("pProperties")
            .InterpretAsPointerToArray(new CustomType("VkDisplayPlanePropertiesKHR"), true, "pPropertyCount")
            .SetParameterKind(ParameterKind.Out);

        api.Function("vkEnumerateDeviceExtensionProperties")
            .WithParameterName("pProperties")
            .InterpretAsPointerToArray(new CustomType("VkExtensionProperties"), true, "pPropertyCount")
            .SetParameterKind(ParameterKind.InOut);

        api.Function("vkEnumerateDeviceLayerProperties")
            .WithParameterName("pProperties")
            .InterpretAsPointerToArray(new CustomType("VkLayerProperties"), true, "pPropertyCount")
            .SetParameterKind(ParameterKind.InOut);

        api.Function("vkCmdSetScissor")
            .WithParameterName("pScissors")
            .InterpretAsPointerToArray(new CustomType("VkRect2D"), true, "scissorCount");

        api.Function("vkCmdSetViewport")
            .WithParameterName("pViewports")
            .InterpretAsPointerToArray(new CustomType("VkViewport"), true, "viewportCount");

        api.Function("shaderc_result_get_bytes").WithReturnType(new BuiltinType(PrimitiveType.IntPtr));

        api.Function("spvc_context_parse_spirv").WithParameterName("spirv")
            .InterpretAsPointerToArray(new BuiltinType(PrimitiveType.Byte));

        api.Function("spvc_resources_get_resource_list_for_type").WithParameterName("resource_list")
            .InterpretAsPointerToArray(new CustomType("SpvcReflectedResource"), true, "resource_size")
            .SetParameterKind(ParameterKind.Out);

        api.Delegate("spvc_error_callback").WithParameterName("error").InterpretAsIs()
            .SetParameterKind(ParameterKind.Out);

        api.Function("spvc_constant_get_type").RenameTo("spvc_constant_get_constant_type");

        //api.Function("vkEnumerateInstanceExtensionProperties").
        //    WithParameterName("pProperties").
        //    TreatAsPointerToArray(new CustomType("VkExtensionProperties")).
        //    SetParameterKind(ParameterKind.InOut);

        //api.Function("vkEnumerateInstanceLayerProperties").
        //    WithParameterName("pProperties").
        //    TreatAsPointerToArray(new CustomType("VkLayerProperties")).
        //    SetParameterKind(ParameterKind.InOut);

        //api.Function("vkEnumeratePhysicalDevices").
        //    WithParameterName("pPhysicalDevices").
        //    TreatAsPointerToArray(new CustomType("VkPhysicalDevice")).
        //    SetParameterKind(ParameterKind.InOut);

        //api.Function("VkGetPhysicalDeviceProperties").
        //    WithParameterName("pProperties").
        //    TreatAsIs().
        //    SetParameterKind(ParameterKind.Out);

        //api.Function("VkGetPhysicalDeviceFeatures").
        //    WithParameterName("pFeatures").
        //    TreatAsIs().
        //    SetParameterKind(ParameterKind.Out);

        //api.Function("vkCmdBindTransformFeedbackBuffersEXT").
        //    WithParameterName("pOffsets").
        //    TreatAsPointerToArray(new BuiltinType(PrimitiveType.UInt64)).
        //    SetParameterKind(ParameterKind.InOut).
        //    WithParameterName("pSizes").
        //    TreatAsPointerToArray(new BuiltinType(PrimitiveType.UInt64)).
        //    SetParameterKind(ParameterKind.InOut);

        //api.Function("vkCmdBeginTransformFeedbackEXT").
        //    WithParameterName("pCounterBufferOffsets").
        //    TreatAsPointerToArray(new BuiltinType(PrimitiveType.UInt64)).
        //    SetParameterKind(ParameterKind.InOut);

        //api.Function("vkCmdEndTransformFeedbackEXT").
        //    WithParameterName("pCounterBufferOffsets").
        //    TreatAsPointerToArray(new BuiltinType(PrimitiveType.UInt64)).
        //    SetParameterKind(ParameterKind.InOut);

        //api.Function("vkCmdBindVertexBuffers").
        //    WithParameterName("pOffsets").
        //    TreatAsPointerToArray(new BuiltinType(PrimitiveType.UInt64)).
        //    SetParameterKind(ParameterKind.InOut);

        //api.Functions(
        //        "vkGetPhysicalDeviceMemoryProperties", 
        //        "vkGetPhysicalDeviceMemoryProperties2", 
        //        "vkGetPhysicalDeviceMemoryProperties2KHR").
        //    WithParameterName("pMemoryProperties").
        //    TreatAsIs().
        //    SetParameterKind(ParameterKind.Out);

        //api.Function("vkGetPhysicalDeviceQueueFamilyProperties").
        //    WithParameterName("pQueueFamilyProperties").
        //    TreatAsPointerToArray(new CustomType("VkQueueFamilyProperties")).
        //    SetParameterKind(ParameterKind.InOut);

        //api.Function("vkGetPhysicalDeviceQueueFamilyProperties2").
        //    WithParameterName("pQueueFamilyProperties").
        //    TreatAsPointerToArray(new CustomType("VkQueueFamilyProperties2")).
        //    SetParameterKind(ParameterKind.InOut);

        //api.AllFunctions().
        //    WithParameterType("VkAllocationCallbacks").
        //    TreatAsPointerType().
        //    SetNullable(true).
        //    SetDelegateNullable(true).
        //    SetParameterKind(ParameterKind.Readonly);

        //api.Functions("vkDestroyInstance", "vkDestroyDevice").
        //    WithParameterName("pAllocator").
        //    TreatAsIs().
        //    SetDefaultValue("null");

        //api.Delegate("PFN_vkGetInstanceProcAddr").WithReturnType(new BuiltinType(PrimitiveType.Void));
        //api.Delegate("PFN_vkGetDeviceProcAddr").WithReturnType(new BuiltinType(PrimitiveType.Void));

        var structsList = new List<string>
        {
            "VkInstance_T",
            "VkPhysicalDevice_T",
            "VkDevice_T",
            "VkQueue_T",
            "VkSemaphore_T",
            "VkCommandBuffer_T",
            "VkFence_T",
            "VkDeviceMemory_T",
            "VkBuffer_T",
            "VkImage_T",
            "VkEvent_T",
            "VkQueryPool_T",
            "VkBufferView_T",
            "VkImageView_T",
            "VkShaderModule_T",
            "VkPipelineCache_T",
            "VkPipelineLayout_T",
            "VkRenderPass_T",
            "VkPipeline_T",
            "VkDescriptorSetLayout_T",
            "VkSampler_T",
            "VkDescriptorPool_T",
            "VkDescriptorSet_T",
            "VkFramebuffer_T",
            "VkCommandPool_T",
            "VkSamplerYcbcrConversion_T",
            "VkDescriptorUpdateTemplate_T",
            "VkSurfaceKHR_T",
            "VkSwapchainKHR_T",
            "VkDisplayKHR_T",
            "VkDisplayModeKHR_T",
            "VkDescriptorUpdateTemplateKHR_T",
            "VkSamplerYcbcrConversionKHR_T",
            "VkDebugReportCallbackEXT_T",
            "VkObjectTableNVX_T",
            "VkIndirectCommandsLayoutNVX_T",
            "VkDebugUtilsMessengerEXT_T",
            "VkValidationCacheEXT_T",
            "VkAccelerationStructureNV_T"
        };

        //api.Classes(structsList).
        //    AddField("pointer").
        //    SetType(new PointerType() {Pointee = new BuiltinType(PrimitiveType.IntPtr)});

        var propertyType = new BuiltinType(PrimitiveType.IntPtr);

        var classesList = new List<string>()
        {
            "VkInstance",
            "VkPhysicalDevice",
            "VkDevice",
            "VkQueue",
            "VkSemaphore",
            "VkCommandBuffer",
            "VkFence",
            "VkDeviceMemory",
            "VkBuffer",
            "VkImage",
            "VkEvent",
            "VkQueryPool",
            "VkBufferView",
            "VkImageView",
            "VkShaderModule",
            "VkPipelineCache",
            "VkPipelineLayout",
            "VkRenderPass",
            "VkPipeline",
            "VkDescriptorSetLayout",
            "VkSampler",
            "VkDescriptorPool",
            "VkDescriptorSet",
            "VkFramebuffer",
            "VkCommandPool",
            "VkSamplerYcbcrConversion",
            "VkDescriptorUpdateTemplate",
            "VkSurfaceKHR",
            "VkSwapchainKHR",
            "VkDisplayKHR",
            "VkDisplayModeKHR",
            "VkDescriptorUpdateTemplateKHR",
            "VkSamplerYcbcrConversionKHR",
            "VkDebugReportCallbackEXT",
            "VkObjectTableNVX",
            "VkIndirectCommandsLayoutNVX",
            "VkDebugUtilsMessengerEXT",
            "VkValidationCacheEXT",
            "VkAccelerationStructureNV",
        };

        api.Classes(classesList).AddProperty("NativePointer").SetField("__Instance.pointer").SetType(propertyType)
            .SetGetter(new Method());

        var defaultParamFunctions = new[]
        {
            "vkDestroySurfaceKHR",
            "vkDestroyDebugReportCallbackEXT",
            "vkDestroyDebugUtilsMessengerEXT",
            "vkDestroyFence",
            "vkDestroySemaphore",
            "vkDestroyEvent",
            "vkDestroyQueryPool",
            "vkDestroyBuffer",
            "vkDestroyBufferView",
            "vkDestroyImage",
            "vkDestroyImageView",
            "vkDestroyShaderModule",
            "vkDestroyPipelineCache",
            "vkDestroyPipeline",
            "vkDestroyPipelineLayout",
            "vkDestroySampler",
            "vkDestroyDescriptorPool",
            "vkDestroyDescriptorSetLayout",
            "vkDestroyFramebuffer",
            "vkDestroyRenderPass",
            "vkDestroyCommandPool",
            "vkDestroySamplerYcbcrConversion",
            "vkDestroyDescriptorUpdateTemplate",
            "vkDestroySwapchainKHR",
            "vkDestroyDescriptorUpdateTemplateKHR",
            "vkDestroySamplerYcbcrConversionKHR",
            "vkDestroyIndirectCommandsLayoutNVX",
            "vkDestroyObjectTableNVX",
            "vkDestroyValidationCacheEXT",
            "vkDestroyAccelerationStructureNV",
            "vkFreeMemory"
        };

        api.Functions(defaultParamFunctions).WithParameterName("pAllocator").InterpretAsIs()
            .SetDefaultValue("null");

        api.Class("VkAccelerationStructureBuildGeometryInfoKHR")
            .WithField("pGeometries")
            .InterpretAsPointerToArray(new CustomType("VkAccelerationStructureGeometryKHR"),
                arraySizeSource: "geometryCount")
            .WithField("ppGeometries")
            .InterpretAsPointerToArray(new CustomType("VkAccelerationStructureGeometryKHR"),
                arraySizeSource: "geometryCount");

        api.Class("VkImageFormatListCreateInfo")
            .WithField("pViewFormats")
            .InterpretAsPointerToArray(new CustomType("VkFormat"), arraySizeSource: "viewFormatCount");

        api.Class("VkFramebufferAttachmentImageInfo")
            .WithField("pViewFormats")
            .InterpretAsPointerToArray(new CustomType("VkFormat"), arraySizeSource: "viewFormatCount");

        api.Class("VkIndirectCommandsLayoutTokenNV")
            .WithField("pIndexTypes")
            .InterpretAsPointerToArray(new CustomType("VkIndexType"), arraySizeSource: "indexTypeCount")
            .WithField("pIndexTypeValues")
            .InterpretAsPointerToArray(new BuiltinType(PrimitiveType.UInt32), arraySizeSource: "indexTypeCount");

        api.Class("VkCuLaunchInfoNVX")
            .WithField("pParams")
            .InterpretAsPointerToArray(new BuiltinType(PrimitiveType.UInt32), arraySizeSource: "paramCount")
            .WithField("pExtras")
            .InterpretAsPointerToArray(new BuiltinType(PrimitiveType.UInt32), arraySizeSource: "extraCount");

        api.Class("VkPipelineColorWriteCreateInfoEXT")
            .WithField("pColorWriteEnables")
            .InterpretAsPointerToArray(new BuiltinType(PrimitiveType.Bool32), arraySizeSource: "attachmentCount");
        
        //api.Function("vkGetPhysicalDeviceSurfaceCapabilitiesKHR").
        //    WithParameterName("pSurfaceCapabilities").
        //    TreatAsIs().
        //    SetParameterKind(ParameterKind.Out);

        //api.Function("vkGetPhysicalDeviceSurfaceFormatsKHR").
        //    WithParameterName("pSurfaceFormats").
        //    TreatAsPointerToArray(new CustomType("VkSurfaceFormatKHR")).
        //    SetParameterKind(ParameterKind.InOut);

        //api.Function("vkGetPhysicalDeviceSurfacePresentModesKHR").
        //    WithParameterName("pPresentModes").
        //    TreatAsPointerToArray(new CustomType("VkPresentModeKHR")).
        //    SetParameterKind(ParameterKind.InOut);

        //api.Function("vkGetSwapchainImagesKHR").
        //    WithParameterName("pSwapchainImages").
        //    TreatAsPointerToArray(new CustomType("VkImage")).
        //    SetParameterKind(ParameterKind.InOut);

        //api.Function("vkGetInstanceProcAddr").
        //    WithReturnType(new BuiltinType(PrimitiveType.IntPtr));

        //api.Function("vkGetDeviceProcAddr").
        //    WithReturnType(new BuiltinType(PrimitiveType.IntPtr));

        //api.Function("vkAllocateCommandBuffers").
        //    WithParameterName("pCommandBuffers").
        //    TreatAsPointerToArray(new CustomType("VkCommandBuffer")).
        //    SetParameterKind(ParameterKind.InOut);

        //api.Function("vkWaitForFences").
        //    WithParameterName("pFences").
        //    TreatAsPointerToArray(new CustomType("VkFence")).
        //    SetParameterKind(ParameterKind.In);

        //api.Function("vkResetFences").
        //    WithParameterName("pFences").
        //    TreatAsPointerToArray(new CustomType("VkFence")).
        //    SetParameterKind(ParameterKind.In);

        //api.Function("vkQueueSubmit").
        //    WithParameterName("pSubmits").
        //    TreatAsPointerToArray(new CustomType("VkSubmitInfo")).
        //    SetParameterKind(ParameterKind.In);

        //api.Function("vkFreeCommandBuffers").
        //    WithParameterName("pCommandBuffers").
        //    TreatAsPointerToArray(new CustomType("VkCommandBuffer")).
        //    SetParameterKind(ParameterKind.In);

        //api.Functions("vKGetBufferMemoryRequirements", "vKGetImageMemoryRequirements")
        //    .WithParameterName("pMemoryRequirements")
        //    .TreatAsIs()
        //    .SetParameterKind(ParameterKind.Out);

        //api.Function("vkCmdBindVertexBuffers")
        //    .WithParameterName("pBuffers")
        //    .TreatAsPointerToArray(new CustomType("VkBuffer"), true)
        //    .SetParameterKind(ParameterKind.In);

        //api.Function("vkCmdCopyBuffer")
        //    .WithParameterName("pRegions")
        //    .TreatAsPointerToArray(new CustomType("VkBufferCopy"))
        //    .SetParameterKind(ParameterKind.In);

        //api.Functions("vkCreateGraphicsPipelines", "vkCreateComputePipelines")
        //    .WithParameterName("pPipelines")
        //    .TreatAsPointerToArray(new CustomType("VkPipeline"), true, "createInfoCount")
        //    .SetParameterKind(ParameterKind.Out);

        //api.Function("vkCmdPipelineBarrier").
        //    WithParameterName("pMemoryBarriers").
        //    TreatAsPointerToArray(new CustomType("vkMemoryBarrier")).
        //    SetParameterKind(ParameterKind.In).
        //    WithParameterName("pBufferMemoryBarriers").
        //    TreatAsPointerToArray(new CustomType("vkBufferMemoryBarrier")).
        //    SetParameterKind(ParameterKind.In).
        //    WithParameterName("pImageMemoryBarriers").
        //    TreatAsPointerToArray(new CustomType("vkImageMemoryBarrier")).
        //    SetParameterKind(ParameterKind.In);

        //api.Function("vkAllocateDescriptorSets").
        //    WithParameterName("pDescriptorSets").
        //    TreatAsPointerToArray(new CustomType("VkDescriptorSet_T")).
        //    SetParameterKind(ParameterKind.InOut);

        //api.Class("VkBool32").
        //    SetUnderlyingType(new BuiltinType(PrimitiveType.Bool32));

        //api.Class("VkDeviceCreateInfo").
        //    WithField("pQueueCreateInfos").
        //    TreatAsPointerToArray(new CustomType("VkDeviceQueueCreateInfo"), true, "queueCreateInfoCount");

        //api.Class("VkSubmitInfo").
        //    WithField("pWaitSemaphores").
        //    TreatAsPointerToArray(new CustomType("VkSemaphore"), true, "waitSemaphoreCount")
        //    .WithField("pSignalSemaphores").
        //    TreatAsPointerToArray(new CustomType("VkSemaphore"), true, "signalSemaphoreCount")
        //    .WithField("pWaitDstStageMask").
        //    TreatAsPointerToArray(new BuiltinType(PrimitiveType.UInt32));

        //api.Class("VkPresentInfoKHR")
        //    .WithField("pWaitSemaphores").TreatAsPointerToArray(new CustomType("VkSemaphore"), true, "waitSemaphoreCount")
        //    .WithField("pSwapchains").TreatAsPointerToArray(new CustomType("VkSwapchainKHR"), true, "swapchainCount")
        //    .WithField("pImageIndices").TreatAsPointerToArray(new BuiltinType(PrimitiveType.UInt32), true, "swapchainCount")
        //    .WithField("pResults").TreatAsPointerToArray(new CustomType("VkResult"), true, "swapchainCount");

        //api.Class("VkShaderModuleCreateInfo").
        //    WithField("pCode").TreatAsPointerToArray(new BuiltinType(PrimitiveType.Byte), true, "codeSize");

        //api.Class("VkSwapchainCreateInfoKHR").
        //    WithField("pQueueFamilyIndices").TreatAsPointerToArray(new BuiltinType(PrimitiveType.UInt32), true, "queueFamilyIndexCount");

        //api.Class("VkGraphicsPipelineCreateInfo")
        //    .WithField("pStages")
        //    .TreatAsPointerToArray(new CustomType("VkPipelineShaderStageCreateInfo"), true, "stageCount");

        //api.Class("VkRenderPassBeginInfo")
        //    .WithField("pClearValues")
        //    .TreatAsPointerToArray(new CustomType("VkClearValue"), true, "clearValueCount");

        //api.Class("VkPipelineVertexInputStateCreateInfo")
        //    .WithField("pVertexBindingDescriptions")
        //    .TreatAsPointerToArray(new CustomType("VkVertexInputBindingDescription"), true, "vertexBindingDescriptionCount")
        //    .WithField("pVertexAttributeDescriptions")
        //    .TreatAsPointerToArray(new CustomType("VkVertexInputAttributeDescription"), true, "vertexAttributeDescriptionCount");

        //api.Class("VkSubmitInfo")
        //    .WithField("pCommandBuffers")
        //    .TreatAsPointerToArray(new CustomType("VkCommandBuffer"), true, "commandBufferCount");

        //api.Class("VkPipelineDynamicStateCreateInfo").
        //    WithField("pDynamicStates").
        //    TreatAsPointerToArray(new CustomType("VkDynamicState"), true, "dynamicStateCount");

        //api.Class("VkImageFormatListCreateInfoKHR").
        //    WithField("pViewFormats").
        //    TreatAsPointerToArray(new CustomType("VkFormat"), true, "viewFormatCount");

        //api.Class("VkValidationFlagsEXT")
        //    .WithField("pDisabledValidationChecks").
        //    TreatAsPointerToArray(new CustomType("VkValidationCheckEXT"), true, "disabledValidationCheckCount");

        //api.Class("VkObjectTableCreateInfoNVX")
        //    .WithField("pObjectEntryTypes").
        //    TreatAsPointerToArray(new CustomType("VkObjectEntryTypeNVX"), true, "objectCount")
        //    .WithField("pObjectEntryCounts").
        //    TreatAsPointerToArray(new BuiltinType(PrimitiveType.UInt32), true, "objectCount")
        //    .WithField("pObjectEntryUsageFlags").
        //    TreatAsPointerToArray(new BuiltinType(PrimitiveType.UInt32), true, "objectCount");

        //api.Class("VkShadingRatePaletteNV")
        //    .WithField("pShadingRatePaletteEntries").
        //    TreatAsPointerToArray(new CustomType("VkShadingRatePaletteEntryNV"), true, "shadingRatePaletteEntryCount");

        //api.Class("VkValidationFeaturesEXT")
        //    .WithField("pEnabledValidationFeatures").
        //    TreatAsPointerToArray(new CustomType("VkValidationFeatureEnableEXT"), true, "enabledValidationFeatureCount")
        //    .WithField("pDisabledValidationFeatures").
        //    TreatAsPointerToArray(new CustomType("VkValidationFeatureDisableEXT"), true, "disabledValidationFeatureCount");

        //api.Class("VkDescriptorSetAllocateInfo").
        //    WithField("pSetLayouts").
        //    TreatAsPointerToArray(new CustomType("VkDescriptorSetLayout"), true, "descriptorSetCount");

        var fixingFunctionParameters = new PostProcessingApiPass(api);
        ctx.AddPreGeneratorPass(fixingFunctionParameters, ExecutionPassKind.PerTranslationUnit);
    }
}