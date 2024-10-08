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

public unsafe partial class BindShaderGroupIndirectCommandNV : QBDisposableObject
{
    public BindShaderGroupIndirectCommandNV()
    {
    }

    public BindShaderGroupIndirectCommandNV(AdamantiumVulkan.Core.Interop.VkBindShaderGroupIndirectCommandNV _internal)
    {
        GroupIndex = _internal.groupIndex;
    }

    public uint GroupIndex { get; set; }

    public AdamantiumVulkan.Core.Interop.VkBindShaderGroupIndirectCommandNV ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkBindShaderGroupIndirectCommandNV();
        if (GroupIndex != default)
        {
            _internal.groupIndex = GroupIndex;
        }
        return _internal;
    }

    public static implicit operator BindShaderGroupIndirectCommandNV(AdamantiumVulkan.Core.Interop.VkBindShaderGroupIndirectCommandNV b)
    {
        return new BindShaderGroupIndirectCommandNV(b);
    }

}



