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

public unsafe struct PFN_vkCopyMemoryToMicromapEXT
{
    public PFN_vkCopyMemoryToMicromapEXT(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkDevice_T, VkDeferredOperationKHR_T, VkCopyMemoryToMicromapInfoEXT*, Result>)ptr;
    }

    private delegate* unmanaged<VkDevice_T, VkDeferredOperationKHR_T, VkCopyMemoryToMicromapInfoEXT*, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(VkDevice_T device, VkDeferredOperationKHR_T deferredOperation, VkCopyMemoryToMicromapInfoEXT* pInfo)
    {
        return InvokeFunc(device, deferredOperation, pInfo);
    }
    public static Result Invoke(void* ptr, VkDevice_T device, VkDeferredOperationKHR_T deferredOperation, VkCopyMemoryToMicromapInfoEXT* pInfo)
    {
        return ((delegate* unmanaged<VkDevice_T, VkDeferredOperationKHR_T, VkCopyMemoryToMicromapInfoEXT*, Result>)ptr)(device, deferredOperation, pInfo);
    }

    public static explicit operator PFN_vkCopyMemoryToMicromapEXT(void* ptr) => new(ptr);
}


