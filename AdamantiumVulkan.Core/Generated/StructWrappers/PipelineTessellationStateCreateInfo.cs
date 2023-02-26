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

public unsafe partial class PipelineTessellationStateCreateInfo : QBDisposableObject
{
    public PipelineTessellationStateCreateInfo()
    {
    }

    public PipelineTessellationStateCreateInfo(AdamantiumVulkan.Core.Interop.VkPipelineTessellationStateCreateInfo _internal)
    {
        PNext = _internal.pNext;
        Flags = _internal.flags;
        PatchControlPoints = _internal.patchControlPoints;
    }

    public StructureType SType => StructureType.PipelineTessellationStateCreateInfo;
    public void* PNext { get; set; }
    public VkPipelineTessellationStateCreateFlags Flags { get; set; }
    public uint PatchControlPoints { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPipelineTessellationStateCreateInfo ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPipelineTessellationStateCreateInfo();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.flags = Flags;
        _internal.patchControlPoints = PatchControlPoints;
        return _internal;
    }

    public static implicit operator PipelineTessellationStateCreateInfo(AdamantiumVulkan.Core.Interop.VkPipelineTessellationStateCreateInfo p)
    {
        return new PipelineTessellationStateCreateInfo(p);
    }

}



