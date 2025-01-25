// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AdamantiumVulkan.Spirv.Cross;
using AdamantiumVulkan.Spirv;

namespace AdamantiumVulkan.Spirv.Cross.Interop;

// File: C:\VulkanSDK\1.4.304.0\Include\spirv_cross\spirv_cross_c.h Line: 318 Column: 16
///<summary>
/// Maps to C++ API. Deprecated; use spvc_msl_shader_interface_var.
///</summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct SpvcMslVertexAttribute
{
    public uint location;
    ///<summary>
    /// Obsolete, do not use. Only lingers on for ABI compatibility.
    ///</summary>
    public uint msl_buffer;
    ///<summary>
    /// Obsolete, do not use. Only lingers on for ABI compatibility.
    ///</summary>
    public uint msl_offset;
    ///<summary>
    /// Obsolete, do not use. Only lingers on for ABI compatibility.
    ///</summary>
    public uint msl_stride;
    ///<summary>
    /// Obsolete, do not use. Only lingers on for ABI compatibility.
    ///</summary>
    public SpvcBool per_instance;
    public MslShaderVariableFormat format;
    public SpvBuiltIn builtin;
}



