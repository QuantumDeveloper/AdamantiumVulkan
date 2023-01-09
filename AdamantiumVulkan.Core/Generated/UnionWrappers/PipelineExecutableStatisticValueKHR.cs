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

public unsafe partial class PipelineExecutableStatisticValueKHR
{
    public PipelineExecutableStatisticValueKHR()
    {
    }

    public PipelineExecutableStatisticValueKHR(AdamantiumVulkan.Core.Interop.VkPipelineExecutableStatisticValueKHR _internal)
    {
        B32 = _internal.b32;
        I64 = _internal.i64;
        U64 = _internal.u64;
        F64 = _internal.f64;
    }

    public VkBool32 B32 { get; set; }
    public long I64 { get; set; }
    public ulong U64 { get; set; }
    public double F64 { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPipelineExecutableStatisticValueKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPipelineExecutableStatisticValueKHR();
        _internal.b32 = B32;
        _internal.i64 = I64;
        _internal.u64 = U64;
        _internal.f64 = F64;
        return _internal;
    }

    public static implicit operator PipelineExecutableStatisticValueKHR(AdamantiumVulkan.Core.Interop.VkPipelineExecutableStatisticValueKHR p)
    {
        return new PipelineExecutableStatisticValueKHR(p);
    }

}


