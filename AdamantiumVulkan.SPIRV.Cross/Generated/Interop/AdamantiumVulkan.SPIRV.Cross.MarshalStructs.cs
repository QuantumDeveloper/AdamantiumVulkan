// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

namespace AdamantiumVulkan.SPIRV.Cross.Interop
{
    using System;
    using System.Runtime.InteropServices;
    using AdamantiumVulkan.SPIRV.Cross;

    [StructLayout(LayoutKind.Sequential)]
    public partial struct SpvcContextS
    {
        public System.IntPtr pointer;

    }

    [StructLayout(LayoutKind.Sequential)]
    public partial struct SpvcParsedIrS
    {
        public System.IntPtr pointer;

    }

    [StructLayout(LayoutKind.Sequential)]
    public partial struct SpvcCompilerS
    {
        public System.IntPtr pointer;

    }

    [StructLayout(LayoutKind.Sequential)]
    public partial struct SpvcCompilerOptionsS
    {
        public System.IntPtr pointer;

    }

    [StructLayout(LayoutKind.Sequential)]
    public partial struct SpvcResourcesS
    {
        public System.IntPtr pointer;

    }

    [StructLayout(LayoutKind.Sequential)]
    public partial struct SpvcTypeS
    {
    }

    [StructLayout(LayoutKind.Sequential)]
    public partial struct SpvcConstantS
    {
        public System.IntPtr pointer;

    }

    [StructLayout(LayoutKind.Sequential)]
    public partial struct SpvcSetS
    {
    }

    ///<summary>
    /// Shallow typedefs. All SPIR-V IDs are plain 32-bit numbers, but this helps communicate which data is used. Maps to a SPIRType.
    ///</summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct SpvcTypeId
    {
        public uint value;

        public static implicit operator uint(SpvcTypeId s)
        {
            return s.value;
        }

        public static implicit operator SpvcTypeId(uint s)
        {
            return new SpvcTypeId(){value = s};
        }

    }

    ///<summary>
    /// Maps to a SPIRVariable.
    ///</summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct SpvcVariableId
    {
        public uint value;

        public static implicit operator uint(SpvcVariableId s)
        {
            return s.value;
        }

        public static implicit operator SpvcVariableId(uint s)
        {
            return new SpvcVariableId(){value = s};
        }

    }

    ///<summary>
    /// Maps to a SPIRConstant.
    ///</summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct SpvcConstantId
    {
        public uint value;

        public static implicit operator uint(SpvcConstantId s)
        {
            return s.value;
        }

        public static implicit operator SpvcConstantId(uint s)
        {
            return new SpvcConstantId(){value = s};
        }

    }

    ///<summary>
    /// See C++ API.
    ///</summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct SpvcReflectedResource
    {
        public uint id;

        public uint base_type_id;

        public uint type_id;

        public System.IntPtr name;

    }

    ///<summary>
    /// See C++ API.
    ///</summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct SpvcEntryPoint
    {
        public SpvExecutionModel execution_model;

        public System.IntPtr name;

    }

    ///<summary>
    /// See C++ API.
    ///</summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct SpvcCombinedImageSampler
    {
        public uint combined_id;

        public uint image_id;

        public uint sampler_id;

    }

    ///<summary>
    /// See C++ API.
    ///</summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct SpvcSpecializationConstant
    {
        public uint id;

        public uint constant_id;

    }

    ///<summary>
    /// See C++ API.
    ///</summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct SpvcBufferRange
    {
        public uint index;

        public ulong offset;

        public ulong range;

    }

    ///<summary>
    /// See C++ API.
    ///</summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct SpvcHlslRootConstants
    {
        public uint start;

        public uint end;

        public uint binding;

        public uint space;

    }

    ///<summary>
    /// See C++ API.
    ///</summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct SpvcHlslVertexAttributeRemap
    {
        public uint location;

        public System.IntPtr semantic;

    }

    ///<summary>
    /// Be compatible with non-C99 compilers, which do not have stdbool. Only recent MSVC compilers supports this for example, and ideally SPIRV-Cross should be linkable from a wide range of compilers in its C wrapper.
    ///</summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct SpvcBool
    {
        public byte value;

        public static implicit operator byte(SpvcBool s)
        {
            return s.value;
        }

        public static implicit operator SpvcBool(byte s)
        {
            return new SpvcBool(){value = s};
        }

    }

    ///<summary>
    /// Maps to C++ API.
    ///</summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct SpvcMslVertexAttribute
    {
        public uint location;

        public uint msl_buffer;

        public uint msl_offset;

        public uint msl_stride;

        public byte per_instance;

        public SpvcMslVertexFormat format;

        public SpvBuiltIn builtin;

    }

    ///<summary>
    /// Maps to C++ API.
    ///</summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct SpvcMslResourceBinding
    {
        public SpvExecutionModel stage;

        public uint desc_set;

        public uint binding;

        public uint msl_buffer;

        public uint msl_texture;

        public uint msl_sampler;

    }

    ///<summary>
    /// Maps to C++ API.
    ///</summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct SpvcMslConstexprSampler
    {
        public SpvcMslSamplerCoord coord;

        public SpvcMslSamplerFilter min_filter;

        public SpvcMslSamplerFilter mag_filter;

        public SpvcMslSamplerMipFilter mip_filter;

        public SpvcMslSamplerAddress s_address;

        public SpvcMslSamplerAddress t_address;

        public SpvcMslSamplerAddress r_address;

        public SpvcMslSamplerCompareFunc compare_func;

        public SpvcMslSamplerBorderColor border_color;

        public float lod_clamp_min;

        public float lod_clamp_max;

        public int max_anisotropy;

        public byte compare_enable;

        public byte lod_clamp_enable;

        public byte anisotropy_enable;

    }

    ///<summary>
    /// Maps to the sampler Y'CbCr conversion-related portions of MSLConstexprSampler. See C++ API for defaults and details.
    ///</summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct SpvcMslSamplerYcbcrConversion
    {
        public uint planes;

        public SpvcMslFormatResolution resolution;

        public SpvcMslSamplerFilter chroma_filter;

        public SpvcMslChromaLocation x_chroma_offset;

        public SpvcMslChromaLocation y_chroma_offset;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public SpvcMslComponentSwizzle[] swizzle;

        public SpvcMslSamplerYcbcrModelConversion ycbcr_model;

        public SpvcMslSamplerYcbcrRange ycbcr_range;

        public uint bpc;

    }


}

