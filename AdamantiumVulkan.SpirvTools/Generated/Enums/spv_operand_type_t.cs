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

// File: C:\VulkanSDK\1.4.309.0\Include\spirv-tools\libspirv.h Line: 123 Column: 14
///<summary>
/// The kinds of operands that an instruction may have.
///</summary>
public enum spv_operand_type_t : uint
{
    ///<summary>
    /// A sentinel value.
    ///</summary>
    OperandTypeNone = 0,

    ///<summary>
    /// Set 1: Operands that are IDs.
    ///</summary>
    OperandTypeId = 1,

    ///<summary>
    /// Set 1: Operands that are IDs.
    ///</summary>
    OperandTypeTypeId = 2,

    ///<summary>
    /// Set 1: Operands that are IDs.
    ///</summary>
    OperandTypeResultId = 3,

    ///<summary>
    /// SPIR-V Sec 3.25
    ///</summary>
    OperandTypeMemorySemanticsId = 4,

    ///<summary>
    /// SPIR-V Sec 3.27
    ///</summary>
    OperandTypeScopeId = 5,

    ///<summary>
    /// Always unsigned 32-bits.
    ///</summary>
    OperandTypeLiteralInteger = 6,

    ///<summary>
    /// The Instruction argument to OpExtInst. It's an unsigned 32-bit literal number indicating which instruction to use from an extended instruction set.
    ///</summary>
    OperandTypeExtensionInstructionNumber = 7,

    ///<summary>
    /// The Opcode argument to OpSpecConstantOp. It determines the operation to be performed on constant operands to compute a specialization constant result.
    ///</summary>
    OperandTypeSpecConstantOpNumber = 8,

    ///<summary>
    /// A literal number whose format and size are determined by a previous operand in the same instruction. It's a signed integer, an unsigned integer, or a floating point number. It also has a specified bit width. The width may be larger than 32, which would require such a typed literal value to occupy multiple SPIR-V words.
    ///</summary>
    OperandTypeTypedLiteralNumber = 9,

    ///<summary>
    /// Always 32-bit float.
    ///</summary>
    OperandTypeLiteralFloat = 10,

    ///<summary>
    /// Set 3: The literal string operand type.
    ///</summary>
    OperandTypeLiteralString = 11,

    ///<summary>
    /// SPIR-V Sec 3.2
    ///</summary>
    OperandTypeSourceLanguage = 12,

    ///<summary>
    /// SPIR-V Sec 3.3
    ///</summary>
    OperandTypeExecutionModel = 13,

    ///<summary>
    /// SPIR-V Sec 3.4
    ///</summary>
    OperandTypeAddressingModel = 14,

    ///<summary>
    /// SPIR-V Sec 3.5
    ///</summary>
    OperandTypeMemoryModel = 15,

    ///<summary>
    /// SPIR-V Sec 3.6
    ///</summary>
    OperandTypeExecutionMode = 16,

    ///<summary>
    /// SPIR-V Sec 3.7
    ///</summary>
    OperandTypeStorageClass = 17,

    ///<summary>
    /// SPIR-V Sec 3.8
    ///</summary>
    OperandTypeDimensionality = 18,

    ///<summary>
    /// SPIR-V Sec 3.9
    ///</summary>
    OperandTypeSamplerAddressingMode = 19,

    ///<summary>
    /// SPIR-V Sec 3.10
    ///</summary>
    OperandTypeSamplerFilterMode = 20,

    ///<summary>
    /// SPIR-V Sec 3.11
    ///</summary>
    OperandTypeSamplerImageFormat = 21,

    ///<summary>
    /// SPIR-V Sec 3.12
    ///</summary>
    OperandTypeImageChannelOrder = 22,

    ///<summary>
    /// SPIR-V Sec 3.13
    ///</summary>
    OperandTypeImageChannelDataType = 23,

    ///<summary>
    /// SPIR-V Sec 3.16
    ///</summary>
    OperandTypeFpRoundingMode = 24,

    ///<summary>
    /// SPIR-V Sec 3.17
    ///</summary>
    OperandTypeLinkageType = 25,

    ///<summary>
    /// SPIR-V Sec 3.18
    ///</summary>
    OperandTypeAccessQualifier = 26,

    ///<summary>
    /// SPIR-V Sec 3.19
    ///</summary>
    OperandTypeFunctionParameterAttribute = 27,

    ///<summary>
    /// SPIR-V Sec 3.20
    ///</summary>
    OperandTypeDecoration = 28,

    ///<summary>
    /// SPIR-V Sec 3.21
    ///</summary>
    OperandTypeBuiltIn = 29,

    ///<summary>
    /// SPIR-V Sec 3.28
    ///</summary>
    OperandTypeGroupOperation = 30,

    ///<summary>
    /// SPIR-V Sec 3.29
    ///</summary>
    OperandTypeKernelEnqFlags = 31,

