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

public unsafe struct PFN_vkCmdSetStencilOp
{
    public PFN_vkCmdSetStencilOp(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkCommandBuffer_T, VkStencilFaceFlags, StencilOp, StencilOp, StencilOp, CompareOp, void>)ptr;
    }

    private delegate* unmanaged<VkCommandBuffer_T, VkStencilFaceFlags, StencilOp, StencilOp, StencilOp, CompareOp, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(VkCommandBuffer_T commandBuffer, VkStencilFaceFlags faceMask, StencilOp failOp, StencilOp passOp, StencilOp depthFailOp, CompareOp compareOp)
    {
         InvokeFunc(commandBuffer, faceMask, failOp, passOp, depthFailOp, compareOp);
    }
    public static void Invoke(void* ptr, VkCommandBuffer_T commandBuffer, VkStencilFaceFlags faceMask, StencilOp failOp, StencilOp passOp, StencilOp depthFailOp, CompareOp compareOp)
    {
         ((delegate* unmanaged<VkCommandBuffer_T, VkStencilFaceFlags, StencilOp, StencilOp, StencilOp, CompareOp, void>)ptr)(commandBuffer, faceMask, failOp, passOp, depthFailOp, compareOp);
    }

    public static explicit operator PFN_vkCmdSetStencilOp(void* ptr) => new(ptr);
}


