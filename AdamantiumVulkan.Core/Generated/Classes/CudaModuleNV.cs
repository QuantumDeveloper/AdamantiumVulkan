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

// File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_core.h Line: 16927 Column: 1
public unsafe partial class CudaModuleNV
{
    internal VkCudaModuleNV_T __Instance;
    public CudaModuleNV()
    {
    }

    public CudaModuleNV(AdamantiumVulkan.Core.Interop.VkCudaModuleNV_T __Instance)
    {
        this.__Instance = __Instance;
    }

    public ref readonly VkCudaModuleNV_T GetPinnableReference() => ref __Instance;

    public static implicit operator AdamantiumVulkan.Core.Interop.VkCudaModuleNV_T(CudaModuleNV c)
    {
        return c?.__Instance ?? new AdamantiumVulkan.Core.Interop.VkCudaModuleNV_T();
    }

    public static implicit operator CudaModuleNV(AdamantiumVulkan.Core.Interop.VkCudaModuleNV_T c)
    {
        return new CudaModuleNV(c);
    }

}



