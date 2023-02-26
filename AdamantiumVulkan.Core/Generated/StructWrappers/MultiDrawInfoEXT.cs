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

public unsafe partial class MultiDrawInfoEXT
{
    public MultiDrawInfoEXT()
    {
    }

    public MultiDrawInfoEXT(AdamantiumVulkan.Core.Interop.VkMultiDrawInfoEXT _internal)
    {
        FirstVertex = _internal.firstVertex;
        VertexCount = _internal.vertexCount;
    }

    public uint FirstVertex { get; set; }
    public uint VertexCount { get; set; }

    public AdamantiumVulkan.Core.Interop.VkMultiDrawInfoEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkMultiDrawInfoEXT();
        _internal.firstVertex = FirstVertex;
        _internal.vertexCount = VertexCount;
        return _internal;
    }

    public static implicit operator MultiDrawInfoEXT(AdamantiumVulkan.Core.Interop.VkMultiDrawInfoEXT m)
    {
        return new MultiDrawInfoEXT(m);
    }

}



