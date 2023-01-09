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

public unsafe struct PFN_vkGetBufferOpaqueCaptureDescriptorDataEXT
{
    public PFN_vkGetBufferOpaqueCaptureDescriptorDataEXT(void* ptr)
    {
        NativePointer = ptr;
        InvokeFunc = (delegate* unmanaged<VkDevice_T, VkBufferCaptureDescriptorDataInfoEXT*, void*, Result>)ptr;
    }

    private delegate* unmanaged<VkDevice_T, VkBufferCaptureDescriptorDataInfoEXT*, void*, Result> InvokeFunc;

    public void* NativePointer { get; }

    public Result Invoke(VkDevice_T device, VkBufferCaptureDescriptorDataInfoEXT* pInfo, void* pData)
    {
        return InvokeFunc(device, pInfo, pData);
    }
    public static Result Invoke(void* ptr, VkDevice_T device, VkBufferCaptureDescriptorDataInfoEXT* pInfo, void* pData)
    {
        return ((delegate* unmanaged<VkDevice_T, VkBufferCaptureDescriptorDataInfoEXT*, void*, Result>)ptr)(device, pInfo, pData);
    }

    public static explicit operator PFN_vkGetBufferOpaqueCaptureDescriptorDataEXT(void* ptr) => new(ptr);
}


