// ----------------------------------------------------------------------------------------------
// <auto-generated>
// This file was autogenerated by QuantumBindingGenerator.
// Do not edit this file manually, because you will lose all your changes after next generation.
// </auto-generated>
// ----------------------------------------------------------------------------------------------


namespace AdamantiumVulkan.MacOS
{
    using System.Runtime.InteropServices;
    using AdamantiumVulkan;
    using AdamantiumVulkan.Core;
    using AdamantiumVulkan.MacOS.Interop;

    public partial class MacOSSurfaceCreateInfoMVK : DisposableObject
    {
        public MacOSSurfaceCreateInfoMVK()
        {
        }

        public MacOSSurfaceCreateInfoMVK(AdamantiumVulkan.MacOS.Interop.VkMacOSSurfaceCreateInfoMVK _internal)
        {
            PNext = _internal.pNext;
            Flags = _internal.flags;
            PView = _internal.pView;
        }

        public StructureType SType => StructureType.MacosSurfaceCreateInfoMvk;
        public System.IntPtr PNext { get; set; }
        public uint Flags { get; set; }
        public System.IntPtr PView { get; set; }

        public AdamantiumVulkan.MacOS.Interop.VkMacOSSurfaceCreateInfoMVK ToInternal()
        {
            var _internal = new AdamantiumVulkan.MacOS.Interop.VkMacOSSurfaceCreateInfoMVK();
            _internal.sType = SType;
            _internal.pNext = PNext;
            _internal.flags = Flags;
            _internal.pView = PView;
            return _internal;
        }
    }


}