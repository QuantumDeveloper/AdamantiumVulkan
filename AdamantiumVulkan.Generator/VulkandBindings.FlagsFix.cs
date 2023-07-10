using QuantumBinding.Generator;
using QuantumBinding.Generator.ProcessingFluentApi;
using QuantumBinding.Generator.Processors;
using QuantumBinding.Generator.Types;

namespace AdamantiumVulkan.Generator;

public static partial class VulkanBindings
{
    public static void ReplaceTypedefsToEnums(ProcessingContext ctx)
    {
        var api = new PostProcessingApi();
        
        api.Class("VkMemoryType")
            .WithField("propertyFlags")
            .InterpretAsCustomType("VkMemoryPropertyFlagBits")
            .ChangeType();

        api.Class("VkMemoryHeap")
            .WithField("flags")
            .InterpretAsCustomType("VkMemoryHeapFlagBits")
            .ChangeType();
        
        api.Class("VkAccelerationStructureBuildGeometryInfoKHR")
            .WithField("flags")
            .InterpretAsCustomType("VkBuildAccelerationStructureFlagBitsKHR")
            .ChangeType();
        
        api.Class("VkAccelerationStructureGeometryKHR")
            .WithField("flags")
            .InterpretAsCustomType("VkGeometryFlagBitsKHR")
            .ChangeType();
        
        api.Class("VkAccelerationStructureInfoNV")
            .WithField("flags")
            .InterpretAsCustomType("VkBuildAccelerationStructureFlagBitsKHR")
            .ChangeType();
        
        api.Class("VkAccelerationStructureInstanceKHR")
            .WithField("flags")
            .InterpretAsCustomType("VkGeometryInstanceFlagBitsKHR")
            .ChangeType();
        
        api.Class("VkAccelerationStructureMatrixMotionInstanceNV")
            .WithField("flags")
            .InterpretAsCustomType("VkGeometryInstanceFlagBitsKHR")
            .ChangeType();
        
        api.Class("VkAccelerationStructureMotionInfoNV")
            .WithField("flags")
            .InterpretAsCustomType("VkAccelerationStructureMotionInstanceTypeNV")
            .ChangeType();
        
        api.Class("VkAccelerationStructureMotionInstanceNV")
            .WithField("flags")
            .InterpretAsCustomType("VkAccelerationStructureMotionInstanceTypeNV")
            .ChangeType();
        
        api.Class("VkAccelerationStructureSRTMotionInstanceNV")
            .WithField("flags")
            .InterpretAsCustomType("VkGeometryInstanceFlagBitsKHR")
            .ChangeType();
        
        api.Class("VkAcquireProfilingLockInfoKHR")
            .WithField("flags")
            .InterpretAsCustomType("VkAcquireProfilingLockFlagBitsKHR")
            .ChangeType();
        
        api.Class("VkAttachmentDescription")
            .WithField("flags")
            .InterpretAsCustomType("VkAttachmentDescriptionFlagBits")
            .ChangeType();
        
        api.Class("VkAttachmentDescription2")
            .WithField("flags")
            .InterpretAsCustomType("VkAttachmentDescriptionFlagBits")
            .ChangeType();
        
        api.Class("VkBufferCreateInfo")
            .WithField("flags")
            .InterpretAsCustomType("VkBufferCreateFlagBits")
            .ChangeType()
            .WithField("usage")
            .InterpretAsCustomType("VkBufferUsageFlagBits")
            .ChangeType();
        
        api.Class("VkBufferViewCreateInfo")
            .WithField("flags")
            .InterpretAsCustomType("VkBufferUsageFlagBits")
            .ChangeType();
        
        api.Class("VkCommandBufferBeginInfo")
            .WithField("flags")
            .InterpretAsCustomType("VkCommandBufferUsageFlagBits")
            .ChangeType();
        
        api.Class("VkCommandBufferInheritanceRenderingInfo")
            .WithField("flags")
            .InterpretAsCustomType("VkRenderingFlagBits")
            .ChangeType();
        
        api.Class("VkCommandPoolCreateInfo")
            .WithField("flags")
            .InterpretAsCustomType("VkCommandPoolCreateFlagBits")
            .ChangeType();
        
        api.Class("VkPipelineLayoutCreateInfo")
            .WithField("flags")
            .InterpretAsCustomType("VkPipelineLayoutCreateFlagBits")
            .ChangeType();

        api.Class("VkPipelineRasterizationStateCreateInfo")
            .WithField("cullMode")
            .InterpretAsCustomType("VkCullModeFlagBits")
            .ChangeType();
        
        api.Class("VkImageCreateInfo")
            .WithField("flags")
            .InterpretAsCustomType("VkImageCreateFlagBits")
            .ChangeType()
            .WithField("usage")
            .InterpretAsCustomType("VkImageUsageFlagBits")
            .ChangeType();

        api.Class("VkDebugUtilsMessengerCreateInfoEXT")
            .WithField("messageSeverity")
            .InterpretAsCustomType("VkDebugUtilsMessageSeverityFlagBitsEXT")
            .ChangeType()
            .WithField("messageType")
            .InterpretAsCustomType("VkDebugUtilsMessageTypeFlagBitsEXT")
            .ChangeType();

        api.Class("VkImageSubresourceRange")
            .WithField("aspectMask")
            .InterpretAsCustomType("VkImageAspectFlagBits")
            .ChangeType();

        api.Class("VkImageMemoryBarrier")
            .WithField("srcAccessMask")
            .InterpretAsCustomType("VkAccessFlagBits")
            .ChangeType()
            .WithField("dstAccessMask")
            .InterpretAsCustomType("VkAccessFlagBits")
            .ChangeType();
        
        api.Class("VkImageSubresourceLayers")
            .WithField("aspectMask")
            .InterpretAsCustomType("VkImageAspectFlagBits")
            .ChangeType();
        
        api.Class("VkFenceCreateInfo")
            .WithField("flags")
            .InterpretAsCustomType("VkFenceCreateFlagBits")
            .ChangeType();
        
        api.Class("VkSubmitInfo")
            .WithField("pWaitDstStageMask")
            .InterpretAsPointerToArray(new CustomType("VkPipelineStageFlagBits"), arraySizeSource: "waitSemaphoreCount")
            .ChangeType();
        
        api.Class("VkSwapchainCreateInfoKHR")
            .WithField("imageUsage")
            .InterpretAsCustomType("VkImageUsageFlagBits")
            .ChangeType();
        
        api.Class("VkDescriptorSetLayoutBinding")
            .WithField("stageFlags")
            .InterpretAsCustomType("VkShaderStageFlagBits")
            .ChangeType();
        
        api.Class("VkPipelineColorBlendAttachmentState")
            .WithField("colorWriteMask")
            .InterpretAsCustomType("VkColorComponentFlagBits")
            .ChangeType();
        
        api.Class("VkQueueFamilyProperties")
            .WithField("queueFlags")
            .InterpretAsCustomType("VkQueueFlagBits")
            .ChangeType();

        var fixingFunctionParameters = new PostProcessingApiPass(api);
        ctx.AddPreGeneratorPass(fixingFunctionParameters, ExecutionPassKind.PerTranslationUnit);
    }
}