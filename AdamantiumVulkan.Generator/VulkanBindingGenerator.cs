using QuantumBinding.Generator;
using QuantumBinding.Generator.AST;
using QuantumBinding.Generator.BindingsMapping;
using QuantumBinding.Generator.CodeGeneration;
using QuantumBinding.Generator.ProcessingFluentApi;
using QuantumBinding.Generator.Processors;
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
            string commonNamespace = "AdamantiumVulkan.Common";
            string vulkanBasePath = @"C:\VulkanSDK\1.3.224.0\Include";

            var appRoot = AppContext.BaseDirectory.Substring(0, AppContext.BaseDirectory.LastIndexOf("bin"));
            string commonPath = Path.GetFullPath(Path.Combine(appRoot, "..", "AdamantiumVulkan.Common", "Generated"));
            string corePath = Path.GetFullPath(Path.Combine(appRoot, "..", "AdamantiumVulkan.Core", "Generated"));
            string windowsPath = Path.GetFullPath(Path.Combine(appRoot, "..", "AdamantiumVulkan.Windows", "Generated"));
            string macOSPath = Path.GetFullPath(Path.Combine(appRoot, "..", "AdamantiumVulkan.MacOS", "Generated"));
            string shadersPath = Path.GetFullPath(Path.Combine(appRoot, "..", "AdamantiumVulkan.Shaders", "Generated"));
            string spirvPath = Path.GetFullPath(Path.Combine(appRoot, "..", "AdamantiumVulkan.Spirv", "Generated"));
            
            PathManager vulkanPathManager = new PathManager();
            vulkanPathManager.AddFilePath(OSPlatform.Windows, Path.Combine(vulkanBasePath, "vulkan", "vulkan.h"));
            vulkanPathManager.AddFilePath(OSPlatform.OSX, Path.Combine("/usr", "local", "include", "vulkan", "vulkan.h"));

            options.GenerateSequentialLayout = true;
            options.PodTypesAsSimpleTypes = true;
            options.PathToBindingsFile = "VulkanBindingsMap.xml";

            vkMainModule = options.AddModule(vkMainLibrary);
            vkMainModule.Name = "Core";
            vkMainModule.Defines.Add("_WIN32");
            vkMainModule.Defines.Add("_MSC_VER");
            vkMainModule.Defines.Add("VK_USE_PLATFORM_WIN32_KHR");
            vkMainModule.Defines.Add("VK_USE_PLATFORM_MACOS_MVK");
            vkMainModule.Files.AddRange(vulkanPathManager.Files);
            vkMainModule.ForceCallingConvention = true;
            vkMainModule.CallingConvention = CallingConvention.Winapi;
            vkMainModule.AllowConvertStructToClass = true;
            vkMainModule.MethodClassName = "VulkanNative";
            vkMainModule.InteropClassName = "VulkanInterop";
            vkMainModule.OutputFileName = mainNamespace;
            vkMainModule.OutputNamespace = mainNamespace;
            vkMainModule.SuppressUnmanagedCodeSecurity = true;
            vkMainModule.AddNamespaceMapping("vulkan_core", "Core", corePath);
            vkMainModule.AddNamespaceMapping("vulkan_win32", "Windows", windowsPath);
            vkMainModule.AddNamespaceMapping("vulkan_macos", "MacOS", macOSPath);
            vkMainModule.WrapInteropObjects = true;
            vkMainModule.GenerateOverloadsForArrayParams = true;
            vkMainModule.OutputPath = corePath;

            shaderModule = options.AddModule(shadercLibrary);
            shaderModule.Name = "Shaders";
            shaderModule.IncludeDirs.Add(vulkanBasePath);
            shaderModule.IncludeDirs.Add(Path.Combine(vulkanBasePath, "shaderc"));
            shaderModule.Files.Add(Path.Combine(vulkanBasePath, "shaderc", "shaderc.h"));
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
            shaderModule.SuppressUnmanagedCodeSecurity = true;
            shaderModule.WrapInteropObjects = true;
            shaderModule.GenerateOverloadsForArrayParams = true;
            shaderModule.OutputPath = shadersPath;
            
            var spirvCrossSpecs = GeneratorSpecializations.All;
            spirvCrossSpecs &= ~GeneratorSpecializations.Constants;
            spivCrossModule = options.AddModule(spirvCrossLibrary);
            spivCrossModule.Name = "Spirv.Cross";
            spivCrossModule.Files.Add(Path.Combine(vulkanBasePath, "spirv_cross", "spirv_cross_c.h"));
            spivCrossModule.Defines.Add("SPVC_EXPORT_SYMBOLS");
            spivCrossModule.Defines.Add("_MSC_VER");
            spivCrossModule.ForceCallingConvention = true;
            spivCrossModule.CallingConvention = CallingConvention.Winapi;
            spivCrossModule.AllowConvertStructToClass = true;
            spivCrossModule.MethodClassName = "SpirvCrossNative";
            spivCrossModule.InteropClassName = "SpirvCrossInterop";
            spivCrossModule.GeneratorSpecializations = spirvCrossSpecs;
            spivCrossModule.OutputFileName = "AdamantiumVulkan.Spirv.Cross";
            spivCrossModule.OutputNamespace = "AdamantiumVulkan.Spirv.Cross";
            spivCrossModule.SuppressUnmanagedCodeSecurity = true;
            spivCrossModule.AddNamespaceMapping("spirv", "AdamantiumVulkan.Spirv", spirvPath, true);
            spivCrossModule.WrapInteropObjects = true;
            spivCrossModule.CharAsBoolForMethods = true;
            spivCrossModule.OutputPath = spirvPath;

            Module.UtilsOutputName = "Utils";
            Module.UtilsOutputPath = commonPath;
            Module.UtilsNamespace = commonNamespace;
            Module.GenerateUtilsForModule = vkMainModule;
        }

        public override void OnBeforeSetupPasses(ProcessingContext context)
        {
            VulkanBindings.ProvideFunctionsForParametersFix(context);
        }

        public override void OnSetupPostProcessing(ProcessingContext context)
        {
            context.AddPreGeneratorPass(new FunctionToInstanceMethodPass(), ExecutionPassKind.PerTranslationUnit);
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

            context.AddPreGeneratorPass(new PrepareStructsBeforeWrappingPass(VulkanBindings.GetStructuresPredefinedValues()), ExecutionPassKind.PerTranslationUnit);

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
            macroAction.IgnoreList.Add("VK_MAKE_VERSION");
            macroAction.IgnoreList.Add("VK_VERSION_MAJOR");
            macroAction.IgnoreList.Add("VK_VERSION_MINOR");
            macroAction.IgnoreList.Add("VK_VERSION_PATCH");

            macroAction.SubstitutionList.Add("VK_MAKE_API_VERSION", VulkanBindings.CreateMakeApiVersionFunction());
            macroAction.SubstitutionList.Add("VK_API_VERSION_VARIANT", VulkanBindings.CreateApiVersionFor("variant"));
            macroAction.SubstitutionList.Add("VK_API_VERSION_MAJOR", VulkanBindings.CreateApiVersionFor("major"));
            macroAction.SubstitutionList.Add("VK_API_VERSION_MINOR", VulkanBindings.CreateApiVersionFor("minor"));
            macroAction.SubstitutionList.Add("VK_API_VERSION_PATCH", VulkanBindings.CreateApiVersionFor("patch"));
            macroAction.SubstitutionList.Add("VK_API_VERSION_1_0", VulkanBindings.CreateApiVersion());
            macroAction.SubstitutionList.Add("VK_API_VERSION_1_1", VulkanBindings.CreateApiVersion());
            macroAction.SubstitutionList.Add("VK_QUEUE_FAMILY_EXTERNAL_KHR", VulkanBindings.CreateApiVersion());
            macroAction.SubstitutionList.Add("VK_QUEUE_FAMILY_EXTERNAL", VulkanBindings.CreateApiVersion());
            macroAction.SubstitutionList.Add("VK_QUEUE_FAMILY_FOREIGN_EXT", VulkanBindings.CreateApiVersion());
            macroAction.SubstitutionList.Add("VK_HEADER_VERSION", VulkanBindings.CreateHeaderVersion());
            macroAction.SubstitutionList.Add("VK_LOD_CLAMP_NONE", VulkanBindings.CreateLodClampNone());
            macroAction.SubstitutionList.Add("VK_KHR_MAINTENANCE1_EXTENSION_NAME", VulkanBindings.CreateStringReturnMacro());
            macroAction.SubstitutionList.Add("VK_KHR_MAINTENANCE2_EXTENSION_NAME", VulkanBindings.CreateStringReturnMacro());
            macroAction.SubstitutionList.Add("VK_KHR_MAINTENANCE3_EXTENSION_NAME", VulkanBindings.CreateStringReturnMacro());
            macroAction.SubstitutionList.Add("VK_NV_VIEWPORT_ARRAY2_EXTENSION_NAME", VulkanBindings.CreateStringReturnMacro());
            macroAction.SubstitutionList.Add("VK_GOOGLE_HLSL_FUNCTIONALITY1_EXTENSION_NAME", VulkanBindings.CreateStringReturnMacro());
            
            
            context.AddPreGeneratorPass(macroAction, ExecutionPassKind.PerTranslationUnit);
        }

        public override void OnSetupComplete(ProcessingContext context)
        {
            var renameTargets = RenameTargetsUtil.AnyExcept(RenameTargets.Function | RenameTargets.Struct | RenameTargets.Union);
            var vkRenameItems = new List<RegexRenameRunItem>()
            {
                new RegexRenameRunItem("^vkCmd", string.Empty, renameTargets, true),
                new RegexRenameRunItem("^vk", string.Empty, renameTargets, true),
            };
            context.AddPreGeneratorPass(new SequentialRegexRenamePass(vkRenameItems.ToArray()), ExecutionPassKind.PerTranslationUnit, vkMainModule);
        }
    }

}
