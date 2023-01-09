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

public unsafe partial class ShaderModuleCreateInfo : QBDisposableObject
{
    private NativeStructArray<byte> pCode;

    public ShaderModuleCreateInfo()
    {
    }

    public ShaderModuleCreateInfo(AdamantiumVulkan.Core.Interop.VkShaderModuleCreateInfo _internal)
    {
        PNext = _internal.pNext;
        Flags = _internal.flags;
        CodeSize = _internal.codeSize;
        PCode = new byte[_internal.codeSize];
        PCode = NativeUtils.PointerToManagedArray(_internal.pCode, (long)_internal.codeSize);
        NativeUtils.Free(_internal.pCode);
    }

    public StructureType SType => StructureType.ShaderModuleCreateInfo;
    public void* PNext { get; set; }
    public VkShaderModuleCreateFlags Flags { get; set; }
    public ulong CodeSize { get; set; }
    public byte[] PCode { get; set; }

    public AdamantiumVulkan.Core.Interop.VkShaderModuleCreateInfo ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkShaderModuleCreateInfo();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.flags = Flags;
        _internal.codeSize = CodeSize;
        pCode.Dispose();
        if (PCode != null)
        {
            var tmpArray0 = new byte[PCode.Length];
            for (int i = 0; i < PCode.Length; ++i)
            {
                tmpArray0[i] = PCode[i];
            }
            pCode = new NativeStructArray<byte>(tmpArray0);
            _internal.pCode = pCode.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        pCode.Dispose();
    }


    public static implicit operator ShaderModuleCreateInfo(AdamantiumVulkan.Core.Interop.VkShaderModuleCreateInfo s)
    {
        return new ShaderModuleCreateInfo(s);
    }

}


