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
using AdamantiumVulkan.Core.Interop;

namespace AdamantiumVulkan.Windows.Interop;

public unsafe struct PFN_vkGetDeviceGroupSurfacePresentModes2EXT
{
    public PFN_vkGetDeviceGroupSurfacePresentModes2EXT(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkPhysicalDeviceSurfaceInfo2KHR*, ref VkDeviceGroupPresentModeFlagsKHR*, Result>)ptr;
    }

    private delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkPhysicalDeviceSurfaceInfo2KHR*, ref VkDeviceGroupPresentModeFlagsKHR*, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, ref VkDeviceGroupPresentModeFlagsKHR* pModes)
    {
        return InvokeFunc(device, pSurfaceInfo, ref pModes);
    }
    public static Result Invoke(void* ptr, AdamantiumVulkan.Core.Interop.VkDevice_T device, AdamantiumVulkan.Core.Interop.VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, ref VkDeviceGroupPresentModeFlagsKHR* pModes)
    {
        return ((delegate* unmanaged<AdamantiumVulkan.Core.Interop.VkDevice_T, AdamantiumVulkan.Core.Interop.VkPhysicalDeviceSurfaceInfo2KHR*, ref VkDeviceGroupPresentModeFlagsKHR*, Result>)ptr)(device, pSurfaceInfo, ref pModes);
    }

    public static explicit operator PFN_vkGetDeviceGroupSurfacePresentModes2EXT(void* ptr) => new(ptr);
}


