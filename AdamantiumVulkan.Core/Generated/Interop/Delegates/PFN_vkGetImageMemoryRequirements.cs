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

public unsafe struct PFN_vkGetImageMemoryRequirements
{
    public PFN_vkGetImageMemoryRequirements(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkDevice_T, VkImage_T, VkMemoryRequirements*, void>)ptr;
    }

    private delegate* unmanaged<VkDevice_T, VkImage_T, VkMemoryRequirements*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(VkDevice_T device, VkImage_T image, VkMemoryRequirements* pMemoryRequirements)
    {
         InvokeFunc(device, image, pMemoryRequirements);
    }
    public static void Invoke(void* ptr, VkDevice_T device, VkImage_T image, VkMemoryRequirements* pMemoryRequirements)
    {
         ((delegate* unmanaged<VkDevice_T, VkImage_T, VkMemoryRequirements*, void>)ptr)(device, image, pMemoryRequirements);
    }

    public static explicit operator PFN_vkGetImageMemoryRequirements(void* ptr) => new(ptr);
}


