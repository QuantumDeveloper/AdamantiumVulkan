using QuantumBinding.Generator;
using QuantumBinding.Generator.AST;
using QuantumBinding.Generator.CodeGeneration;
using QuantumBinding.Generator.ProcessingFluentApi;
using QuantumBinding.Generator.Processors;
using QuantumBinding.Generator.Types;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace AdamantiumVulkan.Generator
{
    public class VulkanBindingGenerator : QuantumBindingGenerator
    {
        private Module vkMainModule;
        private Module shaderModule;
        public override void OnSetup(BindingOptions options)
        {
            string library = "vulkan-1";
            var appRoot = AppContext.BaseDirectory.Substring(0, AppContext.BaseDirectory.LastIndexOf("bin"));
            string mainPath = Path.GetFullPath(Path.Combine(appRoot, "..\\", "AdamantiumVulkan", "Generated"));
            string corePath = Path.GetFullPath(Path.Combine(appRoot, "..\\", "AdamantiumVulkan.Core", "Generated"));
            string windowsPath = Path.GetFullPath(Path.Combine(appRoot, "..\\", "AdamantiumVulkan.Windows", "Generated"));
            string shadersPath = Path.GetFullPath(Path.Combine(appRoot, "..\\", "AdamantiumVulkan.Shaders", "Generated"));

            options.GenerateSequentialLayout = true;
            options.DebugMode = true;
            options.ConvertRules.PodTypesAsSimpleTypes = true;
            vkMainModule = options.AddModule(library);
            vkMainModule.Defines.Add("VK_USE_PLATFORM_WIN32_KHR");
            vkMainModule.Defines.Add("_WIN32");
            vkMainModule.Files.Add(@"C:\VulkanSDK\1.1.101.0\Include\vulkan\vulkan.h");
            vkMainModule.ForceCallingConvention = true;
            vkMainModule.CallingConvention = CallingConvention.StdCall;
            vkMainModule.AllowConvertStructToClass = true;
            vkMainModule.MethodClassName = "VulkanNative";
            vkMainModule.InteropClassName = "VulkanInterop";
            vkMainModule.OutputFileName = "AdamantiumVulkan";
            vkMainModule.OutputNamespace = "AdamantiumVulkan";
            vkMainModule.SuppressUnmanagedCodeSecurity = false;
            vkMainModule.AddNamespaceMapping("vulkan_core", "Core", corePath);
            vkMainModule.AddNamespaceMapping("vulkan_win32", "Windows", windowsPath);
            vkMainModule.WrapInteropObjects = true;
            vkMainModule.GenerateOverloadsForArrayParams = true;
            vkMainModule.OutputPath = mainPath;

            shaderModule = options.AddModule(library);
            shaderModule.Files.Add(@"C:\VulkanSDK\1.1.101.0\Include\shaderc\shaderc.h");
            shaderModule.Defines.Add("SHADERC_SHAREDLIB");
            shaderModule.Defines.Add("_WIN32");
            shaderModule.Defines.Add("SHADERC_IMPLEMENTATION");
            shaderModule.ForceCallingConvention = true;
            shaderModule.CallingConvention = CallingConvention.StdCall;
            shaderModule.AllowConvertStructToClass = true;
            shaderModule.MethodClassName = "VulkanShadersNative";
            shaderModule.InteropClassName = "VulkanShadersInterop";
            shaderModule.GeneratorSpecializations = GeneratorSpecializations.All;
            shaderModule.OutputFileName = "AdamantiumVulkan.Shaders";
            shaderModule.OutputNamespace = "AdamantiumVulkan.Shaders";
            shaderModule.SuppressUnmanagedCodeSecurity = false;
            shaderModule.WrapInteropObjects = true;
            shaderModule.GenerateOverloadsForArrayParams = true;
            shaderModule.OutputPath = shadersPath;

            Module.UtilsOutputName = "Utils";
            Module.UtilsNamespace = vkMainModule.OutputNamespace;
            Module.GenerateUtilsForModule = vkMainModule;
        }

        public override void OnSetupPostProcessing(ProcessingContext context)
        {
            AddFunctionsToFix(context);
            foreach (var module in context.Options.Modules)
            {
                if (module.GenerateOverloadsForArrayParams)
                {
                    context.AddPreGeneratorPass(new GenerateFunctionOverloadsPass(), ExecutionPassKind.PerTranslationUnit, module);
                }
            }
            context.AddPreGeneratorPass(new FunctionToInstanceMethodAction(), ExecutionPassKind.PerTranslationUnit);
            context.AddPreGeneratorPass(new ForceCallingConventionPass(CallingConvention.StdCall), ExecutionPassKind.PerTranslationUnit);
            context.AddPreGeneratorPass(new CheckFlagEnumsPass(), ExecutionPassKind.PerTranslationUnit);
            context.AddPreGeneratorPass(new EnumItemsRenamePass(CasePattern.PascalCase, "VkFormat"), ExecutionPassKind.PerTranslationUnit);
            context.AddPreGeneratorPass(new EnumItemsExcludePass(ExcludeCheck.StartsWithIgnoreCase, "BeginRange", "EndRange"), ExecutionPassKind.PerTranslationUnit);

            var renameTargets = RenameTargets.Any;
            renameTargets &= ~RenameTargets.Function & ~RenameTargets.Struct;
            context.AddPreGeneratorPass(new CaseRenamePass(renameTargets, CasePattern.PascalCase), ExecutionPassKind.PerTranslationUnit, shaderModule);
            context.AddPreGeneratorPass(new PrepareStructsBeforeWrappingPass(null), ExecutionPassKind.PerTranslationUnit);

            var disposableList = new List<DisposableExtension>();
            disposableList.Add(new DisposableExtension() { Name = "Instance", DisposableContent = "DestroyInstance();" });
            disposableList.Add(new DisposableExtension() { Name = "Device", DisposableContent = "DestroyDevice();" });

            var disposable = new DisposableExtensionPass(disposableList.ToArray()) { OutputFileName = "Extensions"};
            context.AddCodeGenerationPass(disposable, ExecutionPassKind.PerTranslationUnit);

            var macroAction = new MacroFunctionsToCSharpFunctionsPass();
            macroAction.IgnoreList.Add("VK_USE_PLATFORM_WIN32_KHR");
            macroAction.IgnoreList.Add("_WIN32");
            macroAction.IgnoreList.Add("VULKAN_H_");
            macroAction.IgnoreList.Add("VKAPI_CALL");
            macroAction.IgnoreList.Add("VULKAN_CORE_H_");
            macroAction.IgnoreList.Add("VKAPI_PTR");
            macroAction.IgnoreList.Add("VK_NULL_HANDLE");
            macroAction.IgnoreList.Add("VK_DEFINE_HANDLE");
            macroAction.IgnoreList.Add("VK_DEFINE_NON_DISPATCHABLE_HANDLE");
            macroAction.IgnoreList.Add("SHADERC_EXPORT");
            macroAction.IgnoreList.Add("SHADERC_IMPLEMENTATION");
            macroAction.IgnoreList.Add("SHADERC_SHAREDLIB");

            macroAction.SubstitutionList.Add("VK_MAKE_VERSION", CreateMakeVersionFunction());
            macroAction.SubstitutionList.Add("VK_VERSION_MAJOR", CreateVersionFor("major"));
            macroAction.SubstitutionList.Add("VK_VERSION_MINOR", CreateVersionFor("minor"));
            macroAction.SubstitutionList.Add("VK_VERSION_PATCH", CreateVersionFor("patch"));
            macroAction.SubstitutionList.Add("VK_API_VERSION_1_0", CreateApiVersion());
            macroAction.SubstitutionList.Add("VK_API_VERSION_1_1", CreateApiVersion());
            macroAction.SubstitutionList.Add("VK_QUEUE_FAMILY_EXTERNAL_KHR", CreateApiVersion());
            macroAction.SubstitutionList.Add("VK_QUEUE_FAMILY_EXTERNAL", CreateApiVersion());
            macroAction.SubstitutionList.Add("VK_QUEUE_FAMILY_FOREIGN_EXT", CreateApiVersion());
            context.AddPreGeneratorPass(macroAction, ExecutionPassKind.PerTranslationUnit);
        }

        public override void OnSetupComplete(ProcessingContext context)
        {
            var renameTargets = RenameTargets.Any;
            renameTargets &= ~RenameTargets.Function & ~RenameTargets.Struct & ~RenameTargets.Union;
            context.AddPreGeneratorPass(new RegexRenamePass("^vk", "", renameTargets, true), ExecutionPassKind.PerTranslationUnit);
        }

        private MacroFunction CreateMakeVersionFunction()
        {
            var function = new MacroFunction();
            var major = new Parameter() { Type = new BuiltinType(PrimitiveType.Byte), Name = "major" };
            var minor = new Parameter() { Type = new BuiltinType(PrimitiveType.Byte), Name = "minor" };
            var patch = new Parameter() { Type = new BuiltinType(PrimitiveType.Byte), Name = "patch" };
            function.Parameters.Add(major);
            function.Parameters.Add(minor);
            function.Parameters.Add(patch);
            function.FunctionBody = $"var version = major << 22 | minor << 12 | patch;{Environment.NewLine}return (uint)version ;";
            function.ReturnType = new BuiltinType(PrimitiveType.UInt32);

            return function;
        }

        private MacroFunction CreateApiVersion()
        {
            var function = new MacroFunction();
            function.ReturnType = new BuiltinType(PrimitiveType.UInt32);
            function.ApplyOnlyReturnType = true;
            return function;
        }

        private MacroFunction CreateVersionFor(string paramName)
        {
            var function = new MacroFunction();
            var param = new Parameter() { Type = new BuiltinType(PrimitiveType.Byte), Name = paramName };
            function.Parameters.Add(param);
            function.FunctionBody = $"return (uint)({paramName}>>22);";
            function.ReturnType = new BuiltinType(PrimitiveType.UInt32);

            return function;
        }

        private void AddFunctionsToFix(ProcessingContext ctx)
        {
            PostProcessingApi api = new PostProcessingApi();
            api.Function("vkEnumerateInstanceExtensionProperties").
                WithParameterName("pProperties").
                TreatAsPointerToArray(new CustomType("VkExtensionProperties")).
                SetParameterKind(ParameterKind.InOut);

            api.Function("vkEnumerateInstanceLayerProperties").
                WithParameterName("pProperties").
                TreatAsPointerToArray(new CustomType("VkLayerProperties")).
                SetParameterKind(ParameterKind.InOut);

            api.Function("vkEnumeratePhysicalDevices").
                WithParameterName("pPhysicalDevices").
                TreatAsPointerToArray(new CustomType("VkPhysicalDevice")).
                SetParameterKind(ParameterKind.InOut);

            api.Function("VkGetPhysicalDeviceProperties").
                WithParameterName("pProperties").
                TreatAsIs().
                SetParameterKind(ParameterKind.Out);

            api.Function("VkGetPhysicalDeviceFeatures").
                WithParameterName("pFeatures").
                TreatAsIs().
                SetParameterKind(ParameterKind.Out);

            api.Function("vkCmdBindTransformFeedbackBuffersEXT").
                WithParameterName("pOffsets").
                TreatAsPointerToArray(new BuiltinType(PrimitiveType.UInt64)).
                SetParameterKind(ParameterKind.InOut);

            api.Function("vkCmdBindTransformFeedbackBuffersEXT").
                WithParameterName("pSizes").
                TreatAsPointerToArray(new BuiltinType(PrimitiveType.UInt64)).
                SetParameterKind(ParameterKind.InOut);

            api.Function("VkCmdBeginTransformFeedbackEXT").
                WithParameterName("pCounterBufferOffsets").
                TreatAsPointerToArray(new BuiltinType(PrimitiveType.UInt64)).
                SetParameterKind(ParameterKind.InOut);

            api.Function("VkCmdEndTransformFeedbackEXT").
                WithParameterName("pCounterBufferOffsets").
                TreatAsPointerToArray(new BuiltinType(PrimitiveType.UInt64)).
                SetParameterKind(ParameterKind.InOut);

            api.Function("vkCmdBindVertexBuffers").
                WithParameterName("pOffsets").
                TreatAsPointerToArray(new BuiltinType(PrimitiveType.UInt64)).
                SetParameterKind(ParameterKind.InOut);

            api.Functions("vkGetPhysicalDeviceMemoryProperties", "vkGetPhysicalDeviceMemoryProperties2", "vkGetPhysicalDeviceMemoryProperties2KHR").
                WithParameterName("pMemoryProperties").
                TreatAsIs().
                SetParameterKind(ParameterKind.Out);

            api.Function("vkGetPhysicalDeviceQueueFamilyProperties").
                WithParameterName("pQueueFamilyProperties").
                TreatAsPointerToArray(new CustomType("VkQueueFamilyProperties")).
                SetParameterKind(ParameterKind.InOut);

            api.Function("vkGetPhysicalDeviceQueueFamilyProperties2").
                WithParameterName("pQueueFamilyProperties").
                TreatAsPointerToArray(new CustomType("VkQueueFamilyProperties2")).
                SetParameterKind(ParameterKind.InOut);


            api.Delegate("PFN_vkGetInstanceProcAddr").WithReturnType(new BuiltinType(PrimitiveType.Void));
            api.Delegate("PFN_vkGetDeviceProcAddr").WithReturnType(new BuiltinType(PrimitiveType.Void));

            api.AllFunctions().
                WithParameterType("VkAllocationCallbacks").
                TreatAsPointerType().
                SetNullable(true).
                SetDelegateNullable(true).
                SetParameterKind(ParameterKind.Readonly);

            api.Functions("vkDestroyInstance", "vkDestroyDevice").WithParameterName("pAllocator").TreatAsIs().SetDefaultValue("null");

            var structsList = new List<string>();
            structsList.Add("VkInstance_T");
            structsList.Add("VkPhysicalDevice_T");
            structsList.Add("VkDevice_T");
            structsList.Add("VkQueue_T");
            structsList.Add("VkSemaphore_T");
            structsList.Add("VkCommandBuffer_T");
            structsList.Add("VkFence_T");
            structsList.Add("VkDeviceMemory_T");
            structsList.Add("VkBuffer_T");
            structsList.Add("VkImage_T");
            structsList.Add("VkEvent_T");
            structsList.Add("VkQueryPool_T");
            structsList.Add("VkBufferView_T");
            structsList.Add("VkImageView_T");
            structsList.Add("VkShaderModule_T");
            structsList.Add("VkPipelineCache_T");
            structsList.Add("VkPipelineLayout_T");
            structsList.Add("VkRenderPass_T");
            structsList.Add("VkPipeline_T");
            structsList.Add("VkDescriptorSetLayout_T");
            structsList.Add("VkSampler_T");
            structsList.Add("VkDescriptorPool_T");
            structsList.Add("VkDescriptorSet_T");
            structsList.Add("VkFramebuffer_T");
            structsList.Add("VkCommandPool_T");
            structsList.Add("VkSamplerYcbcrConversion_T");
            structsList.Add("VkDescriptorUpdateTemplate_T");
            structsList.Add("VkSurfaceKHR_T");
            structsList.Add("VkSwapchainKHR_T");
            structsList.Add("VkDisplayKHR_T");
            structsList.Add("VkDisplayModeKHR_T");
            structsList.Add("VkDescriptorUpdateTemplateKHR_T");
            structsList.Add("VkSamplerYcbcrConversionKHR_T");
            structsList.Add("VkDebugReportCallbackEXT_T");
            structsList.Add("VkObjectTableNVX_T");
            structsList.Add("VkIndirectCommandsLayoutNVX_T");
            structsList.Add("VkDebugUtilsMessengerEXT_T");
            structsList.Add("VkValidationCacheEXT_T");
            structsList.Add("VkAccelerationStructureNV_T");

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

            var defaultParamFunctions = new string[]
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

            api.Functions(defaultParamFunctions).WithParameterName("pAllocator").TreatAsIs().SetDefaultValue("null");

            api.Function("vkGetPhysicalDeviceSurfaceCapabilitiesKHR").WithParameterName("pSurfaceCapabilities").TreatAsIs().SetParameterKind(ParameterKind.Out);

            api.Function("vkGetPhysicalDeviceSurfaceFormatsKHR").
                WithParameterName("pSurfaceFormats").
                TreatAsPointerToArray(new CustomType("VkSurfaceFormatKHR")).
                SetParameterKind(ParameterKind.InOut);

            api.Function("vkGetPhysicalDeviceSurfacePresentModesKHR").
                WithParameterName("pPresentModes").
                TreatAsPointerToArray(new CustomType("VkPresentModeKHR")).
                SetParameterKind(ParameterKind.InOut);

            api.Function("vkGetSwapchainImagesKHR").
                WithParameterName("pSwapchainImages").
                TreatAsPointerToArray(new CustomType("VkImage")).
                SetParameterKind(ParameterKind.InOut);

            api.Function("vkGetInstanceProcAddr").WithReturnType(new BuiltinType(PrimitiveType.IntPtr));
            api.Function("vkGetDeviceProcAddr").WithReturnType(new BuiltinType(PrimitiveType.IntPtr));

            api.Function("vkAllocateCommandBuffers").
                WithParameterName("pCommandBuffers").
                TreatAsPointerToArray(new CustomType("VkCommandBuffer")).
                SetParameterKind(ParameterKind.InOut);

            api.Function("vkWaitForFences").
                WithParameterName("pFences").
                TreatAsPointerToArray(new CustomType("VkFence")).
                SetParameterKind(ParameterKind.In);

            api.Function("vkResetFences").
                WithParameterName("pFences").
                TreatAsPointerToArray(new CustomType("VkFence")).
                SetParameterKind(ParameterKind.In);

            api.Function("vkQueueSubmit").
                WithParameterName("pSubmits").
                TreatAsPointerToArray(new CustomType("VkSubmitInfo")).
                SetParameterKind(ParameterKind.In);

            api.Function("vkFreeCommandBuffers").
                WithParameterName("pCommandBuffers").
                TreatAsPointerToArray(new CustomType("VkCommandBuffer")).
                SetParameterKind(ParameterKind.In);

            api.Functions("vKGetBufferMemoryRequirements", "vKGetImageMemoryRequirements")
                .WithParameterName("pMemoryRequirements")
                .TreatAsIs()
                .SetParameterKind(ParameterKind.Out);

            api.Function("vkCmdBindVertexBuffers")
                .WithParameterName("pBuffers")
                .TreatAsPointerToArray(new CustomType("VkBuffer"), true)
                .SetParameterKind(ParameterKind.In);

            api.Function("vkCmdCopyBuffer")
                .WithParameterName("pRegions")
                .TreatAsPointerToArray(new CustomType("VkBufferCopy"))
                .SetParameterKind(ParameterKind.In);

            api.Functions("vkCreateGraphicsPipelines", "vkCreateComputePipelines")
                .WithParameterName("pPipelines")
                .TreatAsPointerToArray(new CustomType("VkPipeline"), true, "createInfoCount")
                .SetParameterKind(ParameterKind.Out);

            api.Function("vkCmdPipelineBarrier").
                WithParameterName("pMemoryBarriers").
                TreatAsPointerToArray(new CustomType("vkMemoryBarrier")).
                SetParameterKind(ParameterKind.In).
                WithParameterName("pBufferMemoryBarriers").
                TreatAsPointerToArray(new CustomType("vkBufferMemoryBarrier")).
                SetParameterKind(ParameterKind.In).
                WithParameterName("pImageMemoryBarriers").
                TreatAsPointerToArray(new CustomType("vkImageMemoryBarrier")).
                SetParameterKind(ParameterKind.In);

            api.Function("vkAllocateDescriptorSets").
                WithParameterName("pDescriptorSets").
                TreatAsPointerToArray(new CustomType("VkDescriptorSet_T")).
                SetParameterKind(ParameterKind.InOut);


            api.Classes(classesList).
                AddProperty("NativePointer").
                SetField("__Instance.pointer").
                SetType(propertyType).SetGetter(new Method());

            api.Class("VkBool32").SetUnderlyingType(new BuiltinType(PrimitiveType.Bool32));

            api.Class("VkDeviceCreateInfo").WithField("pQueueCreateInfos").TreatAsPointerToArray(new CustomType("VkDeviceQueueCreateInfo"), true, "queueCreateInfoCount");

            api.Class("VkSubmitInfo").WithField("pWaitSemaphores").TreatAsPointerToArray(new CustomType("VkSemaphore"), true, "waitSemaphoreCount")
                .WithField("pSignalSemaphores").TreatAsPointerToArray(new CustomType("VkSemaphore"), true, "signalSemaphoreCount")
                .WithField("pWaitDstStageMask").TreatAsPointerToArray(new BuiltinType(PrimitiveType.UInt32));

            api.Class("VkPresentInfoKHR")
                .WithField("pWaitSemaphores").TreatAsPointerToArray(new CustomType("VkSemaphore"), true, "waitSemaphoreCount")
                .WithField("pSwapchains").TreatAsPointerToArray(new CustomType("VkSwapchainKHR"), true, "swapchainCount")
                .WithField("pImageIndices")
                .TreatAsPointerToArray(new BuiltinType(PrimitiveType.UInt32), true, "swapchainCount")
                .WithField("pResults").
                TreatAsPointerToArray(new CustomType("VkResult"), true, "swapchainCount");

            api.Class("VkShaderModuleCreateInfo").WithField("pCode").TreatAsPointerToArray(new BuiltinType(PrimitiveType.Byte), true, "codeSize");

            api.Class("VkSwapchainCreateInfoKHR").WithField("pQueueFamilyIndices").TreatAsPointerToArray(new BuiltinType(PrimitiveType.UInt32), true, "queueFamilyIndexCount");

            api.Class("VkGraphicsPipelineCreateInfo")
                .WithField("pStages")
                .TreatAsPointerToArray(new CustomType("VkPipelineShaderStageCreateInfo"), true, "stageCount");

            api.Class("VkRenderPassBeginInfo")
                .WithField("pClearValues")
                .TreatAsPointerToArray(new CustomType("VkClearValue"), true, "clearValueCount");

            api.Class("VkPipelineVertexInputStateCreateInfo")
                .WithField("pVertexBindingDescriptions")
                .TreatAsPointerToArray(new CustomType("VkVertexInputBindingDescription"), true, "vertexBindingDescriptionCount")
                .WithField("pVertexAttributeDescriptions")
                .TreatAsPointerToArray(new CustomType("VkVertexInputAttributeDescription"), true, "vertexAttributeDescriptionCount");

            api.Class("VkSubmitInfo")
                .WithField("pCommandBuffers")
                .TreatAsPointerToArray(new CustomType("VkCommandBuffer"), true, "commandBufferCount");

            api.Class("VkPipelineDynamicStateCreateInfo").
                WithField("pDynamicStates").
                TreatAsPointerToArray(new CustomType("VkDynamicState"), true, "dynamicStateCount");

            api.Class("VkImageFormatListCreateInfoKHR").
                WithField("pViewFormats").
                TreatAsPointerToArray(new CustomType("VkFormat"), true, "viewFormatCount");

            api.Class("VkValidationFlagsEXT")
                .WithField("pDisabledValidationChecks").
                TreatAsPointerToArray(new CustomType("VkValidationCheckEXT"), true, "disabledValidationCheckCount");

            api.Class("VkObjectTableCreateInfoNVX")
                .WithField("pObjectEntryTypes").
                TreatAsPointerToArray(new CustomType("VkObjectEntryTypeNVX"), true, "objectCount")
                .WithField("pObjectEntryCounts").
                TreatAsPointerToArray(new BuiltinType(PrimitiveType.UInt32), true, "objectCount")
                .WithField("pObjectEntryUsageFlags").
                TreatAsPointerToArray(new BuiltinType(PrimitiveType.UInt32), true, "objectCount");

            api.Class("VkShadingRatePaletteNV")
                .WithField("pShadingRatePaletteEntries").
                TreatAsPointerToArray(new CustomType("VkShadingRatePaletteEntryNV"), true, "shadingRatePaletteEntryCount");

            api.Class("VkValidationFeaturesEXT")
                .WithField("pEnabledValidationFeatures").
                TreatAsPointerToArray(new CustomType("VkValidationFeatureEnableEXT"), true, "enabledValidationFeatureCount")
                .WithField("pDisabledValidationFeatures").
                TreatAsPointerToArray(new CustomType("VkValidationFeatureDisableEXT"), true, "disabledValidationFeatureCount");

            api.Class("VkDescriptorSetAllocateInfo").
                WithField("pSetLayouts").
                TreatAsPointerToArray(new CustomType("VkDescriptorSetLayout"), true, "descriptorSetCount");

            var fixingFunctionParameters = new FixIncorrectParametersPass(api);
            ctx.AddPreGeneratorPass(fixingFunctionParameters, ExecutionPassKind.PerTranslationUnit);
        }
    }

}
