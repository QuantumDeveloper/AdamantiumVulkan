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

public unsafe partial class ShaderModule
{
    internal VkShaderModule_T __Instance;
    public ShaderModule()
    {
    }

    public ShaderModule(AdamantiumVulkan.Core.Interop.VkShaderModule_T __Instance)
    {
        this.__Instance = __Instance;
    }

    public void* NativePointer => __Instance.pointer;

    public ref readonly VkShaderModule_T GetPinnableReference() => ref __Instance;

    public static implicit operator AdamantiumVulkan.Core.Interop.VkShaderModule_T(ShaderModule s)
    {
        return s?.__Instance ?? new AdamantiumVulkan.Core.Interop.VkShaderModule_T();
    }

    public static implicit operator ShaderModule(AdamantiumVulkan.Core.Interop.VkShaderModule_T s)
    {
        return new ShaderModule(s);
    }

}


