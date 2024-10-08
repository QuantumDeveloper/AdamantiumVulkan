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

public unsafe partial class ExportFenceWin32HandleInfoKHR : QBDisposableObject
{
    public ExportFenceWin32HandleInfoKHR()
    {
    }

    public ExportFenceWin32HandleInfoKHR(AdamantiumVulkan.Windows.Interop.VkExportFenceWin32HandleInfoKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        PAttributes = _internal.pAttributes;
        DwAccess = _internal.dwAccess;
        Name = _internal.name;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public void* PAttributes { get; set; }
    public uint DwAccess { get; set; }
    public char Name { get; set; }

    public AdamantiumVulkan.Windows.Interop.VkExportFenceWin32HandleInfoKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Windows.Interop.VkExportFenceWin32HandleInfoKHR();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        _internal.pAttributes = PAttributes;
        if (DwAccess != default)
        {
            _internal.dwAccess = DwAccess;
        }
        if (Name != default)
        {
            _internal.name = Name;
        }
        return _internal;
    }

    public static implicit operator ExportFenceWin32HandleInfoKHR(AdamantiumVulkan.Windows.Interop.VkExportFenceWin32HandleInfoKHR e)
    {
        return new ExportFenceWin32HandleInfoKHR(e);
    }

}



