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

public unsafe partial class PipelineDynamicStateCreateInfo : QBDisposableObject
{
    private NativeStructArray<AdamantiumVulkan.Core.DynamicState> _pDynamicStates;

    public PipelineDynamicStateCreateInfo()
    {
    }

    public PipelineDynamicStateCreateInfo(AdamantiumVulkan.Core.Interop.VkPipelineDynamicStateCreateInfo _internal)
    {
        PNext = _internal.pNext;
        Flags = _internal.flags;
        DynamicStateCount = _internal.dynamicStateCount;
        PDynamicStates = NativeUtils.PointerToManagedArray(_internal.pDynamicStates, _internal.dynamicStateCount);
    }

    public StructureType SType => StructureType.PipelineDynamicStateCreateInfo;
    public void* PNext { get; set; }
    public VkPipelineDynamicStateCreateFlags Flags { get; set; }
    public uint DynamicStateCount { get; set; }
    public DynamicState[] PDynamicStates { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPipelineDynamicStateCreateInfo ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPipelineDynamicStateCreateInfo();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.flags = Flags;
        _internal.dynamicStateCount = DynamicStateCount;
        _pDynamicStates.Dispose();
        if (PDynamicStates != null)
        {
            _pDynamicStates = new NativeStructArray<AdamantiumVulkan.Core.DynamicState>(PDynamicStates);
            _internal.pDynamicStates = _pDynamicStates.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        _pDynamicStates.Dispose();
    }


    public static implicit operator PipelineDynamicStateCreateInfo(AdamantiumVulkan.Core.Interop.VkPipelineDynamicStateCreateInfo p)
    {
        return new PipelineDynamicStateCreateInfo(p);
    }

}



