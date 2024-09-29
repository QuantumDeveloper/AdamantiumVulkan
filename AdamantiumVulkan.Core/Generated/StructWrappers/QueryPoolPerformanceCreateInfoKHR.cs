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

public unsafe partial class QueryPoolPerformanceCreateInfoKHR : QBDisposableObject
{
    private NativeStruct<uint> _pCounterIndices;

    public QueryPoolPerformanceCreateInfoKHR()
    {
    }

    public QueryPoolPerformanceCreateInfoKHR(AdamantiumVulkan.Core.Interop.VkQueryPoolPerformanceCreateInfoKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        QueueFamilyIndex = _internal.queueFamilyIndex;
        CounterIndexCount = _internal.counterIndexCount;
        if (_internal.pCounterIndices != null)
        {
            PCounterIndices = *_internal.pCounterIndices;
            NativeUtils.Free(_internal.pCounterIndices);
        }
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public uint QueueFamilyIndex { get; set; }
    public uint CounterIndexCount { get; set; }
    public uint? PCounterIndices { get; set; }

    public AdamantiumVulkan.Core.Interop.VkQueryPoolPerformanceCreateInfoKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkQueryPoolPerformanceCreateInfoKHR();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (QueueFamilyIndex != default)
        {
            _internal.queueFamilyIndex = QueueFamilyIndex;
        }
        if (CounterIndexCount != default)
        {
            _internal.counterIndexCount = CounterIndexCount;
        }
        _pCounterIndices.Dispose();
        if (PCounterIndices.HasValue)
        {
            _pCounterIndices = new NativeStruct<uint>(PCounterIndices.Value);
            _internal.pCounterIndices = _pCounterIndices.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        _pCounterIndices.Dispose();
    }


    public static implicit operator QueryPoolPerformanceCreateInfoKHR(AdamantiumVulkan.Core.Interop.VkQueryPoolPerformanceCreateInfoKHR q)
    {
        return new QueryPoolPerformanceCreateInfoKHR(q);
    }

}



