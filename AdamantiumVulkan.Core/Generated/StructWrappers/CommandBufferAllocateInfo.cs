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

public unsafe partial class CommandBufferAllocateInfo : QBDisposableObject
{
    public CommandBufferAllocateInfo()
    {
    }

    public CommandBufferAllocateInfo(AdamantiumVulkan.Core.Interop.VkCommandBufferAllocateInfo _internal)
    {
        PNext = _internal.pNext;
        CommandPool = new CommandPool(_internal.commandPool);
        Level = _internal.level;
        CommandBufferCount = _internal.commandBufferCount;
    }

    public StructureType SType => StructureType.CommandBufferAllocateInfo;
    public void* PNext { get; set; }
    public CommandPool CommandPool { get; set; }
    public CommandBufferLevel Level { get; set; }
    public uint CommandBufferCount { get; set; }

    public AdamantiumVulkan.Core.Interop.VkCommandBufferAllocateInfo ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkCommandBufferAllocateInfo();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.commandPool = CommandPool;
        _internal.level = Level;
        _internal.commandBufferCount = CommandBufferCount;
        return _internal;
    }

    public static implicit operator CommandBufferAllocateInfo(AdamantiumVulkan.Core.Interop.VkCommandBufferAllocateInfo c)
    {
        return new CommandBufferAllocateInfo(c);
    }

}



