using System.Collections.Concurrent;
using System.Collections.Generic;
using AdamantiumVulkan.Core.Interop;

namespace AdamantiumVulkan.Core
{
    public static class FormatHelper
    {
        private static readonly ConcurrentDictionary<Format, int> sizeOfInBits = new ConcurrentDictionary<Format, int>();
        private static readonly HashSet<Format> compressedFormats = new HashSet<Format>();
        private static readonly HashSet<Format> packedFormats = new HashSet<Format>();

        public static bool IsValid(this Format format)
        {
            return format != Format.UNDEFINED && format != Format.MAX_ENUM;
        }

        public static bool IsCompressed(this Format format)
        {
            return compressedFormats.Contains(format);
        }

        public static bool IsPacked(this Format format)
        {
            return packedFormats.Contains(format);
        }

        public static int SizeOfInBits(this Format format)
        {
            sizeOfInBits.TryGetValue(format, out var value);
            return value;
        }

        public static int SizeOfInBytes(this Format format)
        {
            var sizeInBits = SizeOfInBits(format);
            return sizeInBits >> 3;
        }

        static FormatHelper()
        {
            packedFormats = new HashSet<Format>()
            {
                Format.R4G4_UNORM_PACK8,
                Format.R4G4B4A4_UNORM_PACK16,
                Format.B4G4R4A4_UNORM_PACK16,
                Format.R5G6B5_UNORM_PACK16,
                Format.B5G6R5_UNORM_PACK16,
                Format.R5G5B5A1_UNORM_PACK16,
                Format.B5G5R5A1_UNORM_PACK16,
                Format.A1R5G5B5_UNORM_PACK16,
                Format.A8B8G8R8_UNORM_PACK32,
                Format.A8B8G8R8_SNORM_PACK32,
                Format.A8B8G8R8_USCALED_PACK32,
                Format.A8B8G8R8_SSCALED_PACK32,
                Format.A8B8G8R8_UINT_PACK32,
                Format.A8B8G8R8_SINT_PACK32,
                Format.A8B8G8R8_SRGB_PACK32,
                Format.A2R10G10B10_UNORM_PACK32,
                Format.A2R10G10B10_SNORM_PACK32,
                Format.A2R10G10B10_USCALED_PACK32,
                Format.A2R10G10B10_SSCALED_PACK32,
                Format.A2R10G10B10_UINT_PACK32,
                Format.A2R10G10B10_SINT_PACK32,
                Format.A2B10G10R10_UNORM_PACK32,
                Format.A2B10G10R10_SNORM_PACK32,
                Format.A2B10G10R10_USCALED_PACK32,
                Format.A2B10G10R10_SSCALED_PACK32,
                Format.A2B10G10R10_UINT_PACK32,
                Format.A2B10G10R10_SINT_PACK32,
                Format.B10G11R11_UFLOAT_PACK32,
                Format.E5B9G9R9_UFLOAT_PACK32,
                Format.X8_D24_UNORM_PACK32,
                Format.R10X6_UNORM_PACK16,
                Format.R12X4_UNORM_PACK16
            };

            compressedFormats = new HashSet<Format>()
            {
                Format.BC1_RGB_UNORM_BLOCK,
                Format.BC1_RGB_SRGB_BLOCK, 
                Format.BC1_RGBA_UNORM_BLOCK,
                Format.BC1_RGBA_SRGB_BLOCK,
                Format.BC2_UNORM_BLOCK,
                Format.BC2_SRGB_BLOCK,
                Format.BC3_UNORM_BLOCK,
                Format.BC3_SRGB_BLOCK,
                Format.BC4_UNORM_BLOCK,
                Format.BC4_SNORM_BLOCK,
                Format.BC5_UNORM_BLOCK,
                Format.BC5_SNORM_BLOCK,
                Format.BC6H_UFLOAT_BLOCK,
                Format.BC6H_SFLOAT_BLOCK,
                Format.BC7_UNORM_BLOCK,
                Format.BC7_SRGB_BLOCK,
                Format.ETC2_R8G8B8_UNORM_BLOCK,
                Format.ETC2_R8G8B8_SRGB_BLOCK,
                Format.ETC2_R8G8B8A1_UNORM_BLOCK,
                Format.ETC2_R8G8B8A1_SRGB_BLOCK,
                Format.ETC2_R8G8B8A8_UNORM_BLOCK,
                Format.ETC2_R8G8B8A8_SRGB_BLOCK,
                Format.EAC_R11_UNORM_BLOCK,
                Format.EAC_R11_SNORM_BLOCK,
                Format.EAC_R11G11_UNORM_BLOCK,
                Format.EAC_R11G11_SNORM_BLOCK,
                Format.ASTC_4x4_UNORM_BLOCK,
                Format.ASTC_4x4_SRGB_BLOCK,
                Format.ASTC_5x4_UNORM_BLOCK,
                Format.ASTC_5x4_SRGB_BLOCK,
                Format.ASTC_5x5_UNORM_BLOCK,
                Format.ASTC_5x5_SRGB_BLOCK,
                Format.ASTC_6x5_UNORM_BLOCK,
                Format.ASTC_6x5_SRGB_BLOCK,
                Format.ASTC_6x6_UNORM_BLOCK,
                Format.ASTC_6x6_SRGB_BLOCK,
                Format.ASTC_8x5_UNORM_BLOCK,
                Format.ASTC_8x5_SRGB_BLOCK,
                Format.ASTC_8x6_UNORM_BLOCK,
                Format.ASTC_8x6_SRGB_BLOCK,
                Format.ASTC_8x8_UNORM_BLOCK,
                Format.ASTC_8x8_SRGB_BLOCK,
                Format.ASTC_10x5_UNORM_BLOCK,
                Format.ASTC_10x5_SRGB_BLOCK,
                Format.ASTC_10x6_UNORM_BLOCK,
                Format.ASTC_10x6_SRGB_BLOCK,
                Format.ASTC_10x8_UNORM_BLOCK,
                Format.ASTC_10x8_SRGB_BLOCK,
                Format.ASTC_10x10_UNORM_BLOCK,
                Format.ASTC_10x10_SRGB_BLOCK,
                Format.ASTC_12x10_UNORM_BLOCK,
                Format.ASTC_12x10_SRGB_BLOCK,
                Format.ASTC_12x12_UNORM_BLOCK,
                Format.ASTC_12x12_SRGB_BLOCK,
                Format.PVRTC1_2BPP_UNORM_BLOCK_IMG,
                Format.PVRTC1_4BPP_UNORM_BLOCK_IMG,
                Format.PVRTC2_2BPP_UNORM_BLOCK_IMG,
                Format.PVRTC2_4BPP_UNORM_BLOCK_IMG,
                Format.PVRTC1_2BPP_SRGB_BLOCK_IMG,
                Format.PVRTC1_4BPP_SRGB_BLOCK_IMG,
                Format.PVRTC2_2BPP_SRGB_BLOCK_IMG,
                Format.PVRTC2_4BPP_SRGB_BLOCK_IMG,
            };

            Init(new Format[] 
            {
                Format.R4G4_UNORM_PACK8,
                Format.R8_UNORM,
                Format.R8_SNORM,
                Format.R8_USCALED,
                Format.R8_SSCALED,
                Format.R8_UINT,
                Format.R8_SINT,
                Format.R8_SRGB,
                Format.S8_UINT,
                Format.BC2_UNORM_BLOCK,
                Format.BC2_SRGB_BLOCK,
                Format.BC3_UNORM_BLOCK,
                Format.BC3_SRGB_BLOCK,
            }, 8);

            Init(new Format[] 
            {
                Format.R4G4B4A4_UNORM_PACK16,
                Format.B4G4R4A4_UNORM_PACK16,
                Format.R5G6B5_UNORM_PACK16,
                Format.B5G6R5_UNORM_PACK16,
                Format.R5G5B5A1_UNORM_PACK16,
                Format.B5G5R5A1_UNORM_PACK16,
                Format.A1R5G5B5_UNORM_PACK16,
                Format.R8G8_UNORM,
                Format.R8G8_SNORM,
                Format.R8G8_USCALED,
                Format.R8G8_SSCALED,
                Format.R8G8_UINT,
                Format.R8G8_SINT,
                Format.R8G8_SRGB,
                Format.R16_UNORM,
                Format.R16_SNORM,
                Format.R16_USCALED,
                Format.R16_SSCALED,
                Format.R16_UINT,
                Format.R16_SINT,
                Format.R16_SFLOAT,
                Format.D16_UNORM
            }, 16);

            Init(new Format[]
            {
                Format.R8G8B8_UNORM,
                Format.R8G8B8_SNORM,
                Format.R8G8B8_USCALED,
                Format.R8G8B8_SSCALED,
                Format.R8G8B8_UINT,
                Format.R8G8B8_SINT,
                Format.R8G8B8_SRGB,
                Format.B8G8R8_UNORM,
                Format.B8G8R8_SNORM,
                Format.B8G8R8_USCALED,
                Format.B8G8R8_SSCALED,
                Format.B8G8R8_UINT,
                Format.B8G8R8_SINT,
                Format.B8G8R8_SRGB,
                Format.D16_UNORM_S8_UINT,
                Format.D32_SFLOAT_S8_UINT
            }, 24);

            Init(new Format[] 
            {
                Format.R8G8B8A8_UNORM,
                Format.R8G8B8A8_SNORM,
                Format.R8G8B8A8_USCALED,
                Format.R8G8B8A8_SSCALED,
                Format.R8G8B8A8_UINT,
                Format.R8G8B8A8_SINT,
                Format.R8G8B8A8_SRGB,
                Format.B8G8R8A8_UNORM,
                Format.B8G8R8A8_SNORM,
                Format.B8G8R8A8_USCALED,
                Format.B8G8R8A8_SSCALED,
                Format.B8G8R8A8_UINT,
                Format.B8G8R8A8_SINT,
                Format.B8G8R8A8_SRGB,
                Format.A8B8G8R8_UNORM_PACK32,
                Format.A8B8G8R8_SNORM_PACK32,
                Format.A8B8G8R8_USCALED_PACK32,
                Format.A8B8G8R8_SSCALED_PACK32,
                Format.A8B8G8R8_UINT_PACK32,
                Format.A8B8G8R8_SINT_PACK32,
                Format.A8B8G8R8_SRGB_PACK32,
                Format.A2R10G10B10_UNORM_PACK32,
                Format.A2R10G10B10_SNORM_PACK32,
                Format.A2R10G10B10_USCALED_PACK32,
                Format.A2R10G10B10_SSCALED_PACK32,
                Format.A2R10G10B10_UINT_PACK32,
                Format.A2R10G10B10_SINT_PACK32,
                Format.A2B10G10R10_UNORM_PACK32,
                Format.A2B10G10R10_SNORM_PACK32,
                Format.A2B10G10R10_USCALED_PACK32,
                Format.A2B10G10R10_SSCALED_PACK32,
                Format.A2B10G10R10_UINT_PACK32,
                Format.A2B10G10R10_SINT_PACK32,
                Format.R16G16_UNORM,
                Format.R16G16_SNORM,
                Format.R16G16_USCALED,
                Format.R16G16_SSCALED,
                Format.R16G16_UINT,
                Format.R16G16_SINT,
                Format.R16G16_SFLOAT,
                Format.R32_UINT,
                Format.R32_SINT,
                Format.R32_SFLOAT,
                Format.B10G11R11_UFLOAT_PACK32,
                Format.E5B9G9R9_UFLOAT_PACK32,
                Format.X8_D24_UNORM_PACK32,
                Format.D32_SFLOAT,
                Format.D24_UNORM_S8_UINT,
                Format.G8B8G8R8_422_UNORM,
                Format.B8G8R8G8_422_UNORM,
                Format.R10X6G10X6_UNORM_2PACK16,
                Format.R12X4G12X4_UNORM_2PACK16
            }, 32);

            Init(new Format[]
            {
                Format.R16G16B16_UNORM,
                Format.R16G16B16_SNORM,
                Format.R16G16B16_USCALED,
                Format.R16G16B16_SSCALED,
                Format.R16G16B16_UINT,
                Format.R16G16B16_SINT,
                Format.R16G16B16_SFLOAT
            }, 48);

            Init(new Format[] 
            {
                Format.R16G16B16A16_UNORM,
                Format.R16G16B16A16_SNORM,
                Format.R16G16B16A16_USCALED,
                Format.R16G16B16A16_SSCALED,
                Format.R16G16B16A16_UINT,
                Format.R16G16B16A16_SINT,
                Format.R16G16B16A16_SFLOAT,
                Format.R32G32_UINT,
                Format.R32G32_SINT,
                Format.R32G32_SFLOAT,
                Format.R64_UINT,
                Format.R64_SINT,
                Format.R64_SFLOAT,
                Format.BC1_RGB_UNORM_BLOCK,
                Format.BC1_RGB_SRGB_BLOCK,
                Format.BC1_RGBA_UNORM_BLOCK,
                Format.BC1_RGBA_SRGB_BLOCK,
                Format.BC4_UNORM_BLOCK,
                Format.BC4_SNORM_BLOCK,
                Format.ETC2_R8G8B8_UNORM_BLOCK,
                Format.ETC2_R8G8B8_SRGB_BLOCK,
                Format.ETC2_R8G8B8A1_UNORM_BLOCK,
                Format.ETC2_R8G8B8A1_SRGB_BLOCK,
                Format.EAC_R11_UNORM_BLOCK,
                Format.EAC_R11_SNORM_BLOCK,
                Format.R10X6G10X6B10X6A10X6_UNORM_4PACK16,
                Format.G10X6B10X6G10X6R10X6_422_UNORM_4PACK16,
                Format.B10X6G10X6R10X6G10X6_422_UNORM_4PACK16,
                Format.R12X4G12X4B12X4A12X4_UNORM_4PACK16,
                Format.G12X4B12X4G12X4R12X4_422_UNORM_4PACK16,
                Format.B12X4G12X4R12X4G12X4_422_UNORM_4PACK16,
                Format.G16B16G16R16_422_UNORM,
                Format.B16G16R16G16_422_UNORM
            }, 64);

            Init(new Format[]
            {
                Format.R32G32B32_UINT,
                Format.R32G32B32_SINT,
                Format.R32G32B32_SFLOAT
            }, 96);

            Init(new Format[] 
            {
                Format.R32G32B32A32_UINT,
                Format.R32G32B32A32_SINT,
                Format.R32G32B32A32_SFLOAT,
                Format.R64G64_UINT,
                Format.R64G64_SINT,
                Format.R64G64_SFLOAT,
                Format.BC5_UNORM_BLOCK,
                Format.BC5_SNORM_BLOCK,
                Format.BC6H_UFLOAT_BLOCK,
                Format.BC6H_SFLOAT_BLOCK,
                Format.BC7_UNORM_BLOCK,
                Format.BC7_SRGB_BLOCK,
                Format.ETC2_R8G8B8A8_UNORM_BLOCK,
                Format.ETC2_R8G8B8A8_SRGB_BLOCK,
                Format.EAC_R11G11_UNORM_BLOCK,
                Format.EAC_R11G11_SNORM_BLOCK,
                Format.ASTC_4x4_UNORM_BLOCK,
                Format.ASTC_4x4_SRGB_BLOCK,
                Format.ASTC_5x4_UNORM_BLOCK,
                Format.ASTC_5x4_SRGB_BLOCK,
                Format.ASTC_5x5_UNORM_BLOCK,
                Format.ASTC_5x5_SRGB_BLOCK,
                Format.ASTC_6x5_UNORM_BLOCK,
                Format.ASTC_6x5_SRGB_BLOCK,
                Format.ASTC_6x6_UNORM_BLOCK,
                Format.ASTC_6x6_SRGB_BLOCK,
                Format.ASTC_8x5_UNORM_BLOCK,
                Format.ASTC_8x5_SRGB_BLOCK,
                Format.ASTC_8x6_UNORM_BLOCK,
                Format.ASTC_8x6_SRGB_BLOCK,
                Format.ASTC_8x8_UNORM_BLOCK,
                Format.ASTC_8x8_SRGB_BLOCK,
                Format.ASTC_10x5_UNORM_BLOCK,
                Format.ASTC_10x5_SRGB_BLOCK,
                Format.ASTC_10x6_UNORM_BLOCK,
                Format.ASTC_10x6_SRGB_BLOCK,
                Format.ASTC_10x8_UNORM_BLOCK,
                Format.ASTC_10x8_SRGB_BLOCK,
                Format.ASTC_10x10_UNORM_BLOCK,
                Format.ASTC_10x10_SRGB_BLOCK,
                Format.ASTC_12x10_UNORM_BLOCK,
                Format.ASTC_12x10_SRGB_BLOCK,
                Format.ASTC_12x12_UNORM_BLOCK,
                Format.ASTC_12x12_SRGB_BLOCK
            }, 128);

            Init(new Format[]
            {
                Format.R64G64B64_UINT,
                Format.R64G64B64_SINT,
                Format.R64G64B64_SFLOAT
            }, 192);

            Init(new Format[] 
            {
                Format.R64G64B64A64_UINT,
                Format.R64G64B64A64_SINT,
                Format.R64G64B64A64_SFLOAT
            }, 256);

        }

        private static void Init(IEnumerable<Format> formats, int bits)
        {
            foreach(var format in formats)
            {
                sizeOfInBits.TryAdd(format, bits);
            }
        }
    }
}
