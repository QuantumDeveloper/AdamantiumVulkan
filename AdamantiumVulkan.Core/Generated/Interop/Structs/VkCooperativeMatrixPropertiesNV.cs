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
public unsafe partial struct VkCooperativeMatrixPropertiesNV
{
    public StructureType sType;
    public void* pNext;
    public uint MSize;
    public uint NSize;
    public uint KSize;
    public ComponentTypeNV AType;
    public ComponentTypeNV BType;
    public ComponentTypeNV CType;
    public ComponentTypeNV DType;
    public ScopeNV scope;
}


