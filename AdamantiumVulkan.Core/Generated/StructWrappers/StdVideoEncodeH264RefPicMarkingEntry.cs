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

public unsafe partial class StdVideoEncodeH264RefPicMarkingEntry : QBDisposableObject
{
    public StdVideoEncodeH264RefPicMarkingEntry()
    {
    }

    public StdVideoEncodeH264RefPicMarkingEntry(AdamantiumVulkan.Interop.StdVideoEncodeH264RefPicMarkingEntry _internal)
    {
        Memory_management_control_operation = _internal.memory_management_control_operation;
        Difference_of_pic_nums_minus1 = _internal.difference_of_pic_nums_minus1;
        Long_term_pic_num = _internal.long_term_pic_num;
        Long_term_frame_idx = _internal.long_term_frame_idx;
        Max_long_term_frame_idx_plus1 = _internal.max_long_term_frame_idx_plus1;
    }

    public StdVideoH264MemMgmtControlOp Memory_management_control_operation { get; set; }
    public ushort Difference_of_pic_nums_minus1 { get; set; }
    public ushort Long_term_pic_num { get; set; }
    public ushort Long_term_frame_idx { get; set; }
    public ushort Max_long_term_frame_idx_plus1 { get; set; }

    public AdamantiumVulkan.Interop.StdVideoEncodeH264RefPicMarkingEntry ToNative()
    {
        var _internal = new AdamantiumVulkan.Interop.StdVideoEncodeH264RefPicMarkingEntry();
        if (Memory_management_control_operation != default)
        {
            _internal.memory_management_control_operation = Memory_management_control_operation;
        }
        if (Difference_of_pic_nums_minus1 != default)
        {
            _internal.difference_of_pic_nums_minus1 = Difference_of_pic_nums_minus1;
        }
        if (Long_term_pic_num != default)
        {
            _internal.long_term_pic_num = Long_term_pic_num;
        }
        if (Long_term_frame_idx != default)
        {
            _internal.long_term_frame_idx = Long_term_frame_idx;
        }
        if (Max_long_term_frame_idx_plus1 != default)
        {
            _internal.max_long_term_frame_idx_plus1 = Max_long_term_frame_idx_plus1;
        }
        return _internal;
    }

    public static implicit operator StdVideoEncodeH264RefPicMarkingEntry(AdamantiumVulkan.Interop.StdVideoEncodeH264RefPicMarkingEntry s)
    {
        return new StdVideoEncodeH264RefPicMarkingEntry(s);
    }

}


