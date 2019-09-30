using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace AdamantiumVulkan
{
    public static class VulkanDllMap
    {
        // Register a call-back for native library resolution.
        public static void Register()
        {
            RegisterAssembly("AdamantiumVulkan.Core");
            RegisterAssembly("AdamantiumVulkan.Windows");
            RegisterAssembly("AdamantiumVulkan.MacOS");
        }

        private static void RegisterAssembly(string assemblyName)
        {
            try
            {
                var assembly = Assembly.Load(assemblyName);
                NativeLibrary.SetDllImportResolver(assembly, MapAndLoad);
            }
            catch(Exception)
            {
                Console.WriteLine($"Could not load assembly {assemblyName}");
                // Empty
            }
        }

        // The callback: which loads the mapped libray in place of the original
        private static IntPtr MapAndLoad(string libraryName, Assembly assembly, DllImportSearchPath? dllImportSearchPath)
        {
            string mappedName;
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                mappedName = "vulkan-1";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                mappedName = "libMoltenVK";
            }
            else
            {
                throw new VulkanInteropException($"{RuntimeInformation.OSDescription} is not supported yet");
            }

            return NativeLibrary.Load(mappedName, assembly, dllImportSearchPath);
        }
    }
}
