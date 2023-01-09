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

public unsafe struct PFN_vkGetPipelineExecutableInternalRepresentationsKHR
{
    public PFN_vkGetPipelineExecutableInternalRepresentationsKHR(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkDevice_T, VkPipelineExecutableInfoKHR*, ref uint*, VkPipelineExecutableInternalRepresentationKHR*, Result>)ptr;
    }

    private delegate* unmanaged<VkDevice_T, VkPipelineExecutableInfoKHR*, ref uint*, VkPipelineExecutableInternalRepresentationKHR*, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(VkDevice_T device, VkPipelineExecutableInfoKHR* pExecutableInfo, ref uint* pInternalRepresentationCount, VkPipelineExecutableInternalRepresentationKHR* pInternalRepresentations)
    {
        return InvokeFunc(device, pExecutableInfo, ref pInternalRepresentationCount, pInternalRepresentations);
    }
    public static Result Invoke(void* ptr, VkDevice_T device, VkPipelineExecutableInfoKHR* pExecutableInfo, ref uint* pInternalRepresentationCount, VkPipelineExecutableInternalRepresentationKHR* pInternalRepresentations)
    {
        return ((delegate* unmanaged<VkDevice_T, VkPipelineExecutableInfoKHR*, ref uint*, VkPipelineExecutableInternalRepresentationKHR*, Result>)ptr)(device, pExecutableInfo, ref pInternalRepresentationCount, pInternalRepresentations);
    }

    public static explicit operator PFN_vkGetPipelineExecutableInternalRepresentationsKHR(void* ptr) => new(ptr);
}


