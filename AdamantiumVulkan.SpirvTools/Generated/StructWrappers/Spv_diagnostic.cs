// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System.Runtime.InteropServices;
using QuantumBinding.Utils;
using AdamantiumVulkan.SpirvTools.Interop;

namespace AdamantiumVulkan.SpirvTools;

public unsafe partial class Spv_diagnostic : QBDisposableObject
{
    private NativeStruct<sbyte> _error;

    public Spv_diagnostic()
    {
    }

    public Spv_diagnostic(AdamantiumVulkan.SpirvTools.Interop.spv_diagnostic _internal)
    {
        Position = new spv_position(_internal.position);
        if (_internal.error != null)
        {
            Error = *_internal.error;
            NativeUtils.Free(_internal.error);
        }
        IsTextSource = System.Convert.ToBoolean(_internal.isTextSource);
    }

    public spv_position Position { get; set; }
    public sbyte? Error { get; set; }
    public bool IsTextSource { get; set; }
    ///<summary>
    /// Destroys a diagnostic object. This is a no-op if diagnostic is a null pointer.
    ///</summary>
    public void SpvDiagnosticDestroy()
    {
        AdamantiumVulkan.SpirvTools.Interop.SpirvToolsInterop.spvDiagnosticDestroy(ToNative());
    }

    ///<summary>
    /// Prints the diagnostic to stderr.
    ///</summary>
    public spv_result_t SpvDiagnosticPrint()
    {
        return AdamantiumVulkan.SpirvTools.Interop.SpirvToolsInterop.spvDiagnosticPrint(ToNative());
    }


    public AdamantiumVulkan.SpirvTools.Interop.spv_diagnostic ToNative()
    {
        var _internal = new AdamantiumVulkan.SpirvTools.Interop.spv_diagnostic();
        if (Position != default)
        {
            _internal.position = Position;
        }
        _error.Dispose();
        if (Error.HasValue)
        {
            _error = new NativeStruct<sbyte>(Error.Value);
            _internal.error = _error.Handle;
        }
        if (IsTextSource != default)
        {
            _internal.isTextSource = System.Convert.ToByte(IsTextSource);
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        _error.Dispose();
    }


    public static implicit operator Spv_diagnostic(AdamantiumVulkan.SpirvTools.Interop.spv_diagnostic s)
    {
        return new Spv_diagnostic(s);
    }

}


