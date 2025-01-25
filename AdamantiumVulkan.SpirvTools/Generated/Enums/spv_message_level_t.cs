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

// File: C:\VulkanSDK\1.4.304.0\Include\spirv-tools\libspirv.h Line: 87 Column: 14
///<summary>
/// Severity levels of messages communicated to the consumer.
///</summary>
public enum spv_message_level_t : uint
{
    ///<summary>
    /// Unrecoverable error due to environment. Will exit the program immediately. E.g., out of memory.
    ///</summary>
    Fatal = 0,

    ///<summary>
    /// Unrecoverable error due to SPIRV-Tools internals. Will exit the program immediately. E.g., unimplemented feature.
    ///</summary>
    InternalError = 1,

    ///<summary>
    /// Normal error due to user input.
    ///</summary>
    Error = 2,

    ///<summary>
    /// Warning information.
    ///</summary>
    Warning = 3,

    ///<summary>
    /// General information.
    ///</summary>
    Info = 4,

    ///<summary>
    /// Debug information.
    ///</summary>
    Debug = 5,

}



