// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AdamantiumVulkan.SpirvTools;

namespace AdamantiumVulkan.SpirvTools.Interop;

// File: C:\VulkanSDK\1.4.309.0\Include\spirv-tools\libspirv.h Line: 435 Column: 16
///<summary>
/// An instruction parsed from a binary SPIR-V module.
///</summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct spv_parsed_instruction_t
{
    ///<summary>
    /// An array of words for this instruction, in native endianness.
    ///</summary>
    public uint* words;
    ///<summary>
    /// The number of words in this instruction.
    ///</summary>
    public ushort num_words;
    public ushort opcode;
    ///<summary>
    /// The extended instruction type, if opcode is OpExtInst. Otherwise this is the "none" value.
    ///</summary>
    public spv_ext_inst_type_t ext_inst_type;
    ///<summary>
    /// The type id, or 0 if this instruction doesn't have one.
    ///</summary>
    public uint type_id;
    ///<summary>
    /// The result id, or 0 if this instruction doesn't have one.
    ///</summary>
    public uint result_id;
    ///<summary>
    /// The array of parsed operands.
    ///</summary>
    public AdamantiumVulkan.SpirvTools.Interop.spv_parsed_operand_t* operands;
    public ushort num_operands;
}



