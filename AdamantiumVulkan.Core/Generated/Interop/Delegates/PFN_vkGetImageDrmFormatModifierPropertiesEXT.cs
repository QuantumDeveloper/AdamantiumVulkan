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

public unsafe struct PFN_vkGetImageDrmFormatModifierPropertiesEXT
{
    public PFN_vkGetImageDrmFormatModifierPropertiesEXT(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkDevice_T, VkImage_T, VkImageDrmFormatModifierPropertiesEXT*, Result>)ptr;
    }

    private delegate* unmanaged<VkDevice_T, VkImage_T, VkImageDrmFormatModifierPropertiesEXT*, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(VkDevice_T device, VkImage_T image, VkImageDrmFormatModifierPropertiesEXT* pProperties)
    {
        return InvokeFunc(device, image, pProperties);
    }
    public static Result Invoke(void* ptr, VkDevice_T device, VkImage_T image, VkImageDrmFormatModifierPropertiesEXT* pProperties)
    {
        return ((delegate* unmanaged<VkDevice_T, VkImage_T, VkImageDrmFormatModifierPropertiesEXT*, Result>)ptr)(device, image, pProperties);
    }

    public static explicit operator PFN_vkGetImageDrmFormatModifierPropertiesEXT(void* ptr) => new(ptr);
}


