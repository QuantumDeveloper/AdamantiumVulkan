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

public unsafe partial class CommandBufferInheritanceConditionalRenderingInfoEXT : QBDisposableObject
{
    public CommandBufferInheritanceConditionalRenderingInfoEXT()
    {
    }

    public CommandBufferInheritanceConditionalRenderingInfoEXT(AdamantiumVulkan.Core.Interop.VkCommandBufferInheritanceConditionalRenderingInfoEXT _internal)
    {
        PNext = _internal.pNext;
        ConditionalRenderingEnable = _internal.conditionalRenderingEnable;
    }

    public StructureType SType => StructureType.CommandBufferInheritanceConditionalRenderingInfoExt;
    public void* PNext { get; set; }
    public VkBool32 ConditionalRenderingEnable { get; set; }

    public AdamantiumVulkan.Core.Interop.VkCommandBufferInheritanceConditionalRenderingInfoEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkCommandBufferInheritanceConditionalRenderingInfoEXT();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (ConditionalRenderingEnable != (uint)default)
        {
            _internal.conditionalRenderingEnable = ConditionalRenderingEnable;
        }
        return _internal;
    }

    public static implicit operator CommandBufferInheritanceConditionalRenderingInfoEXT(AdamantiumVulkan.Core.Interop.VkCommandBufferInheritanceConditionalRenderingInfoEXT c)
    {
        return new CommandBufferInheritanceConditionalRenderingInfoEXT(c);
    }

}



