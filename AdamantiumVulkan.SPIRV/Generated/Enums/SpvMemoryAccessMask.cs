// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AdamantiumVulkan.Spirv;

// File: C:\VulkanSDK\1.3.283.0\Include\spirv_cross/spirv.h Line: 839 Column: 14
[Flags]
public enum SpvMemoryAccessMask : uint
{
    MaskNone = 0,

    VolatileMask = 1,

    AlignedMask = 2,

    NontemporalMask = 4,

    MakePointerAvailableMask = 8,

    MakePointerVisibleMask = 16,

    NonPrivatePointerMask = 32,

    AliasScopeINTELMaskMask = 65536,

    NoAliasINTELMaskMask = 131072,

}



