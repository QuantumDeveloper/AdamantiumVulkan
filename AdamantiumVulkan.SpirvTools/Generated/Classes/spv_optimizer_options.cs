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

// File: C:\VulkanSDK\1.4.309.0\Include\spirv-tools\libspirv.h Line: 518 Column: 34
public unsafe partial class spv_optimizer_options
{
    internal spv_optimizer_options_t __Instance;
    public spv_optimizer_options()
    {
    }

    public spv_optimizer_options(AdamantiumVulkan.SpirvTools.Interop.spv_optimizer_options_t __Instance)
    {
        this.__Instance = __Instance;
    }

    ///<summary>
    /// Creates an optimizer options object with default options. Returns a valid options object. The object remains valid until it is passed into |spvOptimizerOptionsDestroy|.
    ///</summary>
    public static spv_optimizer_options SpvOptimizerOptionsCreate()
    {
        return AdamantiumVulkan.SpirvTools.Interop.SpirvToolsInterop.spvOptimizerOptionsCreate();
    }

    ///<summary>
    /// Destroys the given optimizer options object.
    ///</summary>
    public void SpvOptimizerOptionsDestroy()
    {
        AdamantiumVulkan.SpirvTools.Interop.SpirvToolsInterop.spvOptimizerOptionsDestroy(this);
    }

    ///<summary>
    /// Records the maximum possible value for the id bound.
    ///</summary>
    public void SpvOptimizerOptionsSetMaxIdBound(uint val)
    {
        AdamantiumVulkan.SpirvTools.Interop.SpirvToolsInterop.spvOptimizerOptionsSetMaxIdBound(this, val);
    }

    ///<summary>
    /// Records whether all bindings within the module should be preserved.
    ///</summary>
    public void SpvOptimizerOptionsSetPreserveBindings(bool val)
    {
        AdamantiumVulkan.SpirvTools.Interop.SpirvToolsInterop.spvOptimizerOptionsSetPreserveBindings(this, val);
    }

    ///<summary>
    /// Records whether all specialization constants within the module should be preserved.
    ///</summary>
    public void SpvOptimizerOptionsSetPreserveSpecConstants(bool val)
    {
        AdamantiumVulkan.SpirvTools.Interop.SpirvToolsInterop.spvOptimizerOptionsSetPreserveSpecConstants(this, val);
    }

    ///<summary>
    /// Records whether or not the optimizer should run the validator before optimizing. If |val| is true, the validator will be run.
    ///</summary>
    public void SpvOptimizerOptionsSetRunValidator(bool val)
    {
        AdamantiumVulkan.SpirvTools.Interop.SpirvToolsInterop.spvOptimizerOptionsSetRunValidator(this, val);
    }

    ///<summary>
    /// Records the validator options that should be passed to the validator if it is run.
    ///</summary>
    public void SpvOptimizerOptionsSetValidatorOptions(AdamantiumVulkan.SpirvTools.spv_validator_options val)
    {
        var arg1 = ReferenceEquals(val, null) ? new spv_validator_options_t() : (spv_validator_options_t)val;
        AdamantiumVulkan.SpirvTools.Interop.SpirvToolsInterop.spvOptimizerOptionsSetValidatorOptions(this, arg1);
    }

    public ref readonly spv_optimizer_options_t GetPinnableReference() => ref __Instance;

    public static implicit operator AdamantiumVulkan.SpirvTools.Interop.spv_optimizer_options_t(spv_optimizer_options s)
    {
        return s?.__Instance ?? new AdamantiumVulkan.SpirvTools.Interop.spv_optimizer_options_t();
    }

    public static implicit operator spv_optimizer_options(AdamantiumVulkan.SpirvTools.Interop.spv_optimizer_options_t s)
    {
        return new spv_optimizer_options(s);
    }

}



