// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

namespace AdamantiumVulkan.Core.Interop
{
    using System;
    using System.Runtime.InteropServices;

    // File: C:\VulkanSDK\1.1.101.0\Include\vulkan/vulkan_core.h Line: 2786 Column: 15
    [StructLayout(LayoutKind.Explicit)]
    public partial struct ClearColorValue
    {
        [FieldOffset(0)]
        public unsafe fixed float float32[4];

        [FieldOffset(0)]
        public unsafe fixed int int32[4];

        [FieldOffset(0)]
        public unsafe fixed uint uint32[4];

    }

    // File: C:\VulkanSDK\1.1.101.0\Include\vulkan/vulkan_core.h Line: 2797 Column: 15
    [StructLayout(LayoutKind.Explicit)]
    public partial struct ClearValue
    {
        [FieldOffset(0)]
        public ClearColorValue color;

        [FieldOffset(0)]
        public ClearDepthStencilValue depthStencil;

    }


}
