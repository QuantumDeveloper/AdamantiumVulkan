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

public unsafe partial class TransformMatrixKHR : QBDisposableObject
{
    public TransformMatrixKHR()
    {
    }

    public TransformMatrixKHR(AdamantiumVulkan.Core.Interop.VkTransformMatrixKHR _internal)
    {
        Matrix = NativeUtils.PointerToManagedArray(_internal.matrix, 12);
    }

    public float[] Matrix { get; set; }

    public AdamantiumVulkan.Core.Interop.VkTransformMatrixKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkTransformMatrixKHR();
        if (Matrix != default)
        {
            if (Matrix.Length > 12)
                throw new System.ArgumentOutOfRangeException(nameof(Matrix), "Array is out of bounds. Size should not be more than 12");

            NativeUtils.PrimitiveToFixedArray(_internal.matrix, 12, Matrix);
        }
        return _internal;
    }

    public static implicit operator TransformMatrixKHR(AdamantiumVulkan.Core.Interop.VkTransformMatrixKHR t)
    {
        return new TransformMatrixKHR(t);
    }

}



