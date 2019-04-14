// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

namespace AdamantiumVulkan.Windows.Interop
{
    using System;
    using System.Runtime.InteropServices;
    using AdamantiumVulkan.Core;
    using AdamantiumVulkan.Core.Interop;

    // File: C:\VulkanSDK\1.1.101.0\Include\vulkan/vulkan_win32.h Line: 34 Column: 17
    [StructLayout(LayoutKind.Sequential)]
    public partial struct Win32SurfaceCreateFlagsKHR
    {
        public uint value;

        public static implicit operator uint(Win32SurfaceCreateFlagsKHR w)
        {
            return w.value;
        }

        public static implicit operator Win32SurfaceCreateFlagsKHR(uint w)
        {
            return new Win32SurfaceCreateFlagsKHR(){value = w};
        }

    }

    // File: C:\VulkanSDK\1.1.101.0\Include\vulkan/vulkan_win32.h Line: 36 Column: 16
    [StructLayout(LayoutKind.Sequential)]
    public partial struct Win32SurfaceCreateInfoKHR
    {
        public StructureType sType;

        public System.IntPtr pNext;

        public uint flags;

        public System.IntPtr hinstance;

        public System.IntPtr hwnd;

    }

    // File: C:\VulkanSDK\1.1.101.0\Include\vulkan/vulkan_win32.h Line: 64 Column: 16
    [StructLayout(LayoutKind.Sequential)]
    public partial struct ImportMemoryWin32HandleInfoKHR
    {
        public StructureType sType;

        public System.IntPtr pNext;

        public ExternalMemoryHandleTypeFlagBits handleType;

        public System.IntPtr handle;

        public char name;

    }

    // File: C:\VulkanSDK\1.1.101.0\Include\vulkan/vulkan_win32.h Line: 72 Column: 16
    [StructLayout(LayoutKind.Sequential)]
    public partial struct ExportMemoryWin32HandleInfoKHR
    {
        public StructureType sType;

        public System.IntPtr pNext;

        public System.IntPtr pAttributes;

        public uint dwAccess;

        public char name;

    }

    // File: C:\VulkanSDK\1.1.101.0\Include\vulkan/vulkan_win32.h Line: 80 Column: 16
    [StructLayout(LayoutKind.Sequential)]
    public partial struct MemoryWin32HandlePropertiesKHR
    {
        public StructureType sType;

        public System.IntPtr pNext;

        public uint memoryTypeBits;

    }

    // File: C:\VulkanSDK\1.1.101.0\Include\vulkan/vulkan_win32.h Line: 86 Column: 16
    [StructLayout(LayoutKind.Sequential)]
    public partial struct MemoryGetWin32HandleInfoKHR
    {
        public StructureType sType;

        public System.IntPtr pNext;

        public DeviceMemory_T memory;

        public ExternalMemoryHandleTypeFlagBits handleType;

    }

    // File: C:\VulkanSDK\1.1.101.0\Include\vulkan/vulkan_win32.h Line: 114 Column: 16
    [StructLayout(LayoutKind.Sequential)]
    public partial struct Win32KeyedMutexAcquireReleaseInfoKHR
    {
        public StructureType sType;

        public System.IntPtr pNext;

        public uint acquireCount;

        public System.IntPtr pAcquireSyncs;

        public System.IntPtr pAcquireKeys;

        public System.IntPtr pAcquireTimeouts;

        public uint releaseCount;

        public System.IntPtr pReleaseSyncs;

        public System.IntPtr pReleaseKeys;

    }

    // File: C:\VulkanSDK\1.1.101.0\Include\vulkan/vulkan_win32.h Line: 132 Column: 16
    [StructLayout(LayoutKind.Sequential)]
    public partial struct ImportSemaphoreWin32HandleInfoKHR
    {
        public StructureType sType;

        public System.IntPtr pNext;

        public Semaphore_T semaphore;

        public uint flags;

        public ExternalSemaphoreHandleTypeFlagBits handleType;

        public System.IntPtr handle;

        public char name;

    }

