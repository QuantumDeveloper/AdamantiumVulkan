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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 19804 Column: 1
public unsafe partial class ShaderEXT
{
    internal VkShaderEXT_T __Instance;
    public ShaderEXT()
    {
    }

    public ShaderEXT(AdamantiumVulkan.Core.Interop.VkShaderEXT_T __Instance)
    {
        this.__Instance = __Instance;
    }

    public void* NativePointer => __Instance.pointer;

    public ref readonly VkShaderEXT_T GetPinnableReference() => ref __Instance;

    public static implicit operator AdamantiumVulkan.Core.Interop.VkShaderEXT_T(ShaderEXT s)
    {
        return s?.__Instance ?? new AdamantiumVulkan.Core.Interop.VkShaderEXT_T();
    }

    public static implicit operator ShaderEXT(AdamantiumVulkan.Core.Interop.VkShaderEXT_T s)
    {
        return new ShaderEXT(s);
    }

}



