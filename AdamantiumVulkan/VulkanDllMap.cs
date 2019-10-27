using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace AdamantiumVulkan
{
    public static class VulkanDllMap
    {
        private static Dictionary<Assembly, LibraryNameResolver> registeredAssemblies;

        static VulkanDllMap()
        {
            registeredAssemblies = new Dictionary<Assembly, LibraryNameResolver>();
        }

        // Register a call-back for native library resolution.
        public static void Register()
        {
            var coreResolver = new LibraryNameResolver("AdamantiumVulkan.Core") { WindowsLibraryName = "vulkan-1", OSXLibraryName = "libMoltenVK" };
            var windowsResolver = new LibraryNameResolver("AdamantiumVulkan.Windows") { WindowsLibraryName = "vulkan-1", OSXLibraryName = "libMoltenVK" };
            var macOSResolver = new LibraryNameResolver("AdamantiumVulkan.MacOS") { WindowsLibraryName = "vulkan-1", OSXLibraryName = "libMoltenVK" };
            var shadersResolver = new LibraryNameResolver("AdamantiumVulkan.Shaders") { WindowsLibraryName = "shaderc_shared", OSXLibraryName = "libshaderc_shared" };
            var spirvCrossResolver = new LibraryNameResolver("AdamantiumVulkan.SPIRV.Cross") { WindowsLibraryName = "spirv-cross-c-shared", OSXLibraryName = "libspirv-cross-c-shared" };
            RegisterAssembly(coreResolver);
            RegisterAssembly(windowsResolver);
            RegisterAssembly(macOSResolver);
            RegisterAssembly(shadersResolver);
            RegisterAssembly(spirvCrossResolver);
        }

        private static void RegisterAssembly(LibraryNameResolver libNameResolver)
        {
            if (RegisterAssembly(libNameResolver.AssemblyName, out var assembly))
            {
                registeredAssemblies[assembly] = libNameResolver;
            }
        }

        private static bool RegisterAssembly(string assemblyName, out Assembly assembly)
        {
            try
            {
                assembly = Assembly.Load(assemblyName);
                NativeLibrary.SetDllImportResolver(assembly, MapAndLoad);
                return true;
            }
            catch(Exception)
            {
                Console.WriteLine($"Could not load assembly {assemblyName}");
                assembly = null;
                return false;
            }
        }

        // The callback: which loads the mapped libray in place of the original
        private static IntPtr MapAndLoad(string libraryName, Assembly assembly, DllImportSearchPath? dllImportSearchPath)
        {
            string mappedName = libraryName;
            if (registeredAssemblies.TryGetValue(assembly, out var resolver))
            {
                mappedName = resolver.LibraryNameForCurrentPlatform;
            }

            return NativeLibrary.Load(mappedName, assembly, dllImportSearchPath);
        }
    }
}
