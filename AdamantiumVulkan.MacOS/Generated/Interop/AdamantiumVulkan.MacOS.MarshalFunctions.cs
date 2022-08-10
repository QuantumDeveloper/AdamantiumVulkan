// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

namespace AdamantiumVulkan.MacOS.Interop
{
    using System.Security;
    using System;
    using System.Runtime.InteropServices;
    using AdamantiumVulkan.Common;
    using AdamantiumVulkan.Core;
    using AdamantiumVulkan.Core.Interop;

    public static class VulkanInterop
    {
        public const string LibraryPath = "vulkan-1";

        [SuppressUnmanagedCodeSecurity]
        [DllImport(LibraryPath, EntryPoint = "vkCreateMacOSSurfaceMVK", CallingConvention = CallingConvention.Winapi)]
        internal static extern Result vkCreateMacOSSurfaceMVK([In] AdamantiumVulkan.Core.Interop.VkInstance_T instance, System.IntPtr pCreateInfo, System.IntPtr pAllocator, [Out] out AdamantiumVulkan.Core.Interop.VkSurfaceKHR_T pSurface);

    }


}

