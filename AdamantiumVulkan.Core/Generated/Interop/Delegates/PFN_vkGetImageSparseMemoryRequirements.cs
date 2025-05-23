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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 4185 Column: 26
public unsafe struct PFN_vkGetImageSparseMemoryRequirements
{
    public PFN_vkGetImageSparseMemoryRequirements(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkImage_T, ref uint*, AdamantiumVulkan.Core.Interop.VkSparseImageMemoryRequirements*, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkImage_T, ref uint*, AdamantiumVulkan.Core.Interop.VkSparseImageMemoryRequirements*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkImage_T image, ref uint* pSparseMemoryRequirementCount, AdamantiumVulkan.Core.Interop.VkSparseImageMemoryRequirements* pSparseMemoryRequirements)
    {
         InvokeFunc(device, image, ref pSparseMemoryRequirementCount, pSparseMemoryRequirements);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkImage_T image, ref uint* pSparseMemoryRequirementCount, AdamantiumVulkan.Core.Interop.VkSparseImageMemoryRequirements* pSparseMemoryRequirements)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkImage_T, ref uint*, AdamantiumVulkan.Core.Interop.VkSparseImageMemoryRequirements*, void>)ptr)(device, image, ref pSparseMemoryRequirementCount, pSparseMemoryRequirements);
    }

    public static explicit operator PFN_vkGetImageSparseMemoryRequirements(void* ptr) => new(ptr);
}


