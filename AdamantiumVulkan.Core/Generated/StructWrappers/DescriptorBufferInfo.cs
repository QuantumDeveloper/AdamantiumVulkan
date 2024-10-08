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

public unsafe partial class DescriptorBufferInfo : QBDisposableObject
{
    public DescriptorBufferInfo()
    {
    }

    public DescriptorBufferInfo(AdamantiumVulkan.Core.Interop.VkDescriptorBufferInfo _internal)
    {
        Buffer = new Buffer(_internal.buffer);
        Offset = _internal.offset;
        Range = _internal.range;
    }

    public Buffer Buffer { get; set; }
    public VkDeviceSize Offset { get; set; }
    public VkDeviceSize Range { get; set; }

    public AdamantiumVulkan.Core.Interop.VkDescriptorBufferInfo ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkDescriptorBufferInfo();
        if (Buffer != default)
        {
            _internal.buffer = Buffer;
        }
        if (Offset != (ulong)default)
        {
            _internal.offset = Offset;
        }
        if (Range != (ulong)default)
        {
            _internal.range = Range;
        }
        return _internal;
    }

    public static implicit operator DescriptorBufferInfo(AdamantiumVulkan.Core.Interop.VkDescriptorBufferInfo d)
    {
        return new DescriptorBufferInfo(d);
    }

}



