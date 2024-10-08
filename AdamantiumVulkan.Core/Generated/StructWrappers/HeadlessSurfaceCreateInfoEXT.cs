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

public unsafe partial class HeadlessSurfaceCreateInfoEXT : QBDisposableObject
{
    public HeadlessSurfaceCreateInfoEXT()
    {
    }

    public HeadlessSurfaceCreateInfoEXT(AdamantiumVulkan.Core.Interop.VkHeadlessSurfaceCreateInfoEXT _internal)
    {
        PNext = _internal.pNext;
        Flags = _internal.flags;
    }

    public StructureType SType => StructureType.HeadlessSurfaceCreateInfoExt;
    public void* PNext { get; set; }
    public VkHeadlessSurfaceCreateFlagsEXT Flags { get; set; }

    public AdamantiumVulkan.Core.Interop.VkHeadlessSurfaceCreateInfoEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkHeadlessSurfaceCreateInfoEXT();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (Flags != (uint)default)
        {
            _internal.flags = Flags;
        }
        return _internal;
    }

    public static implicit operator HeadlessSurfaceCreateInfoEXT(AdamantiumVulkan.Core.Interop.VkHeadlessSurfaceCreateInfoEXT h)
    {
        return new HeadlessSurfaceCreateInfoEXT(h);
    }

}



