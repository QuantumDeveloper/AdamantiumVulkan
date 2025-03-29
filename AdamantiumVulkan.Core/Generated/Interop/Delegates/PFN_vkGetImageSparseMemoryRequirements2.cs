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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 5798 Column: 26
public unsafe struct PFN_vkGetImageSparseMemoryRequirements2
{
    public PFN_vkGetImageSparseMemoryRequirements2(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkImageSparseMemoryRequirementsInfo2*, ref uint*, AdamantiumVulkan.Core.Interop.VkSparseImageMemoryRequirements2*, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkImageSparseMemoryRequirementsInfo2*, ref uint*, AdamantiumVulkan.Core.Interop.VkSparseImageMemoryRequirements2*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkImageSparseMemoryRequirementsInfo2* pInfo, ref uint* pSparseMemoryRequirementCount, AdamantiumVulkan.Core.Interop.VkSparseImageMemoryRequirements2* pSparseMemoryRequirements)
    {
         InvokeFunc(device, pInfo, ref pSparseMemoryRequirementCount, pSparseMemoryRequirements);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkImageSparseMemoryRequirementsInfo2* pInfo, ref uint* pSparseMemoryRequirementCount, AdamantiumVulkan.Core.Interop.VkSparseImageMemoryRequirements2* pSparseMemoryRequirements)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkImageSparseMemoryRequirementsInfo2*, ref uint*, AdamantiumVulkan.Core.Interop.VkSparseImageMemoryRequirements2*, void>)ptr)(device, pInfo, ref pSparseMemoryRequirementCount, pSparseMemoryRequirements);
    }

    public static explicit operator PFN_vkGetImageSparseMemoryRequirements2(void* ptr) => new(ptr);
}


