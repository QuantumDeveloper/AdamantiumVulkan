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

public unsafe struct PFN_vkQueueInsertDebugUtilsLabelEXT
{
    public PFN_vkQueueInsertDebugUtilsLabelEXT(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkQueue_T, AdamantiumVulkan.Core.Interop.VkDebugUtilsLabelEXT*, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkQueue_T, AdamantiumVulkan.Core.Interop.VkDebugUtilsLabelEXT*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkQueue_T queue, AdamantiumVulkan.Core.Interop.VkDebugUtilsLabelEXT* pLabelInfo)
    {
         InvokeFunc(queue, pLabelInfo);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkQueue_T queue, AdamantiumVulkan.Core.Interop.VkDebugUtilsLabelEXT* pLabelInfo)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkQueue_T, AdamantiumVulkan.Core.Interop.VkDebugUtilsLabelEXT*, void>)ptr)(queue, pLabelInfo);
    }

    public static explicit operator PFN_vkQueueInsertDebugUtilsLabelEXT(void* ptr) => new(ptr);
}


