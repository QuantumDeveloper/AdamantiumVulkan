// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AdamantiumVulkan.Core;

namespace AdamantiumVulkan.Core.Interop;

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct VkRenderingFragmentShadingRateAttachmentInfoKHR
{
    public StructureType sType;
    public void* pNext;
    public VkImageView_T imageView;
    public ImageLayout imageLayout;
    public VkExtent2D shadingRateAttachmentTexelSize;
}