    // File: C:\VulkanSDK\1.1.101.0\Include\vulkan/vulkan_win32.h Line: 142 Column: 16
    [StructLayout(LayoutKind.Sequential)]
    public partial struct ExportSemaphoreWin32HandleInfoKHR
    {
        public StructureType sType;

        public System.IntPtr pNext;

        public System.IntPtr pAttributes;

        public uint dwAccess;

        public char name;

    }

    // File: C:\VulkanSDK\1.1.101.0\Include\vulkan/vulkan_win32.h Line: 150 Column: 16
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12FenceSubmitInfoKHR
    {
        public StructureType sType;

        public System.IntPtr pNext;

        public uint waitSemaphoreValuesCount;

        public System.IntPtr pWaitSemaphoreValues;

        public uint signalSemaphoreValuesCount;

        public System.IntPtr pSignalSemaphoreValues;

    }

    // File: C:\VulkanSDK\1.1.101.0\Include\vulkan/vulkan_win32.h Line: 159 Column: 16
    [StructLayout(LayoutKind.Sequential)]
    public partial struct SemaphoreGetWin32HandleInfoKHR
    {
        public StructureType sType;

        public System.IntPtr pNext;

        public Semaphore_T semaphore;

        public ExternalSemaphoreHandleTypeFlagBits handleType;

    }

    // File: C:\VulkanSDK\1.1.101.0\Include\vulkan/vulkan_win32.h Line: 185 Column: 16
    [StructLayout(LayoutKind.Sequential)]
    public partial struct ImportFenceWin32HandleInfoKHR
    {
        public StructureType sType;

        public System.IntPtr pNext;

        public Fence_T fence;

        public uint flags;

        public ExternalFenceHandleTypeFlagBits handleType;

        public System.IntPtr handle;

        public char name;

    }

    // File: C:\VulkanSDK\1.1.101.0\Include\vulkan/vulkan_win32.h Line: 195 Column: 16
    [StructLayout(LayoutKind.Sequential)]
    public partial struct ExportFenceWin32HandleInfoKHR
    {
        public StructureType sType;

        public System.IntPtr pNext;

        public System.IntPtr pAttributes;

        public uint dwAccess;

        public char name;

    }

    // File: C:\VulkanSDK\1.1.101.0\Include\vulkan/vulkan_win32.h Line: 203 Column: 16
    [StructLayout(LayoutKind.Sequential)]
    public partial struct FenceGetWin32HandleInfoKHR
    {
        public StructureType sType;

        public System.IntPtr pNext;

        public Fence_T fence;

        public ExternalFenceHandleTypeFlagBits handleType;

    }

    // File: C:\VulkanSDK\1.1.101.0\Include\vulkan/vulkan_win32.h Line: 229 Column: 16
    [StructLayout(LayoutKind.Sequential)]
    public partial struct ImportMemoryWin32HandleInfoNV
    {
        public StructureType sType;

        public System.IntPtr pNext;

        public uint handleType;

        public System.IntPtr handle;

    }

    // File: C:\VulkanSDK\1.1.101.0\Include\vulkan/vulkan_win32.h Line: 236 Column: 16
    [StructLayout(LayoutKind.Sequential)]
    public partial struct ExportMemoryWin32HandleInfoNV
    {
        public StructureType sType;

        public System.IntPtr pNext;

        public System.IntPtr pAttributes;

        public uint dwAccess;

    }

    // File: C:\VulkanSDK\1.1.101.0\Include\vulkan/vulkan_win32.h Line: 258 Column: 16
    [StructLayout(LayoutKind.Sequential)]
    public partial struct Win32KeyedMutexAcquireReleaseInfoNV
    {
        public StructureType sType;

        public System.IntPtr pNext;

        public uint acquireCount;

        public System.IntPtr pAcquireSyncs;

        public System.IntPtr pAcquireKeys;

        public System.IntPtr pAcquireTimeoutMilliseconds;

        public uint releaseCount;

        public System.IntPtr pReleaseSyncs;

        public System.IntPtr pReleaseKeys;

    }


}

