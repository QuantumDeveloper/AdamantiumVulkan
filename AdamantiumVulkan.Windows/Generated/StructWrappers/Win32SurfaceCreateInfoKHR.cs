// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System.Runtime.InteropServices;
using QuantumBinding.Utils;
using AdamantiumVulkan.Windows.Interop;
using AdamantiumVulkan.Core;

namespace AdamantiumVulkan.Windows;

public unsafe partial class Win32SurfaceCreateInfoKHR : QBDisposableObject
{
    public Win32SurfaceCreateInfoKHR()
    {
    }

    public Win32SurfaceCreateInfoKHR(AdamantiumVulkan.Windows.Interop.VkWin32SurfaceCreateInfoKHR _internal)
    {
        PNext = _internal.pNext;
        Flags = _internal.flags;
        Hinstance = _internal.hinstance;
        Hwnd = _internal.hwnd;
    }

    public StructureType SType => StructureType.Win32SurfaceCreateInfoKhr;
    public void* PNext { get; set; }
    public VkWin32SurfaceCreateFlagsKHR Flags { get; set; }
    public System.IntPtr Hinstance { get; set; }
    public System.IntPtr Hwnd { get; set; }

    public AdamantiumVulkan.Windows.Interop.VkWin32SurfaceCreateInfoKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Windows.Interop.VkWin32SurfaceCreateInfoKHR();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (Flags != (uint)default)
        {
            _internal.flags = Flags;
        }
        if (Hinstance != default)
        {
            _internal.hinstance = Hinstance;
        }
        if (Hwnd != default)
        {
            _internal.hwnd = Hwnd;
        }
        return _internal;
    }

    public static implicit operator Win32SurfaceCreateInfoKHR(AdamantiumVulkan.Windows.Interop.VkWin32SurfaceCreateInfoKHR w)
    {
        return new Win32SurfaceCreateInfoKHR(w);
    }

}



