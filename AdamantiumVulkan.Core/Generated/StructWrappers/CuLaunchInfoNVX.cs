// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

using System.Runtime.InteropServices;
using QuantumBinding.Utils;
using AdamantiumVulkan.Core.Interop;

namespace AdamantiumVulkan.Core;

public unsafe partial class CuLaunchInfoNVX : QBDisposableObject
{
    public CuLaunchInfoNVX()
    {
    }

    public CuLaunchInfoNVX(AdamantiumVulkan.Core.Interop.VkCuLaunchInfoNVX _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        Function = new CuFunctionNVX(_internal.function);
        GridDimX = _internal.gridDimX;
        GridDimY = _internal.gridDimY;
        GridDimZ = _internal.gridDimZ;
        BlockDimX = _internal.blockDimX;
        BlockDimY = _internal.blockDimY;
        BlockDimZ = _internal.blockDimZ;
        SharedMemBytes = _internal.sharedMemBytes;
        ParamCount = _internal.paramCount;
        Params = _internal.pParams;
        ExtraCount = _internal.extraCount;
        PExtras = _internal.pExtras;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public CuFunctionNVX Function { get; set; }
    public uint GridDimX { get; set; }
    public uint GridDimY { get; set; }
    public uint GridDimZ { get; set; }
    public uint BlockDimX { get; set; }
    public uint BlockDimY { get; set; }
    public uint BlockDimZ { get; set; }
    public uint SharedMemBytes { get; set; }
    public ulong ParamCount { get; set; }
    public void** Params { get; set; }
    public ulong ExtraCount { get; set; }
    public void** PExtras { get; set; }

    public AdamantiumVulkan.Core.Interop.VkCuLaunchInfoNVX ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkCuLaunchInfoNVX();
        if (SType != default)
        {
            _internal.sType = SType;
        }
        _internal.pNext = PNext;
        if (Function != default)
        {
            _internal.function = Function;
        }
        if (GridDimX != default)
        {
            _internal.gridDimX = GridDimX;
        }
        if (GridDimY != default)
        {
            _internal.gridDimY = GridDimY;
        }
        if (GridDimZ != default)
        {
            _internal.gridDimZ = GridDimZ;
        }
        if (BlockDimX != default)
        {
            _internal.blockDimX = BlockDimX;
        }
        if (BlockDimY != default)
        {
            _internal.blockDimY = BlockDimY;
        }
        if (BlockDimZ != default)
        {
            _internal.blockDimZ = BlockDimZ;
        }
        if (SharedMemBytes != default)
        {
            _internal.sharedMemBytes = SharedMemBytes;
        }
        if (ParamCount != default)
        {
            _internal.paramCount = ParamCount;
        }
        _internal.pParams = Params;
        if (ExtraCount != default)
        {
            _internal.extraCount = ExtraCount;
        }
        _internal.pExtras = PExtras;
        return _internal;
    }

    public static implicit operator CuLaunchInfoNVX(AdamantiumVulkan.Core.Interop.VkCuLaunchInfoNVX c)
    {
        return new CuLaunchInfoNVX(c);
    }

}



