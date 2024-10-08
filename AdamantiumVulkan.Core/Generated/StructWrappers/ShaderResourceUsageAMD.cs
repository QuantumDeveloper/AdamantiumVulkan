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

public unsafe partial class ShaderResourceUsageAMD : QBDisposableObject
{
    public ShaderResourceUsageAMD()
    {
    }

    public ShaderResourceUsageAMD(AdamantiumVulkan.Core.Interop.VkShaderResourceUsageAMD _internal)
    {
        NumUsedVgprs = _internal.numUsedVgprs;
        NumUsedSgprs = _internal.numUsedSgprs;
        LdsSizePerLocalWorkGroup = _internal.ldsSizePerLocalWorkGroup;
        LdsUsageSizeInBytes = _internal.ldsUsageSizeInBytes;
        ScratchMemUsageInBytes = _internal.scratchMemUsageInBytes;
    }

    public uint NumUsedVgprs { get; set; }
    public uint NumUsedSgprs { get; set; }
    public uint LdsSizePerLocalWorkGroup { get; set; }
    public ulong LdsUsageSizeInBytes { get; set; }
    public ulong ScratchMemUsageInBytes { get; set; }

    public AdamantiumVulkan.Core.Interop.VkShaderResourceUsageAMD ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkShaderResourceUsageAMD();
        if (NumUsedVgprs != default)
        {
            _internal.numUsedVgprs = NumUsedVgprs;
        }
        if (NumUsedSgprs != default)
        {
            _internal.numUsedSgprs = NumUsedSgprs;
        }
        if (LdsSizePerLocalWorkGroup != default)
        {
            _internal.ldsSizePerLocalWorkGroup = LdsSizePerLocalWorkGroup;
        }
        if (LdsUsageSizeInBytes != default)
        {
            _internal.ldsUsageSizeInBytes = LdsUsageSizeInBytes;
        }
        if (ScratchMemUsageInBytes != default)
        {
            _internal.scratchMemUsageInBytes = ScratchMemUsageInBytes;
        }
        return _internal;
    }

    public static implicit operator ShaderResourceUsageAMD(AdamantiumVulkan.Core.Interop.VkShaderResourceUsageAMD s)
    {
        return new ShaderResourceUsageAMD(s);
    }

}



