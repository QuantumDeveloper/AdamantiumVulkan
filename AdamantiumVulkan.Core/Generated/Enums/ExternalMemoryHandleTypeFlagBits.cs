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
public enum ExternalMemoryHandleTypeFlagBits : uint
{
    OpaqueFdBit = 1,

    OpaqueWin32Bit = 2,

    OpaqueWin32KmtBit = 4,

    D3d11TextureBit = 8,

    D3d11TextureKmtBit = 16,

    D3d12HeapBit = 32,

    D3d12ResourceBit = 64,

    DmaBufBitExt = 512,

    AndroidHardwareBufferBitAndroid = 1024,

    HostAllocationBitExt = 128,

    HostMappedForeignMemoryBitExt = 256,

    ZirconVmoBitFuchsia = 2048,

    RdmaAddressBitNv = 4096,

    FlagBitsMaxEnum = 2147483647,

}



