// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using QuantumBinding.Utils;
using AdamantiumVulkan.Core.Interop;

namespace AdamantiumVulkan.Core;

// File: C:\VulkanSDK\1.3.275.0\Include\vulkan/vulkan_core.h Line: 12652 Column: 1
public unsafe partial class DebugUtilsMessengerEXT
{
    internal VkDebugUtilsMessengerEXT_T __Instance;
    public DebugUtilsMessengerEXT()
    {
    }

    public DebugUtilsMessengerEXT(AdamantiumVulkan.Core.Interop.VkDebugUtilsMessengerEXT_T __Instance)
    {
        this.__Instance = __Instance;
    }

    public void* NativePointer => __Instance.pointer;

    public ref readonly VkDebugUtilsMessengerEXT_T GetPinnableReference() => ref __Instance;

    public static implicit operator AdamantiumVulkan.Core.Interop.VkDebugUtilsMessengerEXT_T(DebugUtilsMessengerEXT d)
    {
        return d?.__Instance ?? new AdamantiumVulkan.Core.Interop.VkDebugUtilsMessengerEXT_T();
    }

    public static implicit operator DebugUtilsMessengerEXT(AdamantiumVulkan.Core.Interop.VkDebugUtilsMessengerEXT_T d)
    {
        return new DebugUtilsMessengerEXT(d);
    }

}