    ///<summary>
    /// SPIR-V Sec 3.30
    ///</summary>
    OperandTypeKernelProfilingInfo = 32,

    ///<summary>
    /// SPIR-V Sec 3.31
    ///</summary>
    OperandTypeCapability = 33,

    ///<summary>
    /// SPIR-V Sec 3.51
    ///</summary>
    OperandTypeFpencoding = 34,

    ///<summary>
    /// SPIR-V Sec 3.14
    ///</summary>
    OperandTypeImage = 35,

    ///<summary>
    /// SPIR-V Sec 3.15
    ///</summary>
    OperandTypeFpFastMathMode = 36,

    ///<summary>
    /// SPIR-V Sec 3.22
    ///</summary>
    OperandTypeSelectionControl = 37,

    ///<summary>
    /// SPIR-V Sec 3.23
    ///</summary>
    OperandTypeLoopControl = 38,

    ///<summary>
    /// SPIR-V Sec 3.24
    ///</summary>
    OperandTypeFunctionControl = 39,

    ///<summary>
    /// SPIR-V Sec 3.26
    ///</summary>
    OperandTypeMemoryAccess = 40,

    ///<summary>
    /// SPIR-V Sec 3.FSR
    ///</summary>
    OperandTypeFragmentShadingRate = 41,

    OperandTypeOptionalId = 42,

    ///<summary>
    /// An optional image operand type.
    ///</summary>
    OperandTypeOptionalImage = 43,

    ///<summary>
    /// An optional memory access type.
    ///</summary>
    OperandTypeOptionalMemoryAccess = 44,

    ///<summary>
    /// An optional literal integer.
    ///</summary>
    OperandTypeOptionalLiteralInteger = 45,

    ///<summary>
    /// An optional literal number, which may be either integer or floating point.
    ///</summary>
    OperandTypeOptionalLiteralNumber = 46,

    ///<summary>
    /// Like SPV_OPERAND_TYPE_TYPED_LITERAL_NUMBER, but optional, and integral.
    ///</summary>
    OperandTypeOptionalTypedLiteralInteger = 47,

    ///<summary>
    /// An optional literal string.
    ///</summary>
    OperandTypeOptionalLiteralString = 48,

    ///<summary>
    /// An optional access qualifier
    ///</summary>
    OperandTypeOptionalAccessQualifier = 49,

    ///<summary>
    /// An optional context-independent value, or CIV. CIVs are tokens that we can assemble regardless of where they occur -- literals, IDs, immediate integers, etc.
    ///</summary>
    OperandTypeOptionalCiv = 50,

    ///<summary>
    /// An optional floating point encoding enum
    ///</summary>
    OperandTypeOptionalFpencoding = 51,

    OperandTypeVariableId = 52,

    ///<summary>
    /// A variable operand represents zero or more logical operands. In an instruction definition, this may only appear at the end of the operand types.
    ///</summary>
    OperandTypeVariableLiteralInteger = 53,

    ///<summary>
    /// A sequence of zero or more pairs of (typed literal integer, Id). Expands to zero or more: (SPV_OPERAND_TYPE_TYPED_LITERAL_INTEGER, SPV_OPERAND_TYPE_ID) where the literal number must always be an integer of some sort.
    ///</summary>
    OperandTypeVariableLiteralIntegerId = 54,

    OperandTypeVariableIdLiteralInteger = 55,

    ///<summary>
    /// DebugInfo Sec 3.2. A mask.
    ///</summary>
    OperandTypeDebugInfoFlags = 56,

    ///<summary>
    /// DebugInfo Sec 3.3
    ///</summary>
    OperandTypeDebugBaseTypeAttributeEncoding = 57,

    ///<summary>
    /// DebugInfo Sec 3.4
    ///</summary>
    OperandTypeDebugCompositeType = 58,

    ///<summary>
    /// DebugInfo Sec 3.5
    ///</summary>
    OperandTypeDebugTypeQualifier = 59,

    ///<summary>
    /// DebugInfo Sec 3.6
    ///</summary>
    OperandTypeDebugOperation = 60,

    ///<summary>
    /// Sec 3.2. A Mask
    ///</summary>
    OperandTypeCldebug100DebugInfoFlags = 61,

    ///<summary>
    /// Sec 3.3
    ///</summary>
    OperandTypeCldebug100DebugBaseTypeAttributeEncoding = 62,

    ///<summary>
    /// Sec 3.4
    ///</summary>
    OperandTypeCldebug100DebugCompositeType = 63,

    ///<summary>
    /// Sec 3.5
    ///</summary>
    OperandTypeCldebug100DebugTypeQualifier = 64,

    ///<summary>
    /// Sec 3.6
    ///</summary>
    OperandTypeCldebug100DebugOperation = 65,

