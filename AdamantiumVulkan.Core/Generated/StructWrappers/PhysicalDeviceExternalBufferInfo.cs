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

public unsafe partial class PhysicalDeviceExternalBufferInfo : QBDisposableObject
{
    public PhysicalDeviceExternalBufferInfo()
    {
    }

    public PhysicalDeviceExternalBufferInfo(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceExternalBufferInfo _internal)
    {
        PNext = _internal.pNext;
        Flags = _internal.flags;
        Usage = _internal.usage;
        HandleType = _internal.handleType;
    }

    public StructureType SType => StructureType.PhysicalDeviceExternalBufferInfo;
    public void* PNext { get; set; }
    public VkBufferCreateFlags Flags { get; set; }
    public VkBufferUsageFlags Usage { get; set; }
    public ExternalMemoryHandleTypeFlagBits HandleType { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceExternalBufferInfo ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceExternalBufferInfo();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (Flags != (uint)default)
        {
            _internal.flags = Flags;
        }
        if (Usage != (uint)default)
        {
            _internal.usage = Usage;
        }
        if (HandleType != default)
        {
            _internal.handleType = HandleType;
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceExternalBufferInfo(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceExternalBufferInfo p)
    {
        return new PhysicalDeviceExternalBufferInfo(p);
    }

}



