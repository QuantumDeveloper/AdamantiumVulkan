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

public unsafe partial class SubresourceHostMemcpySize : QBDisposableObject
{
    public SubresourceHostMemcpySize()
    {
    }

    public SubresourceHostMemcpySize(AdamantiumVulkan.Core.Interop.VkSubresourceHostMemcpySize _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        Size = _internal.size;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkDeviceSize Size { get; set; }

    public AdamantiumVulkan.Core.Interop.VkSubresourceHostMemcpySize ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkSubresourceHostMemcpySize();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (Size != (ulong)default)
        {
            _internal.size = Size;
        }
        return _internal;
    }

    public static implicit operator SubresourceHostMemcpySize(AdamantiumVulkan.Core.Interop.VkSubresourceHostMemcpySize s)
    {
        return new SubresourceHostMemcpySize(s);
    }

}



