// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System.Security;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using QuantumBinding.Utils;
using AdamantiumVulkan.Core;

namespace AdamantiumVulkan.Core.Interop;

public unsafe struct PFN_vkCmdSetCoverageModulationModeNV
{
    public PFN_vkCmdSetCoverageModulationModeNV(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkCommandBuffer_T, CoverageModulationModeNV, void>)ptr;
    }

    private delegate* unmanaged<VkCommandBuffer_T, CoverageModulationModeNV, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(VkCommandBuffer_T commandBuffer, CoverageModulationModeNV coverageModulationMode)
    {
         InvokeFunc(commandBuffer, coverageModulationMode);
    }
    public static void Invoke(void* ptr, VkCommandBuffer_T commandBuffer, CoverageModulationModeNV coverageModulationMode)
    {
         ((delegate* unmanaged<VkCommandBuffer_T, CoverageModulationModeNV, void>)ptr)(commandBuffer, coverageModulationMode);
    }

    public static explicit operator PFN_vkCmdSetCoverageModulationModeNV(void* ptr) => new(ptr);
}


