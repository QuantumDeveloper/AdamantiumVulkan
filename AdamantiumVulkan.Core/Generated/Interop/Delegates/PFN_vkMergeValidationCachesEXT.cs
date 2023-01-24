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

public unsafe struct PFN_vkMergeValidationCachesEXT
{
    public PFN_vkMergeValidationCachesEXT(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkValidationCacheEXT_T, uint, AdamantiumVulkan.Core.Interop.VkValidationCacheEXT_T*, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkValidationCacheEXT_T, uint, AdamantiumVulkan.Core.Interop.VkValidationCacheEXT_T*, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkValidationCacheEXT_T dstCache, uint srcCacheCount, AdamantiumVulkan.Core.Interop.VkValidationCacheEXT_T* pSrcCaches)
    {
        return InvokeFunc(device, dstCache, srcCacheCount, pSrcCaches);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkValidationCacheEXT_T dstCache, uint srcCacheCount, AdamantiumVulkan.Core.Interop.VkValidationCacheEXT_T* pSrcCaches)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkValidationCacheEXT_T, uint, AdamantiumVulkan.Core.Interop.VkValidationCacheEXT_T*, Result>)ptr)(device, dstCache, srcCacheCount, pSrcCaches);
    }

    public static explicit operator PFN_vkMergeValidationCachesEXT(void* ptr) => new(ptr);
}


