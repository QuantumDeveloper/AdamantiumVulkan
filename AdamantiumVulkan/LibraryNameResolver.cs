using System;
using System.Runtime.InteropServices;

namespace AdamantiumVulkan
{
    public class LibraryNameResolver
    {
        public LibraryNameResolver(string assemblyName)
        {
            AssemblyName = assemblyName;
        }

        public string AssemblyName { get; }

        public string WindowsLibraryName { get; set; }

        public string OSXLibraryName { get; set; }

        public string LibraryNameForCurrentPlatform 
        { 
            get 
            {
                string libName;
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    libName = WindowsLibraryName;
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    libName = OSXLibraryName;
                }
                else
                {
                    throw new VulkanInteropException($"{RuntimeInformation.OSDescription} is not supported yet");
                }

                if (String.IsNullOrEmpty(libName))
                {
                    throw new MissingLibraryNameException($"No library name exists for Assembly {AssemblyName} and platform {RuntimeInformation.OSDescription}");
                }

                return libName;
            } 
        }
    }
}
