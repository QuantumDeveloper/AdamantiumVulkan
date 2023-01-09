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

public unsafe struct PFN_vkGetPhysicalDeviceFragmentShadingRatesKHR
{
    public PFN_vkGetPhysicalDeviceFragmentShadingRatesKHR(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkPhysicalDevice_T, ref uint*, VkPhysicalDeviceFragmentShadingRateKHR*, Result>)ptr;
    }

    private delegate* unmanaged<VkPhysicalDevice_T, ref uint*, VkPhysicalDeviceFragmentShadingRateKHR*, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(VkPhysicalDevice_T physicalDevice, ref uint* pFragmentShadingRateCount, VkPhysicalDeviceFragmentShadingRateKHR* pFragmentShadingRates)
    {
        return InvokeFunc(physicalDevice, ref pFragmentShadingRateCount, pFragmentShadingRates);
    }
    public static Result Invoke(void* ptr, VkPhysicalDevice_T physicalDevice, ref uint* pFragmentShadingRateCount, VkPhysicalDeviceFragmentShadingRateKHR* pFragmentShadingRates)
    {
        return ((delegate* unmanaged<VkPhysicalDevice_T, ref uint*, VkPhysicalDeviceFragmentShadingRateKHR*, Result>)ptr)(physicalDevice, ref pFragmentShadingRateCount, pFragmentShadingRates);
    }

    public static explicit operator PFN_vkGetPhysicalDeviceFragmentShadingRatesKHR(void* ptr) => new(ptr);
}


