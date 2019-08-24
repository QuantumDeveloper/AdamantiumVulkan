// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------


namespace AdamantiumVulkan.Core
{
    using System.Runtime.InteropServices;
    using AdamantiumVulkan;

    public partial class ClearColorValue
    {
        public ClearColorValue()
        {
        }

        public ClearColorValue(AdamantiumVulkan.Core.Interop.VkClearColorValue _internal)
        {
            var tmpArr0 = new float[4];
            unsafe
            {
                for (int i = 0; i < 4; ++i)
                {
                    tmpArr0[i] = _internal.float32[i];
                }
            }
            Float32 = tmpArr0;
            var tmpArr1 = new int[4];
            unsafe
            {
                for (int i = 0; i < 4; ++i)
                {
                    tmpArr1[i] = _internal.int32[i];
                }
            }
            Int32 = tmpArr1;
            var tmpArr2 = new uint[4];
            unsafe
            {
                for (int i = 0; i < 4; ++i)
                {
                    tmpArr2[i] = _internal.uint32[i];
                }
            }
            Uint32 = tmpArr2;
        }

        public float[] Float32 { get; set; }
        public int[] Int32 { get; set; }
        public uint[] Uint32 { get; set; }

        public AdamantiumVulkan.Core.Interop.VkClearColorValue ToInternal()
        {
            var _internal = new AdamantiumVulkan.Core.Interop.VkClearColorValue();
            if(Float32 != null)
            {
                if (Float32.Length > 4)
                    throw new System.ArgumentOutOfRangeException(nameof(Float32), "Array is out of bounds. Size should not be more than 4");

                var inputArray0 = Float32;
                unsafe
                {
                    if (inputArray0 != null)
                    {
                        for (int i = 0; i < inputArray0.Length; ++i)
                        {
                            _internal.float32[i] = inputArray0[i];
                        }
                    }
                }
            }
            if(Int32 != null)
            {
                if (Int32.Length > 4)
                    throw new System.ArgumentOutOfRangeException(nameof(Int32), "Array is out of bounds. Size should not be more than 4");

                var inputArray1 = Int32;
                unsafe
                {
                    if (inputArray1 != null)
                    {
                        for (int i = 0; i < inputArray1.Length; ++i)
                        {
                            _internal.int32[i] = inputArray1[i];
                        }
                    }
                }
            }
            if(Uint32 != null)
            {
                if (Uint32.Length > 4)
                    throw new System.ArgumentOutOfRangeException(nameof(Uint32), "Array is out of bounds. Size should not be more than 4");

                var inputArray2 = Uint32;
                unsafe
                {
                    if (inputArray2 != null)
                    {
                        for (int i = 0; i < inputArray2.Length; ++i)
                        {
                            _internal.uint32[i] = inputArray2[i];
                        }
                    }
                }
            }
            return _internal;
        }
    }

    public partial class ClearValue
    {
        public ClearValue()
        {
        }

        public ClearValue(AdamantiumVulkan.Core.Interop.VkClearValue _internal)
        {
            Color = new ClearColorValue(_internal.color);
            DepthStencil = new ClearDepthStencilValue(_internal.depthStencil);
        }

        public ClearColorValue Color { get; set; }
        public ClearDepthStencilValue DepthStencil { get; set; }

        public AdamantiumVulkan.Core.Interop.VkClearValue ToInternal()
        {
            var _internal = new AdamantiumVulkan.Core.Interop.VkClearValue();
            if (Color != null)
            {
                _internal.color = Color.ToInternal();
            }
            if (DepthStencil != null)
            {
                _internal.depthStencil = DepthStencil.ToInternal();
            }
            return _internal;
        }
    }


}
