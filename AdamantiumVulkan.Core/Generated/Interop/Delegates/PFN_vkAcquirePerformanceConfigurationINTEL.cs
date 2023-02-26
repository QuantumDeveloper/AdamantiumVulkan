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

public unsafe struct PFN_vkAcquirePerformanceConfigurationINTEL
{
    public PFN_vkAcquirePerformanceConfigurationINTEL(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkPerformanceConfigurationAcquireInfoINTEL*, out AdamantiumVulkan.Core.Interop.VkPerformanceConfigurationINTEL_T, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkPerformanceConfigurationAcquireInfoINTEL*, out AdamantiumVulkan.Core.Interop.VkPerformanceConfigurationINTEL_T, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkPerformanceConfigurationAcquireInfoINTEL* pAcquireInfo, out AdamantiumVulkan.Core.Interop.VkPerformanceConfigurationINTEL_T pConfiguration)
    {
        return InvokeFunc(device, pAcquireInfo, out pConfiguration);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkPerformanceConfigurationAcquireInfoINTEL* pAcquireInfo, out AdamantiumVulkan.Core.Interop.VkPerformanceConfigurationINTEL_T pConfiguration)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkPerformanceConfigurationAcquireInfoINTEL*, out AdamantiumVulkan.Core.Interop.VkPerformanceConfigurationINTEL_T, Result>)ptr)(device, pAcquireInfo, out pConfiguration);
    }

    public static explicit operator PFN_vkAcquirePerformanceConfigurationINTEL(void* ptr) => new(ptr);
}


