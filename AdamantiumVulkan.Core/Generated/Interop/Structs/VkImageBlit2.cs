// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AdamantiumVulkan.Core;

namespace AdamantiumVulkan.Core.Interop;

// File: C:\VulkanSDK\1.3.283.0\Include\vulkan/vulkan_core.h Line: 7089 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkImageBlit2
{
    public StructureType sType;
    public void* pNext;
    public VkImageSubresourceLayers srcSubresource;
    public VkOffset3D0__FixedBuffer srcOffsets;
    public VkImageSubresourceLayers dstSubresource;
    public VkOffset3D0__FixedBuffer dstOffsets;

    [StructLayout(LayoutKind.Sequential)]
    public partial struct VkOffset3D0__FixedBuffer
    {
        public VkOffset3D item0;
        public VkOffset3D item1;

        public VkOffset3D this[int index]
        {
            get => Unsafe.Add(ref item0, index);
            set => Unsafe.Add(ref item0, index) = value;
        }
    }
}



