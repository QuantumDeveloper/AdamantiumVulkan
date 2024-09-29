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

public unsafe partial class PushConstantRange : QBDisposableObject
{
    public PushConstantRange()
    {
    }

    public PushConstantRange(AdamantiumVulkan.Core.Interop.VkPushConstantRange _internal)
    {
        StageFlags = _internal.stageFlags;
        Offset = _internal.offset;
        Size = _internal.size;
    }

    public VkShaderStageFlags StageFlags { get; set; }
    public uint Offset { get; set; }
    public uint Size { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPushConstantRange ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPushConstantRange();
        if (StageFlags != (uint)default)
        {
            _internal.stageFlags = StageFlags;
        }
        if (Offset != default)
        {
            _internal.offset = Offset;
        }
        if (Size != default)
        {
            _internal.size = Size;
        }
        return _internal;
    }

    public static implicit operator PushConstantRange(AdamantiumVulkan.Core.Interop.VkPushConstantRange p)
    {
        return new PushConstantRange(p);
    }

}



