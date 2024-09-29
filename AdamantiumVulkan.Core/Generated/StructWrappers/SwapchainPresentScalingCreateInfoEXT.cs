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

public unsafe partial class SwapchainPresentScalingCreateInfoEXT : QBDisposableObject
{
    public SwapchainPresentScalingCreateInfoEXT()
    {
    }

    public SwapchainPresentScalingCreateInfoEXT(AdamantiumVulkan.Core.Interop.VkSwapchainPresentScalingCreateInfoEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        ScalingBehavior = _internal.scalingBehavior;
        PresentGravityX = _internal.presentGravityX;
        PresentGravityY = _internal.presentGravityY;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public VkPresentScalingFlagsEXT ScalingBehavior { get; set; }
    public VkPresentGravityFlagsEXT PresentGravityX { get; set; }
    public VkPresentGravityFlagsEXT PresentGravityY { get; set; }

    public AdamantiumVulkan.Core.Interop.VkSwapchainPresentScalingCreateInfoEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkSwapchainPresentScalingCreateInfoEXT();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (ScalingBehavior != (uint)default)
        {
            _internal.scalingBehavior = ScalingBehavior;
        }
        if (PresentGravityX != (uint)default)
        {
            _internal.presentGravityX = PresentGravityX;
        }
        if (PresentGravityY != (uint)default)
        {
            _internal.presentGravityY = PresentGravityY;
        }
        return _internal;
    }

    public static implicit operator SwapchainPresentScalingCreateInfoEXT(AdamantiumVulkan.Core.Interop.VkSwapchainPresentScalingCreateInfoEXT s)
    {
        return new SwapchainPresentScalingCreateInfoEXT(s);
    }

}



