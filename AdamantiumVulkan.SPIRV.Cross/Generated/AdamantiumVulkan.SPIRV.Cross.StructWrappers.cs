// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------


namespace AdamantiumVulkan.SPIRV.Cross
{
    using System.Runtime.InteropServices;
    using AdamantiumVulkan.SPIRV.Cross;
    using AdamantiumVulkan.SPIRV.Cross.Interop;

    public partial class SpvcReflectedResource : DisposableObject
    {
        private StringReference refname;

        public SpvcReflectedResource()
        {
        }

        public SpvcReflectedResource(AdamantiumVulkan.SPIRV.Cross.Interop.SpvcReflectedResource _internal)
        {
            Id = _internal.id;
            Base_type_id = _internal.base_type_id;
            Type_id = _internal.type_id;
            Name = Marshal.PtrToStringAnsi(_internal.name);
        }

        public uint Id { get; set; }
        public uint Base_type_id { get; set; }
        public uint Type_id { get; set; }
        public string Name { get; set; }

        public AdamantiumVulkan.SPIRV.Cross.Interop.SpvcReflectedResource ToInternal()
        {
            var _internal = new AdamantiumVulkan.SPIRV.Cross.Interop.SpvcReflectedResource();
            _internal.id = Id;
            _internal.base_type_id = Base_type_id;
            _internal.type_id = Type_id;
            refname?.Dispose();
            if (Name != null)
            {
                refname = new StringReference(Name, false);
                _internal.name = refname.Handle;
            }
            return _internal;
        }

        protected override void UnmanagedDisposeOverride()
        {
            refname?.Dispose();
        }

    }

    public partial class SpvcEntryPoint : DisposableObject
    {
        private StringReference refname;

        public SpvcEntryPoint()
        {
        }

        public SpvcEntryPoint(AdamantiumVulkan.SPIRV.Cross.Interop.SpvcEntryPoint _internal)
        {
            Execution_model = _internal.execution_model;
            Name = Marshal.PtrToStringAnsi(_internal.name);
        }

        public SpvExecutionModel Execution_model { get; set; }
        public string Name { get; set; }

        public AdamantiumVulkan.SPIRV.Cross.Interop.SpvcEntryPoint ToInternal()
        {
            var _internal = new AdamantiumVulkan.SPIRV.Cross.Interop.SpvcEntryPoint();
            _internal.execution_model = Execution_model;
            refname?.Dispose();
            if (Name != null)
            {
                refname = new StringReference(Name, false);
                _internal.name = refname.Handle;
            }
            return _internal;
        }

        protected override void UnmanagedDisposeOverride()
        {
            refname?.Dispose();
        }

    }

    public partial class SpvcCombinedImageSampler
    {
        public SpvcCombinedImageSampler()
        {
        }

        public SpvcCombinedImageSampler(AdamantiumVulkan.SPIRV.Cross.Interop.SpvcCombinedImageSampler _internal)
        {
            Combined_id = _internal.combined_id;
            Image_id = _internal.image_id;
            Sampler_id = _internal.sampler_id;
        }

        public uint Combined_id { get; set; }
        public uint Image_id { get; set; }
        public uint Sampler_id { get; set; }

        public AdamantiumVulkan.SPIRV.Cross.Interop.SpvcCombinedImageSampler ToInternal()
        {
            var _internal = new AdamantiumVulkan.SPIRV.Cross.Interop.SpvcCombinedImageSampler();
            _internal.combined_id = Combined_id;
            _internal.image_id = Image_id;
            _internal.sampler_id = Sampler_id;
            return _internal;
        }
    }

    public partial class SpvcSpecializationConstant
    {
        public SpvcSpecializationConstant()
        {
        }

        public SpvcSpecializationConstant(AdamantiumVulkan.SPIRV.Cross.Interop.SpvcSpecializationConstant _internal)
        {
            Id = _internal.id;
            Constant_id = _internal.constant_id;
        }

        public uint Id { get; set; }
        public uint Constant_id { get; set; }

        public AdamantiumVulkan.SPIRV.Cross.Interop.SpvcSpecializationConstant ToInternal()
        {
            var _internal = new AdamantiumVulkan.SPIRV.Cross.Interop.SpvcSpecializationConstant();
            _internal.id = Id;
            _internal.constant_id = Constant_id;
            return _internal;
        }
    }

    public partial class SpvcBufferRange
    {
        public SpvcBufferRange()
        {
        }

        public SpvcBufferRange(AdamantiumVulkan.SPIRV.Cross.Interop.SpvcBufferRange _internal)
        {
            Index = _internal.index;
            Offset = _internal.offset;
            Range = _internal.range;
        }

        public uint Index { get; set; }
        public ulong Offset { get; set; }
        public ulong Range { get; set; }

        public AdamantiumVulkan.SPIRV.Cross.Interop.SpvcBufferRange ToInternal()
        {
            var _internal = new AdamantiumVulkan.SPIRV.Cross.Interop.SpvcBufferRange();
            _internal.index = Index;
            _internal.offset = Offset;
            _internal.range = Range;
            return _internal;
        }
    }

