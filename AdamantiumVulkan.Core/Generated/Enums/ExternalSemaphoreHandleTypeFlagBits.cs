// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AdamantiumVulkan.Core;

[Flags]
public enum ExternalSemaphoreHandleTypeFlagBits : uint
{
    OpaqueFdBit = 1,

    OpaqueWin32Bit = 2,

    OpaqueWin32KmtBit = 4,

    D3d12FenceBit = 8,

    SyncFdBit = 16,

    ZirconEventBitFuchsia = 128,

    FlagBitsMaxEnum = 2147483647,

}


