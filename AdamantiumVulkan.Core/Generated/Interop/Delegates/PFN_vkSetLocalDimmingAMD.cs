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

public unsafe struct PFN_vkSetLocalDimmingAMD
{
    public PFN_vkSetLocalDimmingAMD(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkDevice_T, VkSwapchainKHR_T, VkBool32, void>)ptr;
    }

    private delegate* unmanaged<VkDevice_T, VkSwapchainKHR_T, VkBool32, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(VkDevice_T device, VkSwapchainKHR_T swapChain, VkBool32 localDimmingEnable)
    {
         InvokeFunc(device, swapChain, localDimmingEnable);
    }
    public static void Invoke(void* ptr, VkDevice_T device, VkSwapchainKHR_T swapChain, VkBool32 localDimmingEnable)
    {
         ((delegate* unmanaged<VkDevice_T, VkSwapchainKHR_T, VkBool32, void>)ptr)(device, swapChain, localDimmingEnable);
    }

    public static explicit operator PFN_vkSetLocalDimmingAMD(void* ptr) => new(ptr);
}


