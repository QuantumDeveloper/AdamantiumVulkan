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

// File: C:\VulkanSDK\1.4.309.0\Include\vulkan/vulkan_core.h Line: 14147 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkDebugUtilsMessengerCallbackDataEXT
{
    public StructureType sType;
    public void* pNext;
    public VkDebugUtilsMessengerCallbackDataFlagsEXT flags;
    public sbyte* pMessageIdName;
    public int messageIdNumber;
    public sbyte* pMessage;
    public uint queueLabelCount;
    public AdamantiumVulkan.Core.Interop.VkDebugUtilsLabelEXT* pQueueLabels;
    public uint cmdBufLabelCount;
    public AdamantiumVulkan.Core.Interop.VkDebugUtilsLabelEXT* pCmdBufLabels;
    public uint objectCount;
    public AdamantiumVulkan.Core.Interop.VkDebugUtilsObjectNameInfoEXT* pObjects;
}



