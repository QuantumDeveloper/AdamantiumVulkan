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

namespace AdamantiumVulkan.Spirv.Cross;

public unsafe static class SpirvCrossNative
{
    ///<summary>
    /// Gets the SPVC_C_API_VERSION_* used to build this library. Can be used to check for ABI mismatch if so-versioning did not catch it.
    ///</summary>
    public static void GetVersion(ref uint major, ref uint minor, ref uint patch)
    {
        var arg0 = NativeUtils.StructOrEnumToPointer(major);
        var arg1 = NativeUtils.StructOrEnumToPointer(minor);
        var arg2 = NativeUtils.StructOrEnumToPointer(patch);
        AdamantiumVulkan.Spirv.Cross.Interop.SpirvCrossInterop.spvc_get_version(arg0, arg1, arg2);
        major = *arg0;
        NativeUtils.Free(arg0);
        minor = *arg1;
        NativeUtils.Free(arg1);
        patch = *arg2;
        NativeUtils.Free(arg2);
    }

    ///<summary>
    /// Gets a human readable version string to identify which commit a particular binary was created from.
    ///</summary>
    public static string GetCommitRevisionAndTimestamp()
    {
        var result = AdamantiumVulkan.Spirv.Cross.Interop.SpirvCrossInterop.spvc_get_commit_revision_and_timestamp();
        return new string(result);
    }

    ///<summary>
    /// Runtime check for incompatibility. Obsolete.
    ///</summary>
    public static uint MslGetAuxBufferStructVersion()
    {
        return AdamantiumVulkan.Spirv.Cross.Interop.SpirvCrossInterop.spvc_msl_get_aux_buffer_struct_version();
    }

}

