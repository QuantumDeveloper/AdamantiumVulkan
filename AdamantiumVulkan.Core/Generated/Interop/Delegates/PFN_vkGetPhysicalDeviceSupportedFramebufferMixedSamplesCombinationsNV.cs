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

public unsafe struct PFN_vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV
{
    public PFN_vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, ref uint*, AdamantiumVulkan.Core.Interop.VkFramebufferMixedSamplesCombinationNV*, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, ref uint*, AdamantiumVulkan.Core.Interop.VkFramebufferMixedSamplesCombinationNV*, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, ref uint* pCombinationCount, AdamantiumVulkan.Core.Interop.VkFramebufferMixedSamplesCombinationNV* pCombinations)
    {
        return InvokeFunc(physicalDevice, ref pCombinationCount, pCombinations);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T physicalDevice, ref uint* pCombinationCount, AdamantiumVulkan.Core.Interop.VkFramebufferMixedSamplesCombinationNV* pCombinations)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkPhysicalDevice_T, ref uint*, AdamantiumVulkan.Core.Interop.VkFramebufferMixedSamplesCombinationNV*, Result>)ptr)(physicalDevice, ref pCombinationCount, pCombinations);
    }

    public static explicit operator PFN_vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(void* ptr) => new(ptr);
}


