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

public unsafe partial class IndirectCommandsLayoutCreateInfoNV : QBDisposableObject
{
    private NativeStruct<VkIndirectCommandsLayoutTokenNV> pTokens;

    private NativeStruct<uint> pStreamStrides;

    public IndirectCommandsLayoutCreateInfoNV()
    {
    }

    public IndirectCommandsLayoutCreateInfoNV(AdamantiumVulkan.Core.Interop.VkIndirectCommandsLayoutCreateInfoNV _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        Flags = _internal.flags;
        PipelineBindPoint = _internal.pipelineBindPoint;
        TokenCount = _internal.tokenCount;
        PTokens = new IndirectCommandsLayoutTokenNV(*_internal.pTokens);
        NativeUtils.Free(_internal.pTokens);
        StreamCount = _internal.streamCount;
        if (_internal.pStreamStrides != null)
        {
            PStreamStrides = *_internal.pStreamStrides;
            NativeUtils.Free(_internal.pStreamStrides);
        }
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkIndirectCommandsLayoutUsageFlagsNV Flags { get; set; }
    public PipelineBindPoint PipelineBindPoint { get; set; }
    public uint TokenCount { get; set; }
    public IndirectCommandsLayoutTokenNV PTokens { get; set; }
    public uint StreamCount { get; set; }
    public uint? PStreamStrides { get; set; }

    public AdamantiumVulkan.Core.Interop.VkIndirectCommandsLayoutCreateInfoNV ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkIndirectCommandsLayoutCreateInfoNV();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.flags = Flags;
        _internal.pipelineBindPoint = PipelineBindPoint;
        _internal.tokenCount = TokenCount;
        pTokens.Dispose();
        if (PTokens != null)
        {
            var struct0 = PTokens.ToNative();
            pTokens = new NativeStruct<VkIndirectCommandsLayoutTokenNV>(struct0);
            _internal.pTokens = pTokens.Handle;
        }
        _internal.streamCount = StreamCount;
        pStreamStrides.Dispose();
        if (PStreamStrides.HasValue)
        {
            pStreamStrides = new NativeStruct<uint>(PStreamStrides.Value);
            _internal.pStreamStrides = pStreamStrides.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        pTokens.Dispose();
        pStreamStrides.Dispose();
    }


    public static implicit operator IndirectCommandsLayoutCreateInfoNV(AdamantiumVulkan.Core.Interop.VkIndirectCommandsLayoutCreateInfoNV i)
    {
        return new IndirectCommandsLayoutCreateInfoNV(i);
    }

}


