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

public unsafe partial class PipelineExecutableInternalRepresentationKHR : QBDisposableObject
{
    public PipelineExecutableInternalRepresentationKHR()
    {
    }

    public PipelineExecutableInternalRepresentationKHR(AdamantiumVulkan.Core.Interop.VkPipelineExecutableInternalRepresentationKHR _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        Name = new string((sbyte*)_internal.name);
        Description = new string((sbyte*)_internal.description);
        IsText = _internal.isText;
        DataSize = _internal.dataSize;
        PData = _internal.pData;
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public VkBool32 IsText { get; set; }
    public ulong DataSize { get; set; }
    public void* PData { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPipelineExecutableInternalRepresentationKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPipelineExecutableInternalRepresentationKHR();
        _internal.sType = SType;
        _internal.pNext = PNext;
        if(Name != null)
        {
            if (Name.Length > 256)
                throw new System.ArgumentOutOfRangeException(nameof(Name), "Array is out of bounds. Size should not be more than 256");

            NativeUtils.StringToFixedArray(_internal.name, 256, Name, false);
        }
        if(Description != null)
        {
            if (Description.Length > 256)
                throw new System.ArgumentOutOfRangeException(nameof(Description), "Array is out of bounds. Size should not be more than 256");

            NativeUtils.StringToFixedArray(_internal.description, 256, Description, false);
        }
        _internal.isText = IsText;
        _internal.dataSize = DataSize;
        _internal.pData = PData;
        return _internal;
    }

    public static implicit operator PipelineExecutableInternalRepresentationKHR(AdamantiumVulkan.Core.Interop.VkPipelineExecutableInternalRepresentationKHR p)
    {
        return new PipelineExecutableInternalRepresentationKHR(p);
    }

}



