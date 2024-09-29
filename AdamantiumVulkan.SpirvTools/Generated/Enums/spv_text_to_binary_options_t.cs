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

// File: C:\VulkanSDK\1.3.283.0\Include\spirv-tools\libspirv.h Line: 362 Column: 14
[Flags]
public enum spv_text_to_binary_options_t : uint
{
    TextToBinaryOptionNone = 1,

    ///<summary>
    /// Numeric IDs in the binary will have the same values as in the source. Non-numeric IDs are allocated by filling in the gaps, starting with 1 and going up.
    ///</summary>
    TextToBinaryOptionPreserveNumericIds = 2,

    Force32bitSpvTextToBinaryOptionsT = 2147483647,

}


