// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AdamantiumVulkan.Spirv.Cross;

[Flags]
public enum CaptureMode : uint
{
    ///<summary>
    /// The Parsed IR payload will be copied, and the handle can be reused to create other compiler instances.
    ///</summary>
    Copy = 0,

    ///<summary>
    /// The payload will now be owned by the compiler. parsed_ir should now be considered a dead blob and must not be used further. This is optimal for performance and should be the go-to option.
    ///</summary>
    TakeOwnership = 1,

    ///<summary>
    /// The payload will now be owned by the compiler. parsed_ir should now be considered a dead blob and must not be used further. This is optimal for performance and should be the go-to option.
    ///</summary>
    IntMax = 2147483647,

}



