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

// File: C:\VulkanSDK\1.3.275.0\Include\vulkan/vulkan_core.h Line: 13099 Column: 1
public unsafe partial class ValidationCacheEXT
{
    internal VkValidationCacheEXT_T __Instance;
    public ValidationCacheEXT()
    {
    }

    public ValidationCacheEXT(AdamantiumVulkan.Core.Interop.VkValidationCacheEXT_T __Instance)
    {
        this.__Instance = __Instance;
    }

    public void* NativePointer => __Instance.pointer;

    public ref readonly VkValidationCacheEXT_T GetPinnableReference() => ref __Instance;

    public static implicit operator AdamantiumVulkan.Core.Interop.VkValidationCacheEXT_T(ValidationCacheEXT v)
    {
        return v?.__Instance ?? new AdamantiumVulkan.Core.Interop.VkValidationCacheEXT_T();
    }

    public static implicit operator ValidationCacheEXT(AdamantiumVulkan.Core.Interop.VkValidationCacheEXT_T v)
    {
        return new ValidationCacheEXT(v);
    }

}



