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

public unsafe struct PFN_vkGetDeviceGroupPeerMemoryFeaturesKHR
{
    public PFN_vkGetDeviceGroupPeerMemoryFeaturesKHR(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkDevice_T, uint, uint, uint, ref VkPeerMemoryFeatureFlags*, void>)ptr;
    }

    private delegate* unmanaged<VkDevice_T, uint, uint, uint, ref VkPeerMemoryFeatureFlags*, void> InvokeFunc;

    public void* NativePointer { get; }

    public void Invoke(VkDevice_T device, uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex, ref VkPeerMemoryFeatureFlags* pPeerMemoryFeatures)
    {
         InvokeFunc(device, heapIndex, localDeviceIndex, remoteDeviceIndex, ref pPeerMemoryFeatures);
    }
    public static void Invoke(void* ptr, VkDevice_T device, uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex, ref VkPeerMemoryFeatureFlags* pPeerMemoryFeatures)
    {
         ((delegate* unmanaged<VkDevice_T, uint, uint, uint, ref VkPeerMemoryFeatureFlags*, void>)ptr)(device, heapIndex, localDeviceIndex, remoteDeviceIndex, ref pPeerMemoryFeatures);
    }

    public static explicit operator PFN_vkGetDeviceGroupPeerMemoryFeaturesKHR(void* ptr) => new(ptr);
}

