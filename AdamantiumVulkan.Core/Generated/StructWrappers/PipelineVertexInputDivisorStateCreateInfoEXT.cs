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

public unsafe partial class PipelineVertexInputDivisorStateCreateInfoEXT : QBDisposableObject
{
    private NativeStruct<VkVertexInputBindingDivisorDescriptionEXT> pVertexBindingDivisors;

    public PipelineVertexInputDivisorStateCreateInfoEXT()
    {
    }

    public PipelineVertexInputDivisorStateCreateInfoEXT(AdamantiumVulkan.Core.Interop.VkPipelineVertexInputDivisorStateCreateInfoEXT _internal)
    {
        PNext = _internal.pNext;
        VertexBindingDivisorCount = _internal.vertexBindingDivisorCount;
        PVertexBindingDivisors = new VertexInputBindingDivisorDescriptionEXT(*_internal.pVertexBindingDivisors);
        NativeUtils.Free(_internal.pVertexBindingDivisors);
    }

    public StructureType SType => StructureType.PipelineVertexInputDivisorStateCreateInfoExt;
    public void* PNext { get; set; }
    public uint VertexBindingDivisorCount { get; set; }
    public VertexInputBindingDivisorDescriptionEXT PVertexBindingDivisors { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPipelineVertexInputDivisorStateCreateInfoEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPipelineVertexInputDivisorStateCreateInfoEXT();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.vertexBindingDivisorCount = VertexBindingDivisorCount;
        pVertexBindingDivisors.Dispose();
        if (PVertexBindingDivisors != null)
        {
            var struct0 = PVertexBindingDivisors.ToNative();
            pVertexBindingDivisors = new NativeStruct<VkVertexInputBindingDivisorDescriptionEXT>(struct0);
            _internal.pVertexBindingDivisors = pVertexBindingDivisors.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        pVertexBindingDivisors.Dispose();
    }


    public static implicit operator PipelineVertexInputDivisorStateCreateInfoEXT(AdamantiumVulkan.Core.Interop.VkPipelineVertexInputDivisorStateCreateInfoEXT p)
    {
        return new PipelineVertexInputDivisorStateCreateInfoEXT(p);
    }

}



