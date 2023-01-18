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

public unsafe partial class DebugUtilsMessengerCallbackDataEXT : QBDisposableObject
{
    private MarshaledString pMessageIdName;

    private MarshaledString pMessage;

    private NativeStruct<AdamantiumVulkan.Core.Interop.VkDebugUtilsLabelEXT> pQueueLabels;

    private NativeStruct<AdamantiumVulkan.Core.Interop.VkDebugUtilsLabelEXT> pCmdBufLabels;

    private NativeStruct<AdamantiumVulkan.Core.Interop.VkDebugUtilsObjectNameInfoEXT> pObjects;

    public DebugUtilsMessengerCallbackDataEXT()
    {
    }

    public DebugUtilsMessengerCallbackDataEXT(AdamantiumVulkan.Core.Interop.VkDebugUtilsMessengerCallbackDataEXT _internal)
    {
        PNext = _internal.pNext;
        Flags = _internal.flags;
        PMessageIdName = new string(_internal.pMessageIdName);
        MessageIdNumber = _internal.messageIdNumber;
        PMessage = new string(_internal.pMessage);
        QueueLabelCount = _internal.queueLabelCount;
        PQueueLabels = new DebugUtilsLabelEXT(*_internal.pQueueLabels);
        NativeUtils.Free(_internal.pQueueLabels);
        CmdBufLabelCount = _internal.cmdBufLabelCount;
        PCmdBufLabels = new DebugUtilsLabelEXT(*_internal.pCmdBufLabels);
        NativeUtils.Free(_internal.pCmdBufLabels);
        ObjectCount = _internal.objectCount;
        PObjects = new DebugUtilsObjectNameInfoEXT(*_internal.pObjects);
        NativeUtils.Free(_internal.pObjects);
    }

    public StructureType SType => StructureType.DebugUtilsMessengerCallbackDataExt;
    public void* PNext { get; set; }
    public VkDebugUtilsMessengerCallbackDataFlagsEXT Flags { get; set; }
    public string PMessageIdName { get; set; }
    public int MessageIdNumber { get; set; }
    public string PMessage { get; set; }
    public uint QueueLabelCount { get; set; }
    public DebugUtilsLabelEXT PQueueLabels { get; set; }
    public uint CmdBufLabelCount { get; set; }
    public DebugUtilsLabelEXT PCmdBufLabels { get; set; }
    public uint ObjectCount { get; set; }
    public DebugUtilsObjectNameInfoEXT PObjects { get; set; }

    public AdamantiumVulkan.Core.Interop.VkDebugUtilsMessengerCallbackDataEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkDebugUtilsMessengerCallbackDataEXT();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.flags = Flags;
        pMessageIdName.Dispose();
        if (PMessageIdName != null)
        {
            pMessageIdName = new MarshaledString(PMessageIdName, false);
            _internal.pMessageIdName = (sbyte*)pMessageIdName;
        }
        _internal.messageIdNumber = MessageIdNumber;
        pMessage.Dispose();
        if (PMessage != null)
        {
            pMessage = new MarshaledString(PMessage, false);
            _internal.pMessage = (sbyte*)pMessage;
        }
        _internal.queueLabelCount = QueueLabelCount;
        pQueueLabels.Dispose();
        if (PQueueLabels != null)
        {
            var struct0 = PQueueLabels.ToNative();
            pQueueLabels = new NativeStruct<AdamantiumVulkan.Core.Interop.VkDebugUtilsLabelEXT>(struct0);
            _internal.pQueueLabels = pQueueLabels.Handle;
        }
        _internal.cmdBufLabelCount = CmdBufLabelCount;
        pCmdBufLabels.Dispose();
        if (PCmdBufLabels != null)
        {
            var struct1 = PCmdBufLabels.ToNative();
            pCmdBufLabels = new NativeStruct<AdamantiumVulkan.Core.Interop.VkDebugUtilsLabelEXT>(struct1);
            _internal.pCmdBufLabels = pCmdBufLabels.Handle;
        }
        _internal.objectCount = ObjectCount;
        pObjects.Dispose();
        if (PObjects != null)
        {
            var struct2 = PObjects.ToNative();
            pObjects = new NativeStruct<AdamantiumVulkan.Core.Interop.VkDebugUtilsObjectNameInfoEXT>(struct2);
            _internal.pObjects = pObjects.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        pMessageIdName.Dispose();
        pMessage.Dispose();
        pQueueLabels.Dispose();
        pCmdBufLabels.Dispose();
        pObjects.Dispose();
    }


    public static implicit operator DebugUtilsMessengerCallbackDataEXT(AdamantiumVulkan.Core.Interop.VkDebugUtilsMessengerCallbackDataEXT d)
    {
        return new DebugUtilsMessengerCallbackDataEXT(d);
    }

}



