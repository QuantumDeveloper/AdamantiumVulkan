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

public unsafe partial class QueueFamilyQueryResultStatusPropertiesKHR : QBDisposableObject
{
    public QueueFamilyQueryResultStatusPropertiesKHR()
    {
    }

    public QueueFamilyQueryResultStatusPropertiesKHR(AdamantiumVulkan.Core.Interop.VkQueueFamilyQueryResultStatusPropertiesKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        QueryResultStatusSupport = _internal.queryResultStatusSupport;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkBool32 QueryResultStatusSupport { get; set; }

    public AdamantiumVulkan.Core.Interop.VkQueueFamilyQueryResultStatusPropertiesKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkQueueFamilyQueryResultStatusPropertiesKHR();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (QueryResultStatusSupport != (uint)default)
        {
            _internal.queryResultStatusSupport = QueryResultStatusSupport;
        }
        return _internal;
    }

    public static implicit operator QueueFamilyQueryResultStatusPropertiesKHR(AdamantiumVulkan.Core.Interop.VkQueueFamilyQueryResultStatusPropertiesKHR q)
    {
        return new QueueFamilyQueryResultStatusPropertiesKHR(q);
    }

}



