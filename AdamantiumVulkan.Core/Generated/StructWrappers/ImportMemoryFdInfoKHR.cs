// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System.Runtime.InteropServices;
using QuantumBinding.Utils;
using AdamantiumVulkan.Core.Interop;

namespace AdamantiumVulkan.Core;

public unsafe partial class ImportMemoryFdInfoKHR : QBDisposableObject
{
    public ImportMemoryFdInfoKHR()
    {
    }

    public ImportMemoryFdInfoKHR(AdamantiumVulkan.Core.Interop.VkImportMemoryFdInfoKHR _internal)
    {
        PNext = _internal.pNext;
        HandleType = _internal.handleType;
        Fd = _internal.fd;
    }

    public StructureType SType => StructureType.ImportMemoryFdInfoKhr;
    public void* PNext { get; set; }
    public ExternalMemoryHandleTypeFlagBits HandleType { get; set; }
    public int Fd { get; set; }

    public AdamantiumVulkan.Core.Interop.VkImportMemoryFdInfoKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkImportMemoryFdInfoKHR();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (HandleType != default)
        {
            _internal.handleType = HandleType;
        }
        if (Fd != default)
        {
            _internal.fd = Fd;
        }
        return _internal;
    }

    public static implicit operator ImportMemoryFdInfoKHR(AdamantiumVulkan.Core.Interop.VkImportMemoryFdInfoKHR i)
    {
        return new ImportMemoryFdInfoKHR(i);
    }

}



