// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using QuantumBinding.Utils;
using AdamantiumVulkan.SpirvTools.Interop;

namespace AdamantiumVulkan.SpirvTools;

// File: C:\VulkanSDK\1.3.275.0\Include\spirv-tools\libspirv.h Line: 489 Column: 32
public unsafe partial class spv_reducer_options
{
    internal spv_reducer_options_t __Instance;
    public spv_reducer_options()
    {
    }

    public spv_reducer_options(AdamantiumVulkan.SpirvTools.Interop.spv_reducer_options_t __Instance)
    {
        this.__Instance = __Instance;
    }

    ///<summary>
    /// Creates a reducer options object with default options. Returns a valid options object. The object remains valid until it is passed into |spvReducerOptionsDestroy|.
    ///</summary>
    public static spv_reducer_options SpvReducerOptionsCreate()
    {
        return AdamantiumVulkan.SpirvTools.Interop.SpirvToolsInterop.spvReducerOptionsCreate();
    }

    ///<summary>
    /// Destroys the given reducer options object.
    ///</summary>
    public void SpvReducerOptionsDestroy()
    {
        AdamantiumVulkan.SpirvTools.Interop.SpirvToolsInterop.spvReducerOptionsDestroy(this);
    }

    ///<summary>
    /// Sets the fail-on-validation-error option; if true, the reducer will return kStateInvalid if a reduction step yields a state that fails SPIR-V validation. Otherwise, an invalid state is treated as uninteresting and the reduction backtracks and continues.
    ///</summary>
    public void SpvReducerOptionsSetFailOnValidationError(bool fail_on_validation_error)
    {
        AdamantiumVulkan.SpirvTools.Interop.SpirvToolsInterop.spvReducerOptionsSetFailOnValidationError(this, fail_on_validation_error);
    }

    ///<summary>
    /// Sets the maximum number of reduction steps that should run before the reducer gives up.
    ///</summary>
    public void SpvReducerOptionsSetStepLimit(uint step_limit)
    {
        AdamantiumVulkan.SpirvTools.Interop.SpirvToolsInterop.spvReducerOptionsSetStepLimit(this, step_limit);
    }

    ///<summary>
    /// Sets the function that the reducer should target. If set to zero the reducer will target all functions as well as parts of the module that lie outside functions. Otherwise the reducer will restrict reduction to the function with result id |target_function|, which is required to exist.
    ///</summary>
    public void SpvReducerOptionsSetTargetFunction(uint target_function)
    {
        AdamantiumVulkan.SpirvTools.Interop.SpirvToolsInterop.spvReducerOptionsSetTargetFunction(this, target_function);
    }

    public ref readonly spv_reducer_options_t GetPinnableReference() => ref __Instance;

    public static implicit operator AdamantiumVulkan.SpirvTools.Interop.spv_reducer_options_t(spv_reducer_options s)
    {
        return s?.__Instance ?? new AdamantiumVulkan.SpirvTools.Interop.spv_reducer_options_t();
    }

    public static implicit operator spv_reducer_options(AdamantiumVulkan.SpirvTools.Interop.spv_reducer_options_t s)
    {
        return new spv_reducer_options(s);
    }

}



