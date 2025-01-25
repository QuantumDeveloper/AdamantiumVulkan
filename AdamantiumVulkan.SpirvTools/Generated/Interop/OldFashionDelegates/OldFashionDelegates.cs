// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using AdamantiumVulkan.SpirvTools;

namespace AdamantiumVulkan.SpirvTools.Interop;

public static unsafe class Delegates
{
    // File: C:\VulkanSDK\1.4.304.0\Include\spirv-tools\libspirv.h Line: 931 Column: 24
    ///<summary>
    /// A pointer to a function that accepts a parsed SPIR-V header. The integer arguments are the 32-bit words from the header, as specified in SPIR-V 1.0 Section 2.3 Table 1. The function should return SPV_SUCCESS if parsing should continue.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public unsafe delegate spv_result_t spv_parsed_header_fn_t(void* user_data, spv_endianness_t endian, uint magic, uint version, uint generator, uint id_bound, uint reserved);
    // File: C:\VulkanSDK\1.4.304.0\Include\spirv-tools\libspirv.h Line: 941 Column: 24
    ///<summary>
    /// A pointer to a function that accepts a parsed SPIR-V instruction. The parsed_instruction value is transient: it may be overwritten or released immediately after the function has returned. That also applies to the words array member of the parsed instruction. The function should return SPV_SUCCESS if and only if parsing should continue.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public unsafe delegate spv_result_t spv_parsed_instruction_fn_t(void* user_data, AdamantiumVulkan.SpirvTools.Interop.spv_parsed_instruction_t* parsed_instruction);
    // File: C:\VulkanSDK\1.4.304.0\Include\spirv-tools\libspirv.h Line: 965 Column: 16
    ///<summary>
    /// A pointer to a function that accepts a log message from an optimizer.
    ///</summary>
    [SuppressUnmanagedCodeSecurity]
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public unsafe delegate void spv_message_consumer(spv_message_level_t param0, sbyte* param1, AdamantiumVulkan.SpirvTools.Interop.spv_position_t* param2, sbyte* param3);
}