    public partial class SpvcHlslRootConstants
    {
        public SpvcHlslRootConstants()
        {
        }

        public SpvcHlslRootConstants(AdamantiumVulkan.SPIRV.Cross.Interop.SpvcHlslRootConstants _internal)
        {
            Start = _internal.start;
            End = _internal.end;
            Binding = _internal.binding;
            Space = _internal.space;
        }

        public uint Start { get; set; }
        public uint End { get; set; }
        public uint Binding { get; set; }
        public uint Space { get; set; }

        public AdamantiumVulkan.SPIRV.Cross.Interop.SpvcHlslRootConstants ToInternal()
        {
            var _internal = new AdamantiumVulkan.SPIRV.Cross.Interop.SpvcHlslRootConstants();
            _internal.start = Start;
            _internal.end = End;
            _internal.binding = Binding;
            _internal.space = Space;
            return _internal;
        }
    }

    public partial class SpvcHlslVertexAttributeRemap : DisposableObject
    {
        private StringReference refsemantic;

        public SpvcHlslVertexAttributeRemap()
        {
        }

        public SpvcHlslVertexAttributeRemap(AdamantiumVulkan.SPIRV.Cross.Interop.SpvcHlslVertexAttributeRemap _internal)
        {
            Location = _internal.location;
            Semantic = Marshal.PtrToStringAnsi(_internal.semantic);
        }

        public uint Location { get; set; }
        public string Semantic { get; set; }

        public AdamantiumVulkan.SPIRV.Cross.Interop.SpvcHlslVertexAttributeRemap ToInternal()
        {
            var _internal = new AdamantiumVulkan.SPIRV.Cross.Interop.SpvcHlslVertexAttributeRemap();
            _internal.location = Location;
            refsemantic?.Dispose();
            if (Semantic != null)
            {
                refsemantic = new StringReference(Semantic, false);
                _internal.semantic = refsemantic.Handle;
            }
            return _internal;
        }

        protected override void UnmanagedDisposeOverride()
        {
            refsemantic?.Dispose();
        }

    }

    public partial class SpvcMslVertexAttribute
    {
        public SpvcMslVertexAttribute()
        {
        }

        public SpvcMslVertexAttribute(AdamantiumVulkan.SPIRV.Cross.Interop.SpvcMslVertexAttribute _internal)
        {
            Location = _internal.location;
            Msl_buffer = _internal.msl_buffer;
            Msl_offset = _internal.msl_offset;
            Msl_stride = _internal.msl_stride;
            Per_instance = _internal.per_instance;
            Format = _internal.format;
            Builtin = _internal.builtin;
        }

        public uint Location { get; set; }
        public uint Msl_buffer { get; set; }
        public uint Msl_offset { get; set; }
        public uint Msl_stride { get; set; }
        public byte Per_instance { get; set; }
        public SpvcMslVertexFormat Format { get; set; }
        public SpvBuiltIn Builtin { get; set; }

        public AdamantiumVulkan.SPIRV.Cross.Interop.SpvcMslVertexAttribute ToInternal()
        {
            var _internal = new AdamantiumVulkan.SPIRV.Cross.Interop.SpvcMslVertexAttribute();
            _internal.location = Location;
            _internal.msl_buffer = Msl_buffer;
            _internal.msl_offset = Msl_offset;
            _internal.msl_stride = Msl_stride;
            _internal.per_instance = Per_instance;
            _internal.format = Format;
            _internal.builtin = Builtin;
            return _internal;
        }
    }

    public partial class SpvcMslResourceBinding
    {
        public SpvcMslResourceBinding()
        {
        }

        public SpvcMslResourceBinding(AdamantiumVulkan.SPIRV.Cross.Interop.SpvcMslResourceBinding _internal)
        {
            Stage = _internal.stage;
            Desc_set = _internal.desc_set;
            Binding = _internal.binding;
            Msl_buffer = _internal.msl_buffer;
            Msl_texture = _internal.msl_texture;
            Msl_sampler = _internal.msl_sampler;
        }

        public SpvExecutionModel Stage { get; set; }
        public uint Desc_set { get; set; }
        public uint Binding { get; set; }
        public uint Msl_buffer { get; set; }
        public uint Msl_texture { get; set; }
        public uint Msl_sampler { get; set; }

        public AdamantiumVulkan.SPIRV.Cross.Interop.SpvcMslResourceBinding ToInternal()
        {
            var _internal = new AdamantiumVulkan.SPIRV.Cross.Interop.SpvcMslResourceBinding();
            _internal.stage = Stage;
            _internal.desc_set = Desc_set;
            _internal.binding = Binding;
            _internal.msl_buffer = Msl_buffer;
            _internal.msl_texture = Msl_texture;
            _internal.msl_sampler = Msl_sampler;
            return _internal;
        }
    }

    public partial class SpvcMslConstexprSampler
    {
        public SpvcMslConstexprSampler()
        {
        }

