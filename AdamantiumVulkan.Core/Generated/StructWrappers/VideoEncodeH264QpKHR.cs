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

public unsafe partial class VideoEncodeH264QpKHR : QBDisposableObject
{
    public VideoEncodeH264QpKHR()
    {
    }

    public VideoEncodeH264QpKHR(AdamantiumVulkan.Core.Interop.VkVideoEncodeH264QpKHR _internal)
    {
        QpI = _internal.qpI;
        QpP = _internal.qpP;
        QpB = _internal.qpB;
    }

    public int QpI { get; set; }
    public int QpP { get; set; }
    public int QpB { get; set; }

    public AdamantiumVulkan.Core.Interop.VkVideoEncodeH264QpKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkVideoEncodeH264QpKHR();
        if (QpI != default)
        {
            _internal.qpI = QpI;
        }
        if (QpP != default)
        {
            _internal.qpP = QpP;
        }
        if (QpB != default)
        {
            _internal.qpB = QpB;
        }
        return _internal;
    }

    public static implicit operator VideoEncodeH264QpKHR(AdamantiumVulkan.Core.Interop.VkVideoEncodeH264QpKHR v)
    {
        return new VideoEncodeH264QpKHR(v);
    }

}


