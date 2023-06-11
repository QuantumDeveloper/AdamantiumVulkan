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

public unsafe struct PFN_vkBindOpticalFlowSessionImageNV
{
    public PFN_vkBindOpticalFlowSessionImageNV(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkOpticalFlowSessionNV_T, OpticalFlowSessionBindingPointNV, AdamantiumVulkan.Core.Interop.VkImageView_T, ImageLayout, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkOpticalFlowSessionNV_T, OpticalFlowSessionBindingPointNV, AdamantiumVulkan.Core.Interop.VkImageView_T, ImageLayout, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkOpticalFlowSessionNV_T session, OpticalFlowSessionBindingPointNV bindingPoint, AdamantiumVulkan.Core.Interop.VkImageView_T view, ImageLayout layout)
    {
        return InvokeFunc(device, session, bindingPoint, view, layout);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkOpticalFlowSessionNV_T session, OpticalFlowSessionBindingPointNV bindingPoint, AdamantiumVulkan.Core.Interop.VkImageView_T view, ImageLayout layout)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkOpticalFlowSessionNV_T, OpticalFlowSessionBindingPointNV, AdamantiumVulkan.Core.Interop.VkImageView_T, ImageLayout, Result>)ptr)(device, session, bindingPoint, view, layout);
    }

    public static explicit operator PFN_vkBindOpticalFlowSessionImageNV(void* ptr) => new(ptr);
}

