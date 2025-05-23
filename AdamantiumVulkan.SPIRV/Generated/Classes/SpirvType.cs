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
using AdamantiumVulkan.Spirv.Interop;

namespace AdamantiumVulkan.Spirv.Cross;

// File: C:\VulkanSDK\1.4.309.0\Include\spirv_cross\spirv_cross_c.h Line: 78 Column: 35
public unsafe partial class SpirvType
{
    internal SpvcTypeS __Instance;
    public SpirvType()
    {
    }

    public SpirvType(AdamantiumVulkan.Spirv.Cross.Interop.SpvcTypeS __Instance)
    {
        this.__Instance = __Instance;
    }

    public SpvcBool ArrayDimensionIsLiteral(uint dimension)
    {
        return AdamantiumVulkan.Spirv.Cross.Interop.SpirvCrossInterop.spvc_type_array_dimension_is_literal(this, dimension);
    }

    public SpvId GetArrayDimension(uint dimension)
    {
        return AdamantiumVulkan.Spirv.Cross.Interop.SpirvCrossInterop.spvc_type_get_array_dimension(this, dimension);
    }

    public Basetype GetBasetype()
    {
        return AdamantiumVulkan.Spirv.Cross.Interop.SpirvCrossInterop.spvc_type_get_basetype(this);
    }

    ///<summary>
    /// Pulls out SPIRType::self. This effectively gives the type ID without array or pointer qualifiers. This is necessary when reflecting decoration/name information on members of a struct, which are placed in the base type, not the qualified type. This is similar to spvc_reflected_resource::base_type_id.
    ///</summary>
    public SpvcTypeId GetBaseTypeId()
    {
        return AdamantiumVulkan.Spirv.Cross.Interop.SpirvCrossInterop.spvc_type_get_base_type_id(this);
    }

    public uint GetBitWidth()
    {
        return AdamantiumVulkan.Spirv.Cross.Interop.SpirvCrossInterop.spvc_type_get_bit_width(this);
    }

    public uint GetColumns()
    {
        return AdamantiumVulkan.Spirv.Cross.Interop.SpirvCrossInterop.spvc_type_get_columns(this);
    }

    public SpvAccessQualifier GetImageAccessQualifier()
    {
        return AdamantiumVulkan.Spirv.Cross.Interop.SpirvCrossInterop.spvc_type_get_image_access_qualifier(this);
    }

    public SpvcBool GetImageArrayed()
    {
        return AdamantiumVulkan.Spirv.Cross.Interop.SpirvCrossInterop.spvc_type_get_image_arrayed(this);
    }

    public SpvDim GetImageDimension()
    {
        return AdamantiumVulkan.Spirv.Cross.Interop.SpirvCrossInterop.spvc_type_get_image_dimension(this);
    }

    public SpvcBool GetImageIsDepth()
    {
        return AdamantiumVulkan.Spirv.Cross.Interop.SpirvCrossInterop.spvc_type_get_image_is_depth(this);
    }

    public SpvcBool GetImageIsStorage()
    {
        return AdamantiumVulkan.Spirv.Cross.Interop.SpirvCrossInterop.spvc_type_get_image_is_storage(this);
    }

    public SpvcBool GetImageMultisampled()
    {
        return AdamantiumVulkan.Spirv.Cross.Interop.SpirvCrossInterop.spvc_type_get_image_multisampled(this);
    }

    ///<summary>
    /// Image type query.
    ///</summary>
    public SpvcTypeId GetImageSampledType()
    {
        return AdamantiumVulkan.Spirv.Cross.Interop.SpirvCrossInterop.spvc_type_get_image_sampled_type(this);
    }

    public SpvImageFormat GetImageStorageFormat()
    {
        return AdamantiumVulkan.Spirv.Cross.Interop.SpirvCrossInterop.spvc_type_get_image_storage_format(this);
    }

    public SpvcTypeId GetMemberType(uint index)
    {
        return AdamantiumVulkan.Spirv.Cross.Interop.SpirvCrossInterop.spvc_type_get_member_type(this, index);
    }

    public uint GetNumArrayDimensions()
    {
        return AdamantiumVulkan.Spirv.Cross.Interop.SpirvCrossInterop.spvc_type_get_num_array_dimensions(this);
    }

    public uint GetNumMemberTypes()
    {
        return AdamantiumVulkan.Spirv.Cross.Interop.SpirvCrossInterop.spvc_type_get_num_member_types(this);
    }

    public SpvStorageClass GetStorageClass()
    {
        return AdamantiumVulkan.Spirv.Cross.Interop.SpirvCrossInterop.spvc_type_get_storage_class(this);
    }

    public uint GetVectorSize()
    {
        return AdamantiumVulkan.Spirv.Cross.Interop.SpirvCrossInterop.spvc_type_get_vector_size(this);
    }

    public ref readonly SpvcTypeS GetPinnableReference() => ref __Instance;

    public static implicit operator AdamantiumVulkan.Spirv.Cross.Interop.SpvcTypeS(SpirvType s)
    {
        return s?.__Instance ?? new AdamantiumVulkan.Spirv.Cross.Interop.SpvcTypeS();
    }

    public static implicit operator SpirvType(AdamantiumVulkan.Spirv.Cross.Interop.SpvcTypeS s)
    {
        return new SpirvType(s);
    }

}



