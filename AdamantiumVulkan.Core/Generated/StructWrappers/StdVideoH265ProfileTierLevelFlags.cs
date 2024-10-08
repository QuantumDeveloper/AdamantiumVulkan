// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System.Runtime.InteropServices;
using QuantumBinding.Utils;
using AdamantiumVulkan.Interop;

namespace AdamantiumVulkan;

public unsafe partial class StdVideoH265ProfileTierLevelFlags : QBDisposableObject
{
    public StdVideoH265ProfileTierLevelFlags()
    {
    }

    public StdVideoH265ProfileTierLevelFlags(AdamantiumVulkan.Interop.StdVideoH265ProfileTierLevelFlags _internal)
    {
        General_tier_flag = _internal.general_tier_flag;
        General_progressive_source_flag = _internal.general_progressive_source_flag;
        General_interlaced_source_flag = _internal.general_interlaced_source_flag;
        General_non_packed_constraint_flag = _internal.general_non_packed_constraint_flag;
        General_frame_only_constraint_flag = _internal.general_frame_only_constraint_flag;
    }

    public uint General_tier_flag { get; set; }
    public uint General_progressive_source_flag { get; set; }
    public uint General_interlaced_source_flag { get; set; }
    public uint General_non_packed_constraint_flag { get; set; }
    public uint General_frame_only_constraint_flag { get; set; }

    public AdamantiumVulkan.Interop.StdVideoH265ProfileTierLevelFlags ToNative()
    {
        var _internal = new AdamantiumVulkan.Interop.StdVideoH265ProfileTierLevelFlags();
        if (General_tier_flag != default)
        {
            _internal.general_tier_flag = General_tier_flag;
        }
        if (General_progressive_source_flag != default)
        {
            _internal.general_progressive_source_flag = General_progressive_source_flag;
        }
        if (General_interlaced_source_flag != default)
        {
            _internal.general_interlaced_source_flag = General_interlaced_source_flag;
        }
        if (General_non_packed_constraint_flag != default)
        {
            _internal.general_non_packed_constraint_flag = General_non_packed_constraint_flag;
        }
        if (General_frame_only_constraint_flag != default)
        {
            _internal.general_frame_only_constraint_flag = General_frame_only_constraint_flag;
        }
        return _internal;
    }

    public static implicit operator StdVideoH265ProfileTierLevelFlags(AdamantiumVulkan.Interop.StdVideoH265ProfileTierLevelFlags s)
    {
        return new StdVideoH265ProfileTierLevelFlags(s);
    }

}



