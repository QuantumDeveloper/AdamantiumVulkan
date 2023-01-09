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

public unsafe partial class SemaphoreCreateInfo : QBDisposableObject
{
    public SemaphoreCreateInfo()
    {
    }

    public SemaphoreCreateInfo(AdamantiumVulkan.Core.Interop.VkSemaphoreCreateInfo _internal)
    {
        PNext = _internal.pNext;
        Flags = _internal.flags;
    }

    public StructureType SType => StructureType.SemaphoreCreateInfo;
    public void* PNext { get; set; }
    public VkSemaphoreCreateFlags Flags { get; set; }

    public AdamantiumVulkan.Core.Interop.VkSemaphoreCreateInfo ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkSemaphoreCreateInfo();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.flags = Flags;
        return _internal;
    }

    public static implicit operator SemaphoreCreateInfo(AdamantiumVulkan.Core.Interop.VkSemaphoreCreateInfo s)
    {
        return new SemaphoreCreateInfo(s);
    }

}



