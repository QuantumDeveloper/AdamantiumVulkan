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

public unsafe partial class SwapchainCreateInfoKHR : QBDisposableObject
{
    private NativeStructArray<uint> _pQueueFamilyIndices;

    public SwapchainCreateInfoKHR()
    {
    }

    public SwapchainCreateInfoKHR(AdamantiumVulkan.Core.Interop.VkSwapchainCreateInfoKHR _internal)
    {
        PNext = _internal.pNext;
        Flags = _internal.flags;
        Surface = new SurfaceKHR(_internal.surface);
        MinImageCount = _internal.minImageCount;
        ImageFormat = _internal.imageFormat;
        ImageColorSpace = _internal.imageColorSpace;
        ImageExtent = new Extent2D(_internal.imageExtent);
        ImageArrayLayers = _internal.imageArrayLayers;
        ImageUsage = _internal.imageUsage;
        ImageSharingMode = _internal.imageSharingMode;
        QueueFamilyIndexCount = _internal.queueFamilyIndexCount;
        PQueueFamilyIndices = new uint[_internal.queueFamilyIndexCount];
        PQueueFamilyIndices = NativeUtils.PointerToManagedArray(_internal.pQueueFamilyIndices, (long)_internal.queueFamilyIndexCount);
        NativeUtils.Free(_internal.pQueueFamilyIndices);
        PreTransform = _internal.preTransform;
        CompositeAlpha = _internal.compositeAlpha;
        PresentMode = _internal.presentMode;
        Clipped = _internal.clipped;
        OldSwapchain = new SwapchainKHR(_internal.oldSwapchain);
    }

    public StructureType SType => StructureType.SwapchainCreateInfoKhr;
    public void* PNext { get; set; }
    public VkSwapchainCreateFlagsKHR Flags { get; set; }
    public SurfaceKHR Surface { get; set; }
    public uint MinImageCount { get; set; }
    public Format ImageFormat { get; set; }
    public ColorSpaceKHR ImageColorSpace { get; set; }
    public Extent2D ImageExtent { get; set; }
    public uint ImageArrayLayers { get; set; }
    public ImageUsageFlagBits ImageUsage { get; set; }
    public SharingMode ImageSharingMode { get; set; }
    public uint QueueFamilyIndexCount { get; set; }
    public uint[] PQueueFamilyIndices { get; set; }
    public SurfaceTransformFlagBitsKHR PreTransform { get; set; }
    public CompositeAlphaFlagBitsKHR CompositeAlpha { get; set; }
    public PresentModeKHR PresentMode { get; set; }
    public VkBool32 Clipped { get; set; }
    public SwapchainKHR OldSwapchain { get; set; }

    public AdamantiumVulkan.Core.Interop.VkSwapchainCreateInfoKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkSwapchainCreateInfoKHR();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.flags = Flags;
        _internal.surface = Surface;
        _internal.minImageCount = MinImageCount;
        _internal.imageFormat = ImageFormat;
        _internal.imageColorSpace = ImageColorSpace;
        if (ImageExtent != null)
        {
            _internal.imageExtent = ImageExtent.ToNative();
        }
        _internal.imageArrayLayers = ImageArrayLayers;
        _internal.imageUsage = ImageUsage;
        _internal.imageSharingMode = ImageSharingMode;
        _internal.queueFamilyIndexCount = QueueFamilyIndexCount;
        _pQueueFamilyIndices.Dispose();
        if (PQueueFamilyIndices != null)
        {
            var tmpArray0 = new uint[PQueueFamilyIndices.Length];
            for (int i = 0; i < PQueueFamilyIndices.Length; ++i)
            {
                tmpArray0[i] = PQueueFamilyIndices[i];
            }
            _pQueueFamilyIndices = new NativeStructArray<uint>(tmpArray0);
            _internal.pQueueFamilyIndices = _pQueueFamilyIndices.Handle;
        }
        _internal.preTransform = PreTransform;
        _internal.compositeAlpha = CompositeAlpha;
        _internal.presentMode = PresentMode;
        _internal.clipped = Clipped;
        _internal.oldSwapchain = OldSwapchain;
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        _pQueueFamilyIndices.Dispose();
    }


    public static implicit operator SwapchainCreateInfoKHR(AdamantiumVulkan.Core.Interop.VkSwapchainCreateInfoKHR s)
    {
        return new SwapchainCreateInfoKHR(s);
    }

}