        public SpvcMslConstexprSampler(AdamantiumVulkan.SPIRV.Cross.Interop.SpvcMslConstexprSampler _internal)
        {
            Coord = _internal.coord;
            Min_filter = _internal.min_filter;
            Mag_filter = _internal.mag_filter;
            Mip_filter = _internal.mip_filter;
            S_address = _internal.s_address;
            T_address = _internal.t_address;
            R_address = _internal.r_address;
            Compare_func = _internal.compare_func;
            Border_color = _internal.border_color;
            Lod_clamp_min = _internal.lod_clamp_min;
            Lod_clamp_max = _internal.lod_clamp_max;
            Max_anisotropy = _internal.max_anisotropy;
            Compare_enable = _internal.compare_enable;
            Lod_clamp_enable = _internal.lod_clamp_enable;
            Anisotropy_enable = _internal.anisotropy_enable;
        }

        public SpvcMslSamplerCoord Coord { get; set; }
        public SpvcMslSamplerFilter Min_filter { get; set; }
        public SpvcMslSamplerFilter Mag_filter { get; set; }
        public SpvcMslSamplerMipFilter Mip_filter { get; set; }
        public SpvcMslSamplerAddress S_address { get; set; }
        public SpvcMslSamplerAddress T_address { get; set; }
        public SpvcMslSamplerAddress R_address { get; set; }
        public SpvcMslSamplerCompareFunc Compare_func { get; set; }
        public SpvcMslSamplerBorderColor Border_color { get; set; }
        public float Lod_clamp_min { get; set; }
        public float Lod_clamp_max { get; set; }
        public int Max_anisotropy { get; set; }
        public byte Compare_enable { get; set; }
        public byte Lod_clamp_enable { get; set; }
        public byte Anisotropy_enable { get; set; }

        public AdamantiumVulkan.SPIRV.Cross.Interop.SpvcMslConstexprSampler ToInternal()
        {
            var _internal = new AdamantiumVulkan.SPIRV.Cross.Interop.SpvcMslConstexprSampler();
            _internal.coord = Coord;
            _internal.min_filter = Min_filter;
            _internal.mag_filter = Mag_filter;
            _internal.mip_filter = Mip_filter;
            _internal.s_address = S_address;
            _internal.t_address = T_address;
            _internal.r_address = R_address;
            _internal.compare_func = Compare_func;
            _internal.border_color = Border_color;
            _internal.lod_clamp_min = Lod_clamp_min;
            _internal.lod_clamp_max = Lod_clamp_max;
            _internal.max_anisotropy = Max_anisotropy;
            _internal.compare_enable = Compare_enable;
            _internal.lod_clamp_enable = Lod_clamp_enable;
            _internal.anisotropy_enable = Anisotropy_enable;
            return _internal;
        }
    }

    public partial class SpvcMslSamplerYcbcrConversion
    {
        public SpvcMslSamplerYcbcrConversion()
        {
        }

        public SpvcMslSamplerYcbcrConversion(AdamantiumVulkan.SPIRV.Cross.Interop.SpvcMslSamplerYcbcrConversion _internal)
        {
            Planes = _internal.planes;
            Resolution = _internal.resolution;
            Chroma_filter = _internal.chroma_filter;
            X_chroma_offset = _internal.x_chroma_offset;
            Y_chroma_offset = _internal.y_chroma_offset;
            Swizzle = _internal.swizzle;
            Ycbcr_model = _internal.ycbcr_model;
            Ycbcr_range = _internal.ycbcr_range;
            Bpc = _internal.bpc;
        }

        public uint Planes { get; set; }
        public SpvcMslFormatResolution Resolution { get; set; }
        public SpvcMslSamplerFilter Chroma_filter { get; set; }
        public SpvcMslChromaLocation X_chroma_offset { get; set; }
        public SpvcMslChromaLocation Y_chroma_offset { get; set; }
        public SpvcMslComponentSwizzle[] Swizzle { get; set; }
        public SpvcMslSamplerYcbcrModelConversion Ycbcr_model { get; set; }
        public SpvcMslSamplerYcbcrRange Ycbcr_range { get; set; }
        public uint Bpc { get; set; }

        public AdamantiumVulkan.SPIRV.Cross.Interop.SpvcMslSamplerYcbcrConversion ToInternal()
        {
            var _internal = new AdamantiumVulkan.SPIRV.Cross.Interop.SpvcMslSamplerYcbcrConversion();
            _internal.planes = Planes;
            _internal.resolution = Resolution;
            _internal.chroma_filter = Chroma_filter;
            _internal.x_chroma_offset = X_chroma_offset;
            _internal.y_chroma_offset = Y_chroma_offset;
            if(Swizzle != null)
            {
                if (Swizzle.Length > 4)
                    throw new System.ArgumentOutOfRangeException(nameof(Swizzle), "Array is out of bounds. Size should not be more than 4");

                _internal.swizzle = Swizzle;
            }
            _internal.ycbcr_model = Ycbcr_model;
            _internal.ycbcr_range = Ycbcr_range;
            _internal.bpc = Bpc;
            return _internal;
        }
    }


}