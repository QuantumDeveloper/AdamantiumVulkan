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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 17157 Column: 1
public unsafe partial class AccelerationStructureKHR
{
    internal VkAccelerationStructureKHR_T __Instance;
    public AccelerationStructureKHR()
    {
    }

    public AccelerationStructureKHR(AdamantiumVulkan.Core.Interop.VkAccelerationStructureKHR_T __Instance)
    {
        this.__Instance = __Instance;
    }

    public ref readonly VkAccelerationStructureKHR_T GetPinnableReference() => ref __Instance;

    public static implicit operator AdamantiumVulkan.Core.Interop.VkAccelerationStructureKHR_T(AccelerationStructureKHR a)
    {
        return a?.__Instance ?? new AdamantiumVulkan.Core.Interop.VkAccelerationStructureKHR_T();
    }

    public static implicit operator AccelerationStructureKHR(AdamantiumVulkan.Core.Interop.VkAccelerationStructureKHR_T a)
    {
        return new AccelerationStructureKHR(a);
    }

}



