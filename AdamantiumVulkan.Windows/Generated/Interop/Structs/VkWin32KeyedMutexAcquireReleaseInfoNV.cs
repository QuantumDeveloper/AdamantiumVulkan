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
using AdamantiumVulkan.Core.Interop;

namespace AdamantiumVulkan.Windows.Interop;

// File: C:\VulkanSDK\1.4.304.0\Include\vulkan/vulkan_win32.h Line: 249 Column: 16
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkWin32KeyedMutexAcquireReleaseInfoNV
{
    public StructureType sType;
    public void* pNext;
    public uint acquireCount;
    public VkDeviceMemory_T* pAcquireSyncs;
    public ulong* pAcquireKeys;
    public uint* pAcquireTimeoutMilliseconds;
    public uint releaseCount;
    public VkDeviceMemory_T* pReleaseSyncs;
    public ulong* pReleaseKeys;
}



