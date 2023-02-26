// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AdamantiumVulkan.Shaders.Interop;

///<summary>
/// An include result.
///</summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct ShadercIncludeResult
{
    ///<summary>
    /// The name of the source file. The name should be fully resolved in the sense that it should be a unique name in the context of the includer. For example, if the includer maps source names to files in a filesystem, then this name should be the absolute path of the file. For a failed inclusion, this string is empty.
    ///</summary>
    public sbyte* source_name;
    public ulong source_name_length;
    ///<summary>
    /// The text contents of the source file in the normal case. For a failed inclusion, this contains the error message.
    ///</summary>
    public sbyte* content;
    public ulong content_length;
    ///<summary>
    /// User data to be passed along with this request.
    ///</summary>
    public void* user_data;
}



