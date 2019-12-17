using QuantumBinding.Generator;
using QuantumBinding.Generator.AST;
using QuantumBinding.Generator.BindingsMapping;
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
        private Module spivCrossModule;

        public override void OnSetup(BindingOptions options)
        {
            string vkMainLibrary = "vulkan-1";
            string shadercLibrary = "shaderc_shared";
            string spirvCrossLibrary = "spirv-cross-c-shared";
            string mainNamespace = "AdamantiumVulkan";

            var appRoot = AppContext.BaseDirectory.Substring(0, AppContext.BaseDirectory.LastIndexOf("bin"));
            string mainPath = Path.GetFullPath(Path.Combine(appRoot, "..", "AdamantiumVulkan", "Generated"));
            string corePath = Path.GetFullPath(Path.Combine(appRoot, "..", "AdamantiumVulkan.Core", "Generated"));
            string windowsPath = Path.GetFullPath(Path.Combine(appRoot, "..", "AdamantiumVulkan.Windows", "Generated"));
            string macOSPath = Path.GetFullPath(Path.Combine(appRoot, "..", "AdamantiumVulkan.MacOS", "Generated"));
            string shadersPath = Path.GetFullPath(Path.Combine(appRoot, "..", "AdamantiumVulkan.Shaders", "Generated"));
            string spirvPath = Path.GetFullPath(Path.Combine(appRoot, "..", "AdamantiumVulkan.SPIRV", "Generated"));
            string spirvCrossPath = Path.GetFullPath(Path.Combine(appRoot, "..", "AdamantiumVulkan.SPIRV.Cross", "Generated"));

            options.GenerateSequentialLayout = true;
            options.PodTypesAsSimpleTypes = true;
            options.PathToBindingsFile = "VulkanBindingsMap.xml";

            vkMainModule = options.AddModule(vkMainLibrary);
            vkMainModule.Name = "Core";
            vkMainModule.Defines.Add("_WIN32");
            vkMainModule.Defines.Add("VK_USE_PLATFORM_WIN32_KHR");
            vkMainModule.Defines.Add("VK_USE_PLATFORM_MACOS_MVK");
            vkMainModule.Files.Add(@"M:\VulkanSDK\1.1.126.0\Include\vulkan\vulkan.h");
            vkMainModule.ForceCallingConvention = true;
            vkMainModule.CallingConvention = CallingConvention.Winapi;
            vkMainModule.AllowConvertStructToClass = true;
            vkMainModule.MethodClassName = "VulkanNative";
            vkMainModule.InteropClassName = "VulkanInterop";
            vkMainModule.OutputFileName = mainNamespace;
            vkMainModule.OutputNamespace = mainNamespace;
            vkMainModule.SuppressUnmanagedCodeSecurity = false;
            vkMainModule.AddNamespaceMapping("vulkan_core", "Core", corePath);
            vkMainModule.AddNamespaceMapping("vulkan_win32", "Windows", windowsPath);
            vkMainModule.AddNamespaceMapping("vulkan_macos", "MacOS", macOSPath);
            vkMainModule.WrapInteropObjects = true;
            vkMainModule.GenerateOverloadsForArrayParams = true;
            vkMainModule.OutputPath = mainPath;

            shaderModule = options.AddModule(shadercLibrary);
            shaderModule.Name = "Shaders";
            shaderModule.Files.Add(@"M:\VulkanSDK\1.1.121.1\Include\shaderc\shaderc.h");
            shaderModule.Defines.Add("SHADERC_SHAREDLIB");
            shaderModule.Defines.Add("_WIN32");
            shaderModule.Defines.Add("SHADERC_IMPLEMENTATION");
            shaderModule.ForceCallingConvention = true;
            shaderModule.CallingConvention = CallingConvention.Winapi;
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

            var spirvCrossSpecs = GeneratorSpecializations.All;
            spirvCrossSpecs &= ~GeneratorSpecializations.Constants;
            spivCrossModule = options.AddModule(spirvCrossLibrary);
            spivCrossModule.Name = "Spirv-Cross";
            spivCrossModule.Files.Add(@"M:\GitHUB\ShadersVulkan\spirv-cross\include\spirv_cross_c.h");
            spivCrossModule.Defines.Add("SPVC_EXPORT_SYMBOLS");
            spivCrossModule.Defines.Add("_MSC_VER");
            spivCrossModule.ForceCallingConvention = true;
            spivCrossModule.CallingConvention = CallingConvention.Winapi;
            spivCrossModule.AllowConvertStructToClass = true;
            spivCrossModule.MethodClassName = "SpirvCrossNative";
            spivCrossModule.InteropClassName = "SpirvCrossInterop";
            spivCrossModule.GeneratorSpecializations = spirvCrossSpecs;
            spivCrossModule.OutputFileName = "AdamantiumVulkan.SPIRV.Cross";
            spivCrossModule.OutputNamespace = "AdamantiumVulkan.SPIRV.Cross";
            spivCrossModule.SuppressUnmanagedCodeSecurity = false;
            spivCrossModule.AddNamespaceMapping("spirv", "AdamantiumVulkan.SPIRV", spirvPath, true);
            spivCrossModule.WrapInteropObjects = true;
            spivCrossModule.CharAsBoolForMethods = true;
            spivCrossModule.OutputPath = spirvCrossPath;

            Module.UtilsOutputName = "Utils";
            Module.UtilsNamespace = mainNamespace;
            Module.GenerateUtilsForModule = vkMainModule;
        }

        public override void OnBeforeSetupPasses(ProcessingContext context)
        {
            AddFunctionsToFix(context);
        }

        public override void OnSetupPostProcessing(ProcessingContext context)
        {
            context.AddPreGeneratorPass(new FunctionToInstanceMethodAction(), ExecutionPassKind.PerTranslationUnit);
            context.AddPreGeneratorPass(new ForceCallingConventionPass(CallingConvention.Winapi), ExecutionPassKind.PerTranslationUnit);
            context.AddPreGeneratorPass(new CheckFlagEnumsPass(), ExecutionPassKind.PerTranslationUnit);
            context.AddPreGeneratorPass(new EnumItemsCleanupPass(), ExecutionPassKind.PerTranslationUnit);
            context.AddPreGeneratorPass(new EnumItemsRenamePass(CasePattern.PascalCase, "VkFormat"), ExecutionPassKind.PerTranslationUnit);
            context.AddPreGeneratorPass(new EnumItemsExcludePass(ExcludeCheck.StartsWithIgnoreCase, "BeginRange", "EndRange"), ExecutionPassKind.PerTranslationUnit);

            var renameTargets = RenameTargets.Any;
            renameTargets &= ~RenameTargets.Function & ~RenameTargets.Struct;

            var shadercRenameItems = new List<RegexRenameRunItem>()
            {
                new RegexRenameRunItem("^shaderc_compile_options", string.Empty, RenameTargets.Method, true),
                new RegexRenameRunItem("^shaderc_result", string.Empty, RenameTargets.Method, true),
                new RegexRenameRunItem("^shaderc", string.Empty, RenameTargets.Method, true),
            };
            context.AddPreGeneratorPass(new SequentialRegexRenamePass(shadercRenameItems.ToArray()), ExecutionPassKind.PerTranslationUnit, shaderModule);

            var spvcRenameItems = new List<RegexRenameRunItem>()
            {
                new RegexRenameRunItem("^spvc_resources", string.Empty, RenameTargets.Method, true),
                new RegexRenameRunItem("^spvc_compiler_options", string.Empty, RenameTargets.Method, true),
                new RegexRenameRunItem("^spvc_compiler", string.Empty, RenameTargets.Method, true),
                new RegexRenameRunItem("^spvc_constant", string.Empty, RenameTargets.Method, true),
                new RegexRenameRunItem("^spvc_context", string.Empty, RenameTargets.Method, true),
                new RegexRenameRunItem("^spvc_type", string.Empty, RenameTargets.Method, true),
                new RegexRenameRunItem("^spvc", string.Empty, RenameTargets.Method, true),
            };

            context.AddPreGeneratorPass(new SequentialRegexRenamePass(spvcRenameItems.ToArray()), ExecutionPassKind.PerTranslationUnit, spivCrossModule);

            context.AddPreGeneratorPass(new CaseRenamePass(renameTargets, CasePattern.PascalCase), ExecutionPassKind.PerTranslationUnit, shaderModule);
            context.AddPreGeneratorPass(new CaseRenamePass(renameTargets, CasePattern.PascalCase), ExecutionPassKind.PerTranslationUnit, spivCrossModule);

            var predefinedValues = CreatePredefinedValues();
            context.AddPreGeneratorPass(new PrepareStructsBeforeWrappingPass(predefinedValues), ExecutionPassKind.PerTranslationUnit);

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
            var vkRenameItems = new List<RegexRenameRunItem>()
            {
                new RegexRenameRunItem("^vkCmd", string.Empty, renameTargets, true),
                new RegexRenameRunItem("^vk", string.Empty, renameTargets, true),
            };
            context.AddPreGeneratorPass(new SequentialRegexRenamePass(vkRenameItems.ToArray()), ExecutionPassKind.PerTranslationUnit, vkMainModule);
        }

        private List<PredefinedValues> CreatePredefinedValues()
        {
            var predefinedValues = new List<PredefinedValues>();

            var values = new PredefinedValues() { StructType = "VkApplicationInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.ApplicationInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkInstanceCreateInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.InstanceCreateInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkDeviceQueueCreateInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.DeviceQueueCreateInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkDeviceCreateInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.DeviceCreateInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkSubmitInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.SubmitInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkMemoryAllocateInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.MemoryAllocateInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkMappedMemoryRange" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.MappedMemoryRange", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkBindSparseInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.BindSparseInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkFenceCreateInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.FenceCreateInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkSemaphoreCreateInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.SemaphoreCreateInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkEventCreateInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.EventCreateInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkQueryPoolCreateInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.QueryPoolCreateInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkBufferCreateInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.BufferCreateInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkBufferViewCreateInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.BufferViewCreateInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkImageCreateInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.ImageCreateInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkImageViewCreateInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.ImageViewCreateInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkShaderModuleCreateInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.ShaderModuleCreateInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPipelineCacheCreateInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PipelineCacheCreateInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPipelineShaderStageCreateInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PipelineShaderStageCreateInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPipelineVertexInputStateCreateInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PipelineVertexInputStateCreateInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPipelineInputAssemblyStateCreateInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PipelineInputAssemblyStateCreateInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPipelineTessellationStateCreateInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PipelineTessellationStateCreateInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPipelineViewportStateCreateInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PipelineViewportStateCreateInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPipelineRasterizationStateCreateInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PipelineRasterizationStateCreateInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPipelineMultisampleStateCreateInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PipelineMultisampleStateCreateInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPipelineDepthStencilStateCreateInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PipelineDepthStencilStateCreateInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPipelineColorBlendStateCreateInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PipelineColorBlendStateCreateInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPipelineDynamicStateCreateInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PipelineDynamicStateCreateInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkGraphicsPipelineCreateInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.GraphicsPipelineCreateInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkComputePipelineCreateInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.ComputePipelineCreateInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPipelineLayoutCreateInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PipelineLayoutCreateInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkSamplerCreateInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.SamplerCreateInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkDescriptorSetLayoutCreateInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.DescriptorSetLayoutCreateInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkDescriptorPoolCreateInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.DescriptorPoolCreateInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkDescriptorSetAllocateInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.DescriptorSetAllocateInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkWriteDescriptorSet" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.WriteDescriptorSet", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkCopyDescriptorSet" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.CopyDescriptorSet", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkFramebufferCreateInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.FramebufferCreateInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkRenderPassCreateInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.RenderPassCreateInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkCommandPoolCreateInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.CommandPoolCreateInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkCommandBufferAllocateInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.CommandBufferAllocateInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkCommandBufferInheritanceInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.CommandBufferInheritanceInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkCommandBufferBeginInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.CommandBufferBeginInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkMemoryBarrier" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.MemoryBarrier", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkBufferMemoryBarrier" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.BufferMemoryBarrier", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkImageMemoryBarrier" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.ImageMemoryBarrier", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkRenderPassBeginInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.RenderPassBeginInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceSubgroupProperties" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceSubgroupProperties", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkBindBufferMemoryInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.BindBufferMemoryInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkBindImageMemoryInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.BindImageMemoryInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDevice16BitStorageFeatures" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDevice16bitStorageFeatures", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkMemoryDedicatedRequirements" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.MemoryDedicatedRequirements", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkMemoryDedicatedAllocateInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.MemoryDedicatedAllocateInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkMemoryAllocateFlagsInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.MemoryAllocateFlagsInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkDeviceGroupRenderPassBeginInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.DeviceGroupRenderPassBeginInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkDeviceGroupCommandBufferBeginInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.DeviceGroupCommandBufferBeginInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkDeviceGroupSubmitInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.DeviceGroupSubmitInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkDeviceGroupBindSparseInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.DeviceGroupBindSparseInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkBindBufferMemoryDeviceGroupInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.BindBufferMemoryDeviceGroupInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkBindImageMemoryDeviceGroupInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.BindImageMemoryDeviceGroupInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceGroupProperties" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceGroupProperties", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkDeviceGroupDeviceCreateInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.DeviceGroupDeviceCreateInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkBufferMemoryRequirementsInfo2" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.BufferMemoryRequirementsInfo2", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkImageMemoryRequirementsInfo2" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.ImageMemoryRequirementsInfo2", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkImageSparseMemoryRequirementsInfo2" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.ImageSparseMemoryRequirementsInfo2", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkMemoryRequirements2" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.MemoryRequirements2", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkSparseImageMemoryRequirements2" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.SparseImageMemoryRequirements2", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceFeatures2" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceFeatures2", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceProperties2" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceProperties2", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkFormatProperties2" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.FormatProperties2", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkImageFormatProperties2" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.ImageFormatProperties2", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceImageFormatInfo2" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceImageFormatInfo2", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkQueueFamilyProperties2" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.QueueFamilyProperties2", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceMemoryProperties2" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceMemoryProperties2", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkSparseImageFormatProperties2" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.SparseImageFormatProperties2", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceSparseImageFormatInfo2" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceSparseImageFormatInfo2", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDevicePointClippingProperties" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDevicePointClippingProperties", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkRenderPassInputAttachmentAspectCreateInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.RenderPassInputAttachmentAspectCreateInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkImageViewUsageCreateInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.ImageViewUsageCreateInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPipelineTessellationDomainOriginStateCreateInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PipelineTessellationDomainOriginStateCreateInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkRenderPassMultiviewCreateInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.RenderPassMultiviewCreateInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceMultiviewFeatures" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceMultiviewFeatures", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceMultiviewProperties" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceMultiviewProperties", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceVariablePointersFeatures" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceVariablePointersFeatures", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceProtectedMemoryFeatures" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceProtectedMemoryFeatures", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceProtectedMemoryProperties" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceProtectedMemoryProperties", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkDeviceQueueInfo2" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.DeviceQueueInfo2", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkProtectedSubmitInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.ProtectedSubmitInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkSamplerYcbcrConversionCreateInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.SamplerYcbcrConversionCreateInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkSamplerYcbcrConversionInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.SamplerYcbcrConversionInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkBindImagePlaneMemoryInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.BindImagePlaneMemoryInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkImagePlaneMemoryRequirementsInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.ImagePlaneMemoryRequirementsInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceSamplerYcbcrConversionFeatures" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceSamplerYcbcrConversionFeatures", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkSamplerYcbcrConversionImageFormatProperties" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.SamplerYcbcrConversionImageFormatProperties", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkDescriptorUpdateTemplateCreateInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.DescriptorUpdateTemplateCreateInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceExternalImageFormatInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceExternalImageFormatInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkExternalImageFormatProperties" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.ExternalImageFormatProperties", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceExternalBufferInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceExternalBufferInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkExternalBufferProperties" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.ExternalBufferProperties", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceIDProperties" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceIdProperties", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkExternalMemoryImageCreateInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.ExternalMemoryImageCreateInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkExternalMemoryBufferCreateInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.ExternalMemoryBufferCreateInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkExportMemoryAllocateInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.ExportMemoryAllocateInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceExternalFenceInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceExternalFenceInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkExternalFenceProperties" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.ExternalFenceProperties", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkExportFenceCreateInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.ExportFenceCreateInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkExportSemaphoreCreateInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.ExportSemaphoreCreateInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceExternalSemaphoreInfo" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceExternalSemaphoreInfo", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkExternalSemaphoreProperties" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.ExternalSemaphoreProperties", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceMaintenance3Properties" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceMaintenance3Properties", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkDescriptorSetLayoutSupport" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.DescriptorSetLayoutSupport", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceShaderDrawParametersFeatures" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceShaderDrawParametersFeatures", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkSwapchainCreateInfoKHR" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.SwapchainCreateInfoKhr", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPresentInfoKHR" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PresentInfoKhr", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkImageSwapchainCreateInfoKHR" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.ImageSwapchainCreateInfoKhr", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkBindImageMemorySwapchainInfoKHR" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.BindImageMemorySwapchainInfoKhr", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkAcquireNextImageInfoKHR" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.AcquireNextImageInfoKhr", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkDeviceGroupPresentCapabilitiesKHR" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.DeviceGroupPresentCapabilitiesKhr", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkDeviceGroupPresentInfoKHR" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.DeviceGroupPresentInfoKhr", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkDeviceGroupSwapchainCreateInfoKHR" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.DeviceGroupSwapchainCreateInfoKhr", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkDisplayModeCreateInfoKHR" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.DisplayModeCreateInfoKhr", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkDisplaySurfaceCreateInfoKHR" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.DisplaySurfaceCreateInfoKhr", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkDisplayPresentInfoKHR" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.DisplayPresentInfoKhr", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkImportMemoryFdInfoKHR" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.ImportMemoryFdInfoKhr", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkMemoryFdPropertiesKHR" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.MemoryFdPropertiesKhr", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkMemoryGetFdInfoKHR" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.MemoryGetFdInfoKhr", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkImportSemaphoreFdInfoKHR" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.ImportSemaphoreFdInfoKhr", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkSemaphoreGetFdInfoKHR" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.SemaphoreGetFdInfoKhr", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDevicePushDescriptorPropertiesKhr" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDevicePushDescriptorPropertiesKhr", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceShaderFloat16Int8FeaturesKHR" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceShaderFloat16Int8FeaturesKhr", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPresentRegionsKHR" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PresentRegionsKhr", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkAttachmentDescription2KHR" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.AttachmentDescription2Khr", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkAttachmentReference2KHR" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.AttachmentReference2Khr", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkSubpassDescription2KHR" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.SubpassDescription2Khr", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkSubpassDependency2KHR" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.SubpassDependency2Khr", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkRenderPassCreateInfo2KHR" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.RenderPassCreateInfo2Khr", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkSubpassBeginInfoKHR" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.SubpassBeginInfoKhr", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkSubpassEndInfoKHR" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.SubpassEndInfoKhr", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkSharedPresentSurfaceCapabilitiesKHR" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.SharedPresentSurfaceCapabilitiesKhr", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkImportFenceFdInfoKHR" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.ImportFenceFdInfoKhr", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkFenceGetFdInfoKHR" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.FenceGetFdInfoKhr", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceSurfaceInfo2KHR" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceSurfaceInfo2Khr", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkSurfaceCapabilities2KHR" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.SurfaceCapabilities2Khr", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkSurfaceFormat2KHR" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.SurfaceFormat2Khr", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkDisplayProperties2KHR" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.DisplayProperties2Khr", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkDisplayPlaneProperties2KHR" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.DisplayPlaneProperties2Khr", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkDisplayModeProperties2KHR" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.DisplayModeProperties2Khr", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkDisplayPlaneInfo2KHR" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.DisplayPlaneInfo2Khr", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkDisplayPlaneCapabilities2KHR" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.DisplayPlaneCapabilities2Khr", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkImageFormatListCreateInfoKHR" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.ImageFormatListCreateInfoKhr", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDevice8BitStorageFeaturesKHR" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDevice8bitStorageFeaturesKhr", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceShaderAtomicInt64FeaturesKHR" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceShaderAtomicInt64FeaturesKhr", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceDriverPropertiesKHR" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceDriverPropertiesKhr", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceFloatControlsPropertiesKHR" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceFloatControlsPropertiesKhr", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkSubpassDescriptionDepthStencilResolveKHR" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.SubpassDescriptionDepthStencilResolveKhr", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceDepthStencilResolvePropertiesKHR" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceDepthStencilResolvePropertiesKhr", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceVulkanMemoryModelFeaturesKHR" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceVulkanMemoryModelFeaturesKhr", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkDebugReportCallbackCreateInfoEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.DebugReportCallbackCreateInfoExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPipelineRasterizationStateRasterizationOrderAMD" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PipelineRasterizationStateRasterizationOrderAmd", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkDebugMarkerObjectNameInfoEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.DebugMarkerObjectNameInfoExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkDebugMarkerObjectTagInfoEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.DebugMarkerObjectTagInfoExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkDebugMarkerMarkerInfoEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.DebugMarkerMarkerInfoExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkDedicatedAllocationImageCreateInfoNV" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.DedicatedAllocationImageCreateInfoNv", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkDedicatedAllocationBufferCreateInfoNV" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.DedicatedAllocationBufferCreateInfoNv", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkDedicatedAllocationMemoryAllocateInfoNV" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.DedicatedAllocationMemoryAllocateInfoNv", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceTransformFeedbackFeaturesEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceTransformFeedbackFeaturesExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceTransformFeedbackPropertiesEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceTransformFeedbackPropertiesExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPipelineRasterizationStateStreamCreateInfoEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PipelineRasterizationStateStreamCreateInfoExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkTextureLODGatherFormatPropertiesAMD" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.TextureLodGatherFormatPropertiesAmd", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceCornerSampledImageFeaturesNV" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceCornerSampledImageFeaturesNv", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkExternalMemoryImageCreateInfoNV" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.ExternalMemoryImageCreateInfoNv", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkExportMemoryAllocateInfoNV" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.ExportMemoryAllocateInfoNv", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkValidationFlagsEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.ValidationFlagsExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkImageViewASTCDecodeModeEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.ImageViewAstcDecodeModeExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceASTCDecodeFeaturesEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceAstcDecodeFeaturesExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkConditionalRenderingBeginInfoEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.ConditionalRenderingBeginInfoExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceConditionalRenderingFeaturesEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceConditionalRenderingFeaturesExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkCommandBufferInheritanceConditionalRenderingInfoEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.CommandBufferInheritanceConditionalRenderingInfoExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkDeviceGeneratedCommandsFeaturesNVX" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.DeviceGeneratedCommandsFeaturesNvx", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkDeviceGeneratedCommandsLimitsNVX" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.DeviceGeneratedCommandsLimitsNvx", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkIndirectCommandsLayoutCreateInfoNVX" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.IndirectCommandsLayoutCreateInfoNvx", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkCmdProcessCommandsInfoNVX" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.CmdProcessCommandsInfoNvx", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkCmdReserveSpaceForCommandsInfoNVX" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.CmdReserveSpaceForCommandsInfoNvx", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkObjectTableCreateInfoNVX" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.ObjectTableCreateInfoNvx", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPipelineViewportWScalingStateCreateInfoNV" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PipelineViewportWScalingStateCreateInfoNv", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkSurfaceCapabilities2EXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.SurfaceCapabilities2Ext", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkDisplayPowerInfoEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.DisplayPowerInfoExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkDeviceEventInfoEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.DeviceEventInfoExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkSwapchainCounterCreateInfoEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.SwapchainCounterCreateInfoExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPresentTimesInfoGOOGLE" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PresentTimesInfoGoogle", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceMultiviewPerViewAttributesPropertiesNvx", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPipelineViewportSwizzleStateCreateInfoNV" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PipelineViewportSwizzleStateCreateInfoNv", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceDiscardRectanglePropertiesEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceDiscardRectanglePropertiesExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPipelineDiscardRectangleStateCreateInfoEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PipelineDiscardRectangleStateCreateInfoExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceConservativeRasterizationPropertiesEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceConservativeRasterizationPropertiesExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPipelineRasterizationConservativeStateCreateInfoEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PipelineRasterizationConservativeStateCreateInfoExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceDepthClipEnableFeaturesEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceDepthClipEnableFeaturesExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPipelineRasterizationDepthClipStateCreateInfoEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PipelineRasterizationDepthClipStateCreateInfoExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkHdrMetadataEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.HdrMetadataExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkDebugUtilsObjectNameInfoEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.DebugUtilsObjectNameInfoExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkDebugUtilsObjectTagInfoEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.DebugUtilsObjectTagInfoExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkDebugUtilsLabelEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.DebugUtilsLabelExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkDebugUtilsMessengerCallbackDataEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.DebugUtilsMessengerCallbackDataExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkDebugUtilsMessengerCreateInfoEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.DebugUtilsMessengerCreateInfoExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkSamplerReductionModeCreateInfoEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.SamplerReductionModeCreateInfoExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceSamplerFilterMinmaxPropertiesEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceSamplerFilterMinmaxPropertiesExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceInlineUniformBlockFeaturesEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceInlineUniformBlockFeaturesExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceInlineUniformBlockPropertiesEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceInlineUniformBlockPropertiesExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkWriteDescriptorSetInlineUniformBlockEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.WriteDescriptorSetInlineUniformBlockExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkDescriptorPoolInlineUniformBlockCreateInfoEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.DescriptorPoolInlineUniformBlockCreateInfoExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkSampleLocationsInfoEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.SampleLocationsInfoExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkRenderPassSampleLocationsBeginInfoEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.RenderPassSampleLocationsBeginInfoExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPipelineSampleLocationsStateCreateInfoEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PipelineSampleLocationsStateCreateInfoExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceSampleLocationsPropertiesEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceSampleLocationsPropertiesExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkMultisamplePropertiesEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.MultisamplePropertiesExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceBlendOperationAdvancedFeaturesExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceBlendOperationAdvancedPropertiesExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPipelineColorBlendAdvancedStateCreateInfoEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PipelineColorBlendAdvancedStateCreateInfoExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPipelineCoverageToColorStateCreateInfoNV" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PipelineCoverageToColorStateCreateInfoNv", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPipelineCoverageModulationStateCreateInfoNV" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PipelineCoverageModulationStateCreateInfoNv", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkDrmFormatModifierPropertiesListEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.DrmFormatModifierPropertiesListExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceImageDrmFormatModifierInfoEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceImageDrmFormatModifierInfoExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkImageDrmFormatModifierListCreateInfoEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.ImageDrmFormatModifierListCreateInfoExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkImageDrmFormatModifierExplicitCreateInfoEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.ImageDrmFormatModifierExplicitCreateInfoExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkImageDrmFormatModifierPropertiesEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.ImageDrmFormatModifierPropertiesExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkValidationCacheCreateInfoEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.ValidationCacheCreateInfoExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkShaderModuleValidationCacheCreateInfoEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.ShaderModuleValidationCacheCreateInfoExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkDescriptorSetLayoutBindingFlagsCreateInfoEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.DescriptorSetLayoutBindingFlagsCreateInfoExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceDescriptorIndexingFeaturesEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceDescriptorIndexingFeaturesExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceDescriptorIndexingPropertiesEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceDescriptorIndexingPropertiesExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkDescriptorSetVariableDescriptorCountAllocateInfoEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.DescriptorSetVariableDescriptorCountAllocateInfoExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkDescriptorSetVariableDescriptorCountLayoutSupportEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.DescriptorSetVariableDescriptorCountLayoutSupportExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPipelineViewportShadingRateImageStateCreateInfoNV" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PipelineViewportShadingRateImageStateCreateInfoNv", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceShadingRateImageFeaturesNV" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceShadingRateImageFeaturesNv", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceShadingRateImagePropertiesNV" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceShadingRateImagePropertiesNv", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPipelineViewportCoarseSampleOrderStateCreateInfoNV" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PipelineViewportCoarseSampleOrderStateCreateInfoNv", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkRayTracingShaderGroupCreateInfoNV" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.RayTracingShaderGroupCreateInfoNv", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkRayTracingPipelineCreateInfoNV" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.RayTracingPipelineCreateInfoNv", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkGeometryTrianglesNV" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.GeometryTrianglesNv", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkGeometryAABBNV" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.GeometryAabbNv", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkGeometryNV" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.GeometryNv", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkAccelerationStructureInfoNV" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.AccelerationStructureInfoNv", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkAccelerationStructureCreateInfoNV" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.AccelerationStructureCreateInfoNv", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkBindAccelerationStructureMemoryInfoNV" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.BindAccelerationStructureMemoryInfoNv", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkWriteDescriptorSetAccelerationStructureNV" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.WriteDescriptorSetAccelerationStructureNv", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkAccelerationStructureMemoryRequirementsInfoNV" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.AccelerationStructureMemoryRequirementsInfoNv", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceRayTracingPropertiesNV" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceRayTracingPropertiesNv", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceRepresentativeFragmentTestFeaturesNv", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPipelineRepresentativeFragmentTestStateCreateInfoNV" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PipelineRepresentativeFragmentTestStateCreateInfoNv", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceImageViewImageFormatInfoEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceImageViewImageFormatInfoExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkFilterCubicImageViewImageFormatPropertiesEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.FilterCubicImageViewImageFormatPropertiesExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkDeviceQueueGlobalPriorityCreateInfoEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.DeviceQueueGlobalPriorityCreateInfoExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkImportMemoryHostPointerInfoEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.ImportMemoryHostPointerInfoExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkMemoryHostPointerPropertiesEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.MemoryHostPointerPropertiesExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceExternalMemoryHostPropertiesEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceExternalMemoryHostPropertiesExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkCalibratedTimestampInfoEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.CalibratedTimestampInfoExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceShaderCorePropertiesAMD" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceShaderCorePropertiesAmd", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkDeviceMemoryOverallocationCreateInfoAMD" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.DeviceMemoryOverallocationCreateInfoAmd", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceVertexAttributeDivisorPropertiesExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPipelineVertexInputDivisorStateCreateInfoEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PipelineVertexInputDivisorStateCreateInfoExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceVertexAttributeDivisorFeaturesExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceComputeShaderDerivativesFeaturesNV" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceComputeShaderDerivativesFeaturesNv", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceMeshShaderFeaturesNV" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceMeshShaderFeaturesNv", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceMeshShaderPropertiesNV" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceMeshShaderPropertiesNv", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceFragmentShaderBarycentricFeaturesNV" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceFragmentShaderBarycentricFeaturesNv", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceShaderImageFootprintFeaturesNV" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceShaderImageFootprintFeaturesNv", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPipelineViewportExclusiveScissorStateCreateInfoNV" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PipelineViewportExclusiveScissorStateCreateInfoNv", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceExclusiveScissorFeaturesNV" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceExclusiveScissorFeaturesNv", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkQueueFamilyCheckpointPropertiesNV" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.QueueFamilyCheckpointPropertiesNv", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkCheckpointDataNV" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.CheckpointDataNv", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDevicePCIBusInfoPropertiesEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDevicePciBusInfoPropertiesExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceFragmentDensityMapFeaturesEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceFragmentDensityMapFeaturesExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceFragmentDensityMapPropertiesEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceFragmentDensityMapPropertiesExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkRenderPassFragmentDensityMapCreateInfoEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.RenderPassFragmentDensityMapCreateInfoExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceScalarBlockLayoutFeaturesEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceScalarBlockLayoutFeaturesExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceMemoryBudgetPropertiesEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceMemoryBudgetPropertiesExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceMemoryPriorityFeaturesEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceMemoryPriorityFeaturesExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkMemoryPriorityAllocateInfoEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.MemoryPriorityAllocateInfoExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceDedicatedAllocationImageAliasingFeaturesNv", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceBufferDeviceAddressFeaturesEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceBufferDeviceAddressFeaturesExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkBufferDeviceAddressInfoEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.BufferDeviceAddressInfoExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkBufferDeviceAddressCreateInfoEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.BufferDeviceAddressCreateInfoExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkImageStencilUsageCreateInfoEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.ImageStencilUsageCreateInfoExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkValidationFeaturesEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.ValidationFeaturesExt", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkCooperativeMatrixPropertiesNV" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.CooperativeMatrixPropertiesNv", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceCooperativeMatrixFeaturesNV" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceCooperativeMatrixFeaturesNv", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkPhysicalDeviceCooperativeMatrixPropertiesNV" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.PhysicalDeviceCooperativeMatrixPropertiesNv", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkWin32SurfaceCreateInfoKHR" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.Win32SurfaceCreateInfoKhr", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkMacOSSurfaceCreateInfoMVK" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.MacosSurfaceCreateInfoMvk", IsReadOnly = true };
            predefinedValues.Add(values);
            values = new PredefinedValues() { StructType = "VkHeadlessSurfaceCreateInfoEXT" };
            values.FieldValues["sType"] = new PredefinedItem() { Value = "StructureType.HeadlessSurfaceCreateInfoExt", IsReadOnly = true };
            predefinedValues.Add(values);

            return predefinedValues;
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

            api.Function("vkUpdateDescriptorSets")
                .WithParameterName("pDescriptorWrites")
                .TreatAsPointerToArray(new CustomType("VkWriteDescriptorSet"), true, "descriptorWriteCount")
                .WithParameterName("pDescriptorCopies")
                .TreatAsPointerToArray(new CustomType("VkCopyDescriptorSet"), true, "descriptorCopyCount")
                .SetParameterKind(ParameterKind.Out);

            api.Function("vkGetDisplayPlaneSupportedDisplaysKHR")
                .WithParameterName("pDisplays")
                .TreatAsPointerToArray(new CustomType("VkDisplayKHR_T"), true, "pDisplayCount")
                .SetParameterKind(ParameterKind.Out);

            api.Function("vkGetPhysicalDeviceDisplayPlanePropertiesKHR")
                .WithParameterName("pProperties")
                .TreatAsPointerToArray(new CustomType("VkDisplayPlanePropertiesKHR"), true, "pPropertyCount")
                .SetParameterKind(ParameterKind.Out);

            api.Function("vkEnumerateDeviceExtensionProperties")
                .WithParameterName("pProperties")
                .TreatAsPointerToArray(new CustomType("VkExtensionProperties"), true, "pPropertyCount")
                .SetParameterKind(ParameterKind.InOut);

            api.Function("vkEnumerateDeviceLayerProperties")
                .WithParameterName("pProperties")
                .TreatAsPointerToArray(new CustomType("VkLayerProperties"), true, "pPropertyCount")
                .SetParameterKind(ParameterKind.InOut);

            api.Function("vkCmdSetScissor")
                .WithParameterName("pScissors")
                .TreatAsPointerToArray(new CustomType("VkRect2D"), true, "scissorCount");

            api.Function("vkCmdSetViewport")
                .WithParameterName("pViewports")
                .TreatAsPointerToArray(new CustomType("VkViewport"), true, "viewportCount");

            api.Class("VkFramebufferAttachmentImageInfoKHR").WithField("pViewFormats")
                .TreatAsPointerToArray(new CustomType("vkFormat"), true, "viewFormatCount");

            api.Class("VkPipelineViewportStateCreateInfo")
                .WithField("pScissors")
                .TreatAsPointerToArray(new CustomType("VkRect2D"), true, "scissorCount");

            api.Function("shaderc_result_get_bytes").
                WithReturnType(new BuiltinType(PrimitiveType.IntPtr));

            api.Function("spvc_context_parse_spirv").WithParameterName("spirv").TreatAsPointerToArray(new BuiltinType(PrimitiveType.Byte));

            api.Function("spvc_resources_get_resource_list_for_type").WithParameterName("resource_list").TreatAsPointerToArray(new CustomType("SpvcReflectedResource"), true, "resource_size").SetParameterKind(ParameterKind.Out);

            api.Delegate("spvc_error_callback").WithParameterName("error").TreatAsIs().SetParameterKind(ParameterKind.Out);

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

            api.Classes(classesList).
                AddProperty("NativePointer").
                SetField("__Instance.pointer").
                SetType(propertyType).
                SetGetter(new Method());

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

}
