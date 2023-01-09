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

public unsafe partial class PhysicalDeviceShaderModuleIdentifierPropertiesEXT : QBDisposableObject
{
    public PhysicalDeviceShaderModuleIdentifierPropertiesEXT()
    {
    }

    public PhysicalDeviceShaderModuleIdentifierPropertiesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceShaderModuleIdentifierPropertiesEXT _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        ShaderModuleIdentifierAlgorithmUUID = NativeUtils.PointerToManagedArray(_internal.shaderModuleIdentifierAlgorithmUUID, 16);
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public byte[] ShaderModuleIdentifierAlgorithmUUID { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPhysicalDeviceShaderModuleIdentifierPropertiesEXT ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPhysicalDeviceShaderModuleIdentifierPropertiesEXT();
        _internal.sType = SType;
        _internal.pNext = PNext;
        if(ShaderModuleIdentifierAlgorithmUUID != null)
        {
            if (ShaderModuleIdentifierAlgorithmUUID.Length > 16)
                throw new System.ArgumentOutOfRangeException(nameof(ShaderModuleIdentifierAlgorithmUUID), "Array is out of bounds. Size should not be more than 16");

            NativeUtils.PrimitiveToFixedArray(_internal.shaderModuleIdentifierAlgorithmUUID, 16, ShaderModuleIdentifierAlgorithmUUID);
        }
        return _internal;
    }

    public static implicit operator PhysicalDeviceShaderModuleIdentifierPropertiesEXT(AdamantiumVulkan.Core.Interop.VkPhysicalDeviceShaderModuleIdentifierPropertiesEXT p)
    {
        return new PhysicalDeviceShaderModuleIdentifierPropertiesEXT(p);
    }

}



