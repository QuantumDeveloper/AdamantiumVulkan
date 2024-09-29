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

public unsafe partial class VideoInlineQueryInfoKHR : QBDisposableObject
{
    public VideoInlineQueryInfoKHR()
    {
    }

    public VideoInlineQueryInfoKHR(AdamantiumVulkan.Core.Interop.VkVideoInlineQueryInfoKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        QueryPool = new QueryPool(_internal.queryPool);
        FirstQuery = _internal.firstQuery;
        QueryCount = _internal.queryCount;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public QueryPool QueryPool { get; set; }
    public uint FirstQuery { get; set; }
    public uint QueryCount { get; set; }

    public AdamantiumVulkan.Core.Interop.VkVideoInlineQueryInfoKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkVideoInlineQueryInfoKHR();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (QueryPool != default)
        {
            _internal.queryPool = QueryPool;
        }
        if (FirstQuery != default)
        {
            _internal.firstQuery = FirstQuery;
        }
        if (QueryCount != default)
        {
            _internal.queryCount = QueryCount;
        }
        return _internal;
    }

    public static implicit operator VideoInlineQueryInfoKHR(AdamantiumVulkan.Core.Interop.VkVideoInlineQueryInfoKHR v)
    {
        return new VideoInlineQueryInfoKHR(v);
    }

}



