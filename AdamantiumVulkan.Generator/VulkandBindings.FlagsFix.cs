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
            .ChangeType(new CustomType("VkMemoryPropertyFlagBits"));

        api.Class("VkMemoryHeap")
            .WithField("flags")
            .ChangeType(new CustomType("VkMemoryHeapFlagBits"));
        
        api.Class("VkAccelerationStructureBuildGeometryInfoKHR")
            .WithField("flags")
            .ChangeType(new CustomType("VkBuildAccelerationStructureFlagBitsKHR"));
        
        api.Class("VkAccelerationStructureGeometryKHR")
            .WithField("flags")
            .ChangeType(new CustomType("VkGeometryFlagBitsKHR"));
        
        api.Class("VkAccelerationStructureInfoNV")
            .WithField("flags")
            .ChangeType(new CustomType("VkBuildAccelerationStructureFlagBitsKHR"));
        
        api.Class("VkAccelerationStructureInstanceKHR")
            .WithField("flags")
            .ChangeType(new CustomType("VkGeometryInstanceFlagBitsKHR"));
        
        api.Class("VkAccelerationStructureMatrixMotionInstanceNV")
            .WithField("flags")
            .ChangeType(new CustomType("VkGeometryInstanceFlagBitsKHR"));
        
        api.Class("VkAccelerationStructureMotionInfoNV")
            .WithField("flags")
            .ChangeType(new CustomType("VkAccelerationStructureMotionInstanceTypeNV"));
        
        api.Class("VkAccelerationStructureMotionInstanceNV")
            .WithField("flags")
            .ChangeType(new CustomType("VkAccelerationStructureMotionInstanceTypeNV"));
        
        api.Class("VkAccelerationStructureSRTMotionInstanceNV")
            .WithField("flags")
            .ChangeType(new CustomType("VkGeometryInstanceFlagBitsKHR"));
        
        api.Class("VkAcquireProfilingLockInfoKHR")
            .WithField("flags")
            .ChangeType(new CustomType("VkAcquireProfilingLockFlagBitsKHR"));
        
        api.Class("VkAttachmentDescription")
            .WithField("flags")
            .ChangeType(new CustomType("VkAttachmentDescriptionFlagBits"));
        
        api.Class("VkAttachmentDescription2")
            .WithField("flags")
            .ChangeType(new CustomType("VkAttachmentDescriptionFlagBits"));
        
        api.Class("VkBufferCreateInfo")
            .WithField("flags")
            .ChangeType(new CustomType("VkBufferCreateFlagBits"))
            .WithField("usage")
            .ChangeType(new CustomType("VkBufferUsageFlagBits"));
        
        api.Class("VkBufferViewCreateInfo")
            .WithField("flags")
            .ChangeType(new CustomType("VkBufferUsageFlagBits"));
        
        api.Class("VkCommandBufferBeginInfo")
            .WithField("flags")
            .ChangeType(new CustomType("VkCommandBufferUsageFlagBits"));
        
        api.Class("VkCommandBufferInheritanceRenderingInfo")
            .WithField("flags")
            .ChangeType(new CustomType("VkRenderingFlagBits"));
        
        api.Class("VkCommandPoolCreateInfo")
            .WithField("flags")
            .ChangeType(new CustomType("VkCommandPoolCreateFlagBits"));
        
        api.Class("VkPipelineLayoutCreateInfo")
            .WithField("flags")
            .ChangeType(new CustomType("VkPipelineLayoutCreateFlagBits"));

        api.Class("VkPipelineRasterizationStateCreateInfo")
            .WithField("cullMode")
            .ChangeType(new CustomType("VkCullModeFlagBits"));
        
        api.Class("VkImageCreateInfo")
            .WithField("flags")
            .ChangeType(new CustomType("VkImageCreateFlagBits"))
            .WithField("usage")
            .ChangeType(new CustomType("VkImageUsageFlagBits"));

        api.Class("VkDebugUtilsMessengerCreateInfoEXT")
            .WithField("messageSeverity")
            .ChangeType(new CustomType("VkDebugUtilsMessageSeverityFlagBitsEXT"))
            .WithField("messageType")
            .ChangeType(new CustomType("VkDebugUtilsMessageTypeFlagBitsEXT"));

        var fixingFunctionParameters = new PostProcessingApiPass(api);
        ctx.AddPreGeneratorPass(fixingFunctionParameters, ExecutionPassKind.PerTranslationUnit);
    }
}