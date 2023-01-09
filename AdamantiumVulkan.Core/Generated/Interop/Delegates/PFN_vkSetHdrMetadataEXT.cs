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

public unsafe struct PFN_vkSetHdrMetadataEXT
{
    public PFN_vkSetHdrMetadataEXT(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkDevice_T, uint, VkSwapchainKHR_T*, VkHdrMetadataEXT*, void>)ptr;
    }

    private delegate* unmanaged<VkDevice_T, uint, VkSwapchainKHR_T*, VkHdrMetadataEXT*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(VkDevice_T device, uint swapchainCount, VkSwapchainKHR_T* pSwapchains, VkHdrMetadataEXT* pMetadata)
    {
         InvokeFunc(device, swapchainCount, pSwapchains, pMetadata);
    }
    public static void Invoke(void* ptr, VkDevice_T device, uint swapchainCount, VkSwapchainKHR_T* pSwapchains, VkHdrMetadataEXT* pMetadata)
    {
         ((delegate* unmanaged<VkDevice_T, uint, VkSwapchainKHR_T*, VkHdrMetadataEXT*, void>)ptr)(device, swapchainCount, pSwapchains, pMetadata);
    }

    public static explicit operator PFN_vkSetHdrMetadataEXT(void* ptr) => new(ptr);
}

