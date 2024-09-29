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
using AdamantiumVulkan.Spirv.Cross.Interop;

namespace AdamantiumVulkan.Spirv.Cross;

// File: C:\VulkanSDK\1.3.283.0\Include\spirv_cross\spirv_cross_c.h Line: 79 Column: 33
public unsafe partial class SpirvConstant
{
    internal SpvcConstantS __Instance;
    public SpirvConstant()
    {
    }

    public SpirvConstant(AdamantiumVulkan.Spirv.Cross.Interop.SpvcConstantS __Instance)
    {
        this.__Instance = __Instance;
    }

    public SpvcTypeId GetConstantType()
    {
        return AdamantiumVulkan.Spirv.Cross.Interop.SpirvCrossInterop.spvc_constant_get_constant_type(this);
    }

    ///<summary>
    /// No stdint.h until C99, sigh :( For smaller types, the result is sign or zero-extended as appropriate. Maps to C++ API. TODO: The SPIRConstant query interface and modification interface is not quite complete.
    ///</summary>
    public float GetScalarFp16(uint column, uint row)
    {
        return AdamantiumVulkan.Spirv.Cross.Interop.SpirvCrossInterop.spvc_constant_get_scalar_fp16(this, column, row);
    }

    public float GetScalarFp32(uint column, uint row)
    {
        return AdamantiumVulkan.Spirv.Cross.Interop.SpirvCrossInterop.spvc_constant_get_scalar_fp32(this, column, row);
    }

    public double GetScalarFp64(uint column, uint row)
    {
        return AdamantiumVulkan.Spirv.Cross.Interop.SpirvCrossInterop.spvc_constant_get_scalar_fp64(this, column, row);
    }

    public int GetScalarI16(uint column, uint row)
    {
        return AdamantiumVulkan.Spirv.Cross.Interop.SpirvCrossInterop.spvc_constant_get_scalar_i16(this, column, row);
    }

    public int GetScalarI32(uint column, uint row)
    {
        return AdamantiumVulkan.Spirv.Cross.Interop.SpirvCrossInterop.spvc_constant_get_scalar_i32(this, column, row);
    }

    public long GetScalarI64(uint column, uint row)
    {
        return AdamantiumVulkan.Spirv.Cross.Interop.SpirvCrossInterop.spvc_constant_get_scalar_i64(this, column, row);
    }

    public int GetScalarI8(uint column, uint row)
    {
        return AdamantiumVulkan.Spirv.Cross.Interop.SpirvCrossInterop.spvc_constant_get_scalar_i8(this, column, row);
    }

    public uint GetScalarU16(uint column, uint row)
    {
        return AdamantiumVulkan.Spirv.Cross.Interop.SpirvCrossInterop.spvc_constant_get_scalar_u16(this, column, row);
    }

    public uint GetScalarU32(uint column, uint row)
    {
        return AdamantiumVulkan.Spirv.Cross.Interop.SpirvCrossInterop.spvc_constant_get_scalar_u32(this, column, row);
    }

    public ulong GetScalarU64(uint column, uint row)
    {
        return AdamantiumVulkan.Spirv.Cross.Interop.SpirvCrossInterop.spvc_constant_get_scalar_u64(this, column, row);
    }

    public uint GetScalarU8(uint column, uint row)
    {
        return AdamantiumVulkan.Spirv.Cross.Interop.SpirvCrossInterop.spvc_constant_get_scalar_u8(this, column, row);
    }

    public void GetSubconstants(in SpvcConstantId constituents, ref ulong count)
    {
        var arg1 = ReferenceEquals(constituents, null) ? null : (SpvcConstantId**)NativeUtils.StructOrEnumToPointer(constituents);
        var arg2 = NativeUtils.StructOrEnumToPointer(count);
        AdamantiumVulkan.Spirv.Cross.Interop.SpirvCrossInterop.spvc_constant_get_subconstants(this, arg1, arg2);
        NativeUtils.Free(arg1);
        count = *arg2;
        NativeUtils.Free(arg2);
    }

    ///<summary>
    /// C implementation of the C++ api.
    ///</summary>
    public void SetScalarFp16(uint column, uint row, ushort value)
    {
        AdamantiumVulkan.Spirv.Cross.Interop.SpirvCrossInterop.spvc_constant_set_scalar_fp16(this, column, row, value);
    }

    public void SetScalarFp32(uint column, uint row, float value)
    {
        AdamantiumVulkan.Spirv.Cross.Interop.SpirvCrossInterop.spvc_constant_set_scalar_fp32(this, column, row, value);
    }

    public void SetScalarFp64(uint column, uint row, double value)
    {
        AdamantiumVulkan.Spirv.Cross.Interop.SpirvCrossInterop.spvc_constant_set_scalar_fp64(this, column, row, value);
    }

    public void SetScalarI16(uint column, uint row, short value)
    {
        AdamantiumVulkan.Spirv.Cross.Interop.SpirvCrossInterop.spvc_constant_set_scalar_i16(this, column, row, value);
    }

    public void SetScalarI32(uint column, uint row, int value)
    {
        AdamantiumVulkan.Spirv.Cross.Interop.SpirvCrossInterop.spvc_constant_set_scalar_i32(this, column, row, value);
    }

    public void SetScalarI64(uint column, uint row, long value)
    {
        AdamantiumVulkan.Spirv.Cross.Interop.SpirvCrossInterop.spvc_constant_set_scalar_i64(this, column, row, value);
    }

    public void SetScalarI8(uint column, uint row, bool value)
    {
        AdamantiumVulkan.Spirv.Cross.Interop.SpirvCrossInterop.spvc_constant_set_scalar_i8(this, column, row, value);
    }

    public void SetScalarU16(uint column, uint row, ushort value)
    {
        AdamantiumVulkan.Spirv.Cross.Interop.SpirvCrossInterop.spvc_constant_set_scalar_u16(this, column, row, value);
    }

    public void SetScalarU32(uint column, uint row, uint value)
    {
        AdamantiumVulkan.Spirv.Cross.Interop.SpirvCrossInterop.spvc_constant_set_scalar_u32(this, column, row, value);
    }

    public void SetScalarU64(uint column, uint row, ulong value)
    {
        AdamantiumVulkan.Spirv.Cross.Interop.SpirvCrossInterop.spvc_constant_set_scalar_u64(this, column, row, value);
    }

    public void SetScalarU8(uint column, uint row, bool value)
    {
        AdamantiumVulkan.Spirv.Cross.Interop.SpirvCrossInterop.spvc_constant_set_scalar_u8(this, column, row, value);
    }

    public ref readonly SpvcConstantS GetPinnableReference() => ref __Instance;

    public static implicit operator AdamantiumVulkan.Spirv.Cross.Interop.SpvcConstantS(SpirvConstant s)
    {
        return s?.__Instance ?? new AdamantiumVulkan.Spirv.Cross.Interop.SpvcConstantS();
    }

    public static implicit operator SpirvConstant(AdamantiumVulkan.Spirv.Cross.Interop.SpvcConstantS s)
    {
        return new SpirvConstant(s);
    }

}



