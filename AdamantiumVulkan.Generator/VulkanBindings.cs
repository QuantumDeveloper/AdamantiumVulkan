using System;
using System.Collections.Generic;
using QuantumBinding.Generator;
using QuantumBinding.Generator.AST;
using QuantumBinding.Generator.ProcessingFluentApi;
using QuantumBinding.Generator.Processors;
using QuantumBinding.Generator.Types;

namespace AdamantiumVulkan.Generator;

public static partial class VulkanBindings
{
    public static void ProvideFunctionsForParametersFix(ProcessingContext ctx)
    {
        var api = new PostProcessingApi();

        api.Class("VkFramebufferAttachmentImageInfoKHR").WithField("pViewFormats")
            .InterpretAsPointerToArray(new CustomType("vkFormat"), true, "viewFormatCount");

        api.Class("VkInstanceCreateInfo")
            .WithField("ppEnabledLayerNames")
            .InterpretAsPointerToArray(new BuiltinType(PrimitiveType.Sbyte), arraySizeSource: "enabledLayerCount")
            .WithField("ppEnabledExtensionNames")
            .InterpretAsPointerToArray(new BuiltinType(PrimitiveType.Sbyte), arraySizeSource: "enabledExtensionCount");
        
        api.Class("VkDeviceCreateInfo")
            .WithField("ppEnabledLayerNames")
            .InterpretAsPointerToArray(new BuiltinType(PrimitiveType.Sbyte), arraySizeSource: "enabledLayerCount")
            .WithField("ppEnabledExtensionNames")
            .InterpretAsPointerToArray(new BuiltinType(PrimitiveType.Sbyte), arraySizeSource: "enabledExtensionCount");

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

        api.Function("vkGetPhysicalDeviceSurfaceSupportKHR")
            .WithParameterName("pSupported")
            .InterpretAsIs()
            .SetParameterKind(ParameterKind.Out);
        
        api.Function("vkGetMemoryWin32HandleKHR")
            .WithParameterName("pHandle")
            .InterpretAsPointerType(new BuiltinType(PrimitiveType.IntPtr))
            .SetParameterKind(ParameterKind.Out);
        
        api.Function("vkGetInstanceProcAddr").WithReturnType(new PointerType() { Pointee = new BuiltinType(PrimitiveType.Void)});
        api.Function("vkGetDeviceProcAddr").WithReturnType(new PointerType() { Pointee = new BuiltinType(PrimitiveType.Void)});

        api.Function("shaderc_result_get_bytes").WithReturnType(new BuiltinType(PrimitiveType.IntPtr));

        api.Function("spvc_context_parse_spirv").WithParameterName("spirv")
            .InterpretAsPointerToArray(new BuiltinType(PrimitiveType.Byte));

        api.Function("spvc_resources_get_resource_list_for_type")
            .WithParameterName("resource_list")
            .InterpretAsPointerToArray(new CustomType("SpvcReflectedResource"), true, "resource_size", pointerDepth: 2)
            .SetParameterKind(ParameterKind.Out)
            .WithParameterName("resource_size")
            .InterpretAsIs()
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

        api.Delegate("PFN_vkGetInstanceProcAddr").WithReturnType(new PointerType() {Pointee = new BuiltinType(PrimitiveType.Void)});
        api.Delegate("PFN_vkGetDeviceProcAddr").WithReturnType(new PointerType() {Pointee = new BuiltinType(PrimitiveType.Void)});
        
        api.Delegate("PFN_vkVoidFunction").WithReturnType(new PointerType() {Pointee = new BuiltinType(PrimitiveType.Void)});
        api.Delegate("PFN_vkDebugUtilsMessengerCallbackEXT")
            .WithParameterName("messageTypes")
            .ChangeType(new CustomType("VkDebugUtilsMessageTypeFlagBitsEXT"));
        
        // api.Delegate("PFN_vkCreateInstance").WithParameterName("pInstance").InterpretAsIs()
        //     .SetParameterKind(ParameterKind.In);

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

        api.Classes(structsList).AddField("pointer")
            .SetType(new PointerType() { Pointee = new BuiltinType(PrimitiveType.Void) });

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

        api.Classes(classesList).AddProperty("NativePointer")
            .SetField("__Instance.pointer")
            .SetType(new PointerType() { Pointee = new BuiltinType(PrimitiveType.Void) })
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