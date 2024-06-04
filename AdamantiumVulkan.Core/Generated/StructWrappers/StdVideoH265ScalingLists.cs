// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System.Runtime.InteropServices;
using QuantumBinding.Utils;
using AdamantiumVulkan.Interop;

namespace AdamantiumVulkan;

public unsafe partial class StdVideoH265ScalingLists
{
    public StdVideoH265ScalingLists()
    {
    }

    public StdVideoH265ScalingLists(AdamantiumVulkan.Interop.StdVideoH265ScalingLists _internal)
    {
        ScalingList4x4 = NativeUtils.PointerToManagedArray(_internal.ScalingList4x4, 96);
        ScalingList8x8 = NativeUtils.PointerToManagedArray(_internal.ScalingList8x8, 384);
        ScalingList16x16 = NativeUtils.PointerToManagedArray(_internal.ScalingList16x16, 384);
        ScalingList32x32 = NativeUtils.PointerToManagedArray(_internal.ScalingList32x32, 128);
        ScalingListDCCoef16x16 = NativeUtils.PointerToManagedArray(_internal.ScalingListDCCoef16x16, 6);
        ScalingListDCCoef32x32 = NativeUtils.PointerToManagedArray(_internal.ScalingListDCCoef32x32, 2);
    }

    public byte[] ScalingList4x4 { get; set; }
    public byte[] ScalingList8x8 { get; set; }
    public byte[] ScalingList16x16 { get; set; }
    public byte[] ScalingList32x32 { get; set; }
    public byte[] ScalingListDCCoef16x16 { get; set; }
    public byte[] ScalingListDCCoef32x32 { get; set; }

    public AdamantiumVulkan.Interop.StdVideoH265ScalingLists ToNative()
    {
        var _internal = new AdamantiumVulkan.Interop.StdVideoH265ScalingLists();
        if(ScalingList4x4 != null)
        {
            if (ScalingList4x4.Length > 96)
                throw new System.ArgumentOutOfRangeException(nameof(ScalingList4x4), "Array is out of bounds. Size should not be more than 96");

            NativeUtils.PrimitiveToFixedArray(_internal.ScalingList4x4, 96, ScalingList4x4);
        }
        if(ScalingList8x8 != null)
        {
            if (ScalingList8x8.Length > 384)
                throw new System.ArgumentOutOfRangeException(nameof(ScalingList8x8), "Array is out of bounds. Size should not be more than 384");

            NativeUtils.PrimitiveToFixedArray(_internal.ScalingList8x8, 384, ScalingList8x8);
        }
        if(ScalingList16x16 != null)
        {
            if (ScalingList16x16.Length > 384)
                throw new System.ArgumentOutOfRangeException(nameof(ScalingList16x16), "Array is out of bounds. Size should not be more than 384");

            NativeUtils.PrimitiveToFixedArray(_internal.ScalingList16x16, 384, ScalingList16x16);
        }
        if(ScalingList32x32 != null)
        {
            if (ScalingList32x32.Length > 128)
                throw new System.ArgumentOutOfRangeException(nameof(ScalingList32x32), "Array is out of bounds. Size should not be more than 128");

            NativeUtils.PrimitiveToFixedArray(_internal.ScalingList32x32, 128, ScalingList32x32);
        }
        if(ScalingListDCCoef16x16 != null)
        {
            if (ScalingListDCCoef16x16.Length > 6)
                throw new System.ArgumentOutOfRangeException(nameof(ScalingListDCCoef16x16), "Array is out of bounds. Size should not be more than 6");

            NativeUtils.PrimitiveToFixedArray(_internal.ScalingListDCCoef16x16, 6, ScalingListDCCoef16x16);
        }
        if(ScalingListDCCoef32x32 != null)
        {
            if (ScalingListDCCoef32x32.Length > 2)
                throw new System.ArgumentOutOfRangeException(nameof(ScalingListDCCoef32x32), "Array is out of bounds. Size should not be more than 2");

            NativeUtils.PrimitiveToFixedArray(_internal.ScalingListDCCoef32x32, 2, ScalingListDCCoef32x32);
        }
        return _internal;
    }

    public static implicit operator StdVideoH265ScalingLists(AdamantiumVulkan.Interop.StdVideoH265ScalingLists s)
    {
        return new StdVideoH265ScalingLists(s);
    }

}



