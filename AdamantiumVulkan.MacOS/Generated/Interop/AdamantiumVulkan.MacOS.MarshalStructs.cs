// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------

namespace AdamantiumVulkan.MacOS.Interop
{
    using System;
    using System.Runtime.InteropServices;
    using AdamantiumVulkan.Core;

    [StructLayout(LayoutKind.Sequential)]
    public partial struct VkMacOSSurfaceCreateFlagsMVK
    {
        public uint value;


        public static implicit operator uint(VkMacOSSurfaceCreateFlagsMVK v)
        {
            return v.value;
        }

        public static implicit operator VkMacOSSurfaceCreateFlagsMVK(uint v)
        {
            return new VkMacOSSurfaceCreateFlagsMVK(){value = v};
        }

    }

    [StructLayout(LayoutKind.Sequential)]
    public partial struct VkMacOSSurfaceCreateInfoMVK
    {
        public uint sType;

        public System.IntPtr pNext;

        public uint flags;

        public System.IntPtr pView;

    }


}

