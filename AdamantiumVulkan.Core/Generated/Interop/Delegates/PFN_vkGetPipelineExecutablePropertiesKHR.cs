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

public unsafe struct PFN_vkGetPipelineExecutablePropertiesKHR
{
    public PFN_vkGetPipelineExecutablePropertiesKHR(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkDevice_T, VkPipelineInfoKHR*, ref uint*, VkPipelineExecutablePropertiesKHR*, Result>)ptr;
    }

    private delegate* unmanaged<VkDevice_T, VkPipelineInfoKHR*, ref uint*, VkPipelineExecutablePropertiesKHR*, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(VkDevice_T device, VkPipelineInfoKHR* pPipelineInfo, ref uint* pExecutableCount, VkPipelineExecutablePropertiesKHR* pProperties)
    {
        return InvokeFunc(device, pPipelineInfo, ref pExecutableCount, pProperties);
    }
    public static Result Invoke(void* ptr, VkDevice_T device, VkPipelineInfoKHR* pPipelineInfo, ref uint* pExecutableCount, VkPipelineExecutablePropertiesKHR* pProperties)
    {
        return ((delegate* unmanaged<VkDevice_T, VkPipelineInfoKHR*, ref uint*, VkPipelineExecutablePropertiesKHR*, Result>)ptr)(device, pPipelineInfo, ref pExecutableCount, pProperties);
    }

    public static explicit operator PFN_vkGetPipelineExecutablePropertiesKHR(void* ptr) => new(ptr);
}

