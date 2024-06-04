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

public unsafe partial class CopyImageToMemoryInfoEXT : QBDisposableObject
{
    private NativeStruct<AdamantiumVulkan.Core.Interop.VkImageToMemoryCopyEXT> _pRegions;

    public CopyImageToMemoryInfoEXT()
    {
    }

    public CopyImageToMemoryInfoEXT(AdamantiumVulkan.Core.Interop.VkCopyImageToMemoryInfoEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        Flags = _internal.flags;
        SrcImage = new Image(_internal.srcImage);
        SrcImageLayout = _internal.srcImageLayout;
        RegionCount = _internal.regionCount;
        PRegions = new ImageToMemoryCopyEXT(*_internal.pRegions);
        NativeUtils.Free(_internal.pRegions);
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkHostImageCopyFlagsEXT Flags { get; set; }
    public Image SrcImage { get; set; }
    public ImageLayout SrcImageLayout { get; set; }
    public uint RegionCount { get; set; }
    public ImageToMemoryCopyEXT PRegions { get; set; }

    public AdamantiumVulkan.Core.Interop.VkCopyImageToMemoryInfoEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkCopyImageToMemoryInfoEXT();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.flags = Flags;
        _internal.srcImage = SrcImage;
        _internal.srcImageLayout = SrcImageLayout;
        _internal.regionCount = RegionCount;
        _pRegions.Dispose();
        if (PRegions != null)
        {
            var struct0 = PRegions.ToNative();
            _pRegions = new NativeStruct<AdamantiumVulkan.Core.Interop.VkImageToMemoryCopyEXT>(struct0);
            _internal.pRegions = _pRegions.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        _pRegions.Dispose();
    }


    public static implicit operator CopyImageToMemoryInfoEXT(AdamantiumVulkan.Core.Interop.VkCopyImageToMemoryInfoEXT c)
    {
        return new CopyImageToMemoryInfoEXT(c);
    }

}



