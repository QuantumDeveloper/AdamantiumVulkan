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

public unsafe struct PFN_vkCmdSetViewportShadingRatePaletteNV
{
    public PFN_vkCmdSetViewportShadingRatePaletteNV(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkCommandBuffer_T, uint, uint, VkShadingRatePaletteNV*, void>)ptr;
    }

    private delegate* unmanaged<VkCommandBuffer_T, uint, uint, VkShadingRatePaletteNV*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(VkCommandBuffer_T commandBuffer, uint firstViewport, uint viewportCount, VkShadingRatePaletteNV* pShadingRatePalettes)
    {
         InvokeFunc(commandBuffer, firstViewport, viewportCount, pShadingRatePalettes);
    }
    public static void Invoke(void* ptr, VkCommandBuffer_T commandBuffer, uint firstViewport, uint viewportCount, VkShadingRatePaletteNV* pShadingRatePalettes)
    {
         ((delegate* unmanaged<VkCommandBuffer_T, uint, uint, VkShadingRatePaletteNV*, void>)ptr)(commandBuffer, firstViewport, viewportCount, pShadingRatePalettes);
    }

    public static explicit operator PFN_vkCmdSetViewportShadingRatePaletteNV(void* ptr) => new(ptr);
}