    ///<summary>
    /// Sec 3.7
    ///</summary>
    OperandTypeCldebug100DebugImportedEntity = 66,

    ///<summary>
    /// Sec 3.17 FP Denorm Mode
    ///</summary>
    OperandTypeFpdenormMode = 67,

    ///<summary>
    /// Sec 3.18 FP Operation Mode
    ///</summary>
    OperandTypeFpoperationMode = 68,

    ///<summary>
    /// A value enum from https://github.com/KhronosGroup/SPIRV-Headers/pull/177
    ///</summary>
    OperandTypeQuantizationModes = 69,

    ///<summary>
    /// A value enum from https://github.com/KhronosGroup/SPIRV-Headers/pull/177
    ///</summary>
    OperandTypeOverflowModes = 70,

    ///<summary>
    /// SPIR-V Sec 3.RF
    ///</summary>
    OperandTypeRayFlags = 71,

    ///<summary>
    /// SPIR-V Sec 3.RQIntersection
    ///</summary>
    OperandTypeRayQueryIntersection = 72,

    ///<summary>
    /// SPIR-V Sec 3.RQCommitted
    ///</summary>
    OperandTypeRayQueryCommittedIntersectionType = 73,

    ///<summary>
    /// SPIR-V Sec 3.RQCandidate
    ///</summary>
    OperandTypeRayQueryCandidateIntersectionType = 74,

    ///<summary>
    /// SPIR-V Sec 3.x
    ///</summary>
    OperandTypePackedVectorFormat = 75,

    ///<summary>
    /// An optional packed vector format
    ///</summary>
    OperandTypeOptionalPackedVectorFormat = 76,

    ///<summary>
    /// Concrete operand types for cooperative matrix.
    ///</summary>
    OperandTypeCooperativeMatrixOperands = 77,

    ///<summary>
    /// An optional cooperative matrix operands
    ///</summary>
    OperandTypeOptionalCooperativeMatrixOperands = 78,

    ///<summary>
    /// An optional cooperative matrix operands
    ///</summary>
    OperandTypeCooperativeMatrixLayout = 79,

    ///<summary>
    /// An optional cooperative matrix operands
    ///</summary>
    OperandTypeCooperativeMatrixUse = 80,

    ///<summary>
    /// Enum type from SPV_INTEL_global_variable_fpga_decorations
    ///</summary>
    OperandTypeInitializationModeQualifier = 81,

    ///<summary>
    /// Enum type from SPV_INTEL_global_variable_host_access
    ///</summary>
    OperandTypeHostAccessQualifier = 82,

    ///<summary>
    /// Enum type from SPV_INTEL_cache_controls
    ///</summary>
    OperandTypeLoadCacheControl = 83,

    ///<summary>
    /// Enum type from SPV_INTEL_cache_controls
    ///</summary>
    OperandTypeStoreCacheControl = 84,

    ///<summary>
    /// Enum type from SPV_INTEL_maximum_registers
    ///</summary>
    OperandTypeNamedMaximumNumberOfRegisters = 85,

    ///<summary>
    /// Enum type from SPV_NV_raw_access_chains
    ///</summary>
    OperandTypeRawAccessChainOperands = 86,

    ///<summary>
    /// Optional enum type from SPV_NV_raw_access_chains
    ///</summary>
    OperandTypeOptionalRawAccessChainOperands = 87,

    ///<summary>
    /// Enum type from SPV_NV_tensor_addressing
    ///</summary>
    OperandTypeTensorClampMode = 88,

    ///<summary>
    /// Enum type from SPV_NV_cooperative_matrix2
    ///</summary>
    OperandTypeCooperativeMatrixReduce = 89,

    ///<summary>
    /// Enum type from SPV_NV_cooperative_matrix2
    ///</summary>
    OperandTypeTensorAddressingOperands = 90,

    ///<summary>
    /// Optional types from SPV_INTEL_subgroup_matrix_multiply_accumulate
    ///</summary>
    OperandTypeMatrixMultiplyAccumulateOperands = 91,

    ///<summary>
    /// Optional types from SPV_INTEL_subgroup_matrix_multiply_accumulate
    ///</summary>
    OperandTypeOptionalMatrixMultiplyAccumulateOperands = 92,

    ///<summary>
    /// Optional types from SPV_INTEL_subgroup_matrix_multiply_accumulate
    ///</summary>
    OperandTypeCooperativeVectorMatrixLayout = 93,

    ///<summary>
    /// Optional types from SPV_INTEL_subgroup_matrix_multiply_accumulate
    ///</summary>
    OperandTypeComponentType = 94,

    ///<summary>
    /// This is a sentinel value, and does not represent an operand type. It should come last.
    ///</summary>
    OperandTypeNumOperandTypes = 95,

    Force32bitSpvOperandTypeT = 2147483647,

}



