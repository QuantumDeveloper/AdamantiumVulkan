// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AdamantiumVulkan.SpirvTools;

// File: C:\VulkanSDK\1.4.304.0\Include\spirv-tools\libspirv.h Line: 364 Column: 14
///<summary>
/// This determines at a high level the kind of a binary-encoded literal number, but not the bit width. In principle, these could probably be folded into new entries in spv_operand_type_t. But then we'd have some special case differences between the assembler and disassembler.
///</summary>
public enum spv_number_kind_t : uint
{
    ///<summary>
    /// The default for value initialization.
    ///</summary>
    None = 0,

    UnsignedInt = 1,

    SignedInt = 2,

    Floating = 3,

}



