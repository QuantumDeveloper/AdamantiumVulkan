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

public unsafe partial class PhysicalDeviceMeshShaderFeaturesNV : QBDisposableObject
{
    public PhysicalDeviceMeshShaderFeaturesNV()
    {
    }

    public PhysicalDeviceMeshShaderFeaturesNV(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceMeshShaderFeaturesNV _internal)
    {
        PNext = _internal.pNext;
        TaskShader = _internal.taskShader;
        MeshShader = _internal.meshShader;
    }

    public StructureType SType => StructureType.PhysicalDeviceMeshShaderFeaturesNv;
    public void* PNext { get; set; }
    public VkBool32 TaskShader { get; set; }
    public VkBool32 MeshShader { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceMeshShaderFeaturesNV ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceMeshShaderFeaturesNV();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.taskShader = TaskShader;
        _internal.meshShader = MeshShader;
        return _internal;
    }

    public static implicit operator PhysicalDeviceMeshShaderFeaturesNV(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceMeshShaderFeaturesNV p)
    {
        return new PhysicalDeviceMeshShaderFeaturesNV(p);
    }

}


