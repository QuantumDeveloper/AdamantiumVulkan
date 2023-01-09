// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using QuantumBinding.Utils;
using AdamantiumVulkan.Core.Interop;

namespace AdamantiumVulkan.Core;

public unsafe partial class Image
{
    internal VkImage_T __Instance;
    public Image()
    {
    }

    public Image(AdamantiumVulkan.Core.Interop.VkImage_T __Instance)
    {
        this.__Instance = __Instance;
    }

    public void* NativePointer => __Instance.pointer;

    public ref readonly VkImage_T GetPinnableReference() => ref __Instance;

    public static implicit operator AdamantiumVulkan.Core.Interop.VkImage_T(Image i)
    {
        return i?.__Instance ?? new AdamantiumVulkan.Core.Interop.VkImage_T();
    }

    public static implicit operator Image(AdamantiumVulkan.Core.Interop.VkImage_T i)
    {
        return new Image(i);
    }

}



