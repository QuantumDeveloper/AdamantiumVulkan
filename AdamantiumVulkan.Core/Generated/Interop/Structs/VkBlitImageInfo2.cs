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
public unsafe partial struct VkBlitImageInfo2
{
    public StructureType sType;
    public void* pNext;
    public VkImage_T srcImage;
    public ImageLayout srcImageLayout;
    public VkImage_T dstImage;
    public ImageLayout dstImageLayout;
    public uint regionCount;
    public VkImageBlit2* pRegions;
    public Filter filter;
}



