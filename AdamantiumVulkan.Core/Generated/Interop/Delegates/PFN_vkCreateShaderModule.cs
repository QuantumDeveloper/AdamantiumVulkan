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

public unsafe struct PFN_vkCreateShaderModule
{
    public PFN_vkCreateShaderModule(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkDevice_T, VkShaderModuleCreateInfo*, VkAllocationCallbacks*, out VkShaderModule_T, Result>)ptr;
    }

    private delegate* unmanaged<VkDevice_T, VkShaderModuleCreateInfo*, VkAllocationCallbacks*, out VkShaderModule_T, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(VkDevice_T device, VkShaderModuleCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkShaderModule_T pShaderModule)
    {
        return InvokeFunc(device, pCreateInfo, pAllocator, out pShaderModule);
    }
    public static Result Invoke(void* ptr, VkDevice_T device, VkShaderModuleCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, out VkShaderModule_T pShaderModule)
    {
        return ((delegate* unmanaged<VkDevice_T, VkShaderModuleCreateInfo*, VkAllocationCallbacks*, out VkShaderModule_T, Result>)ptr)(device, pCreateInfo, pAllocator, out pShaderModule);
    }

    public static explicit operator PFN_vkCreateShaderModule(void* ptr) => new(ptr);
}


