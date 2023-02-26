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

public unsafe struct PFN_vkGetDeviceQueue
{
    public PFN_vkGetDeviceQueue(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, uint, uint, out AdamantiumVulkan.Core.Interop.VkQueue_T, void>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, uint, uint, out AdamantiumVulkan.Core.Interop.VkQueue_T, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, uint queueFamilyIndex, uint queueIndex, out AdamantiumVulkan.Core.Interop.VkQueue_T pQueue)
    {
         InvokeFunc(device, queueFamilyIndex, queueIndex, out pQueue);
    }
    public static void Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, uint queueFamilyIndex, uint queueIndex, out AdamantiumVulkan.Core.Interop.VkQueue_T pQueue)
    {
         ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, uint, uint, out AdamantiumVulkan.Core.Interop.VkQueue_T, void>)ptr)(device, queueFamilyIndex, queueIndex, out pQueue);
    }

    public static explicit operator PFN_vkGetDeviceQueue(void* ptr) => new(ptr);
}


