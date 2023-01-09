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

public unsafe partial class DeviceBufferMemoryRequirements : QBDisposableObject
{
    private NativeStruct<VkBufferCreateInfo> pCreateInfo;

    public DeviceBufferMemoryRequirements()
    {
    }

    public DeviceBufferMemoryRequirements(AdamantiumVulkan.Core.Interop.VkDeviceBufferMemoryRequirements _internal)
    {
        SType = _internal.sType;
        PNext = _internal.pNext;
        PCreateInfo = new BufferCreateInfo(*_internal.pCreateInfo);
        NativeUtils.Free(_internal.pCreateInfo);
    }

    public StructureType SType { get; set; }
    public void* PNext { get; set; }
    public BufferCreateInfo PCreateInfo { get; set; }

    public AdamantiumVulkan.Core.Interop.VkDeviceBufferMemoryRequirements ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkDeviceBufferMemoryRequirements();
        _internal.sType = SType;
        _internal.pNext = PNext;
        pCreateInfo.Dispose();
        if (PCreateInfo != null)
        {
            var struct0 = PCreateInfo.ToNative();
            pCreateInfo = new NativeStruct<VkBufferCreateInfo>(struct0);
            _internal.pCreateInfo = pCreateInfo.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        pCreateInfo.Dispose();
    }


    public static implicit operator DeviceBufferMemoryRequirements(AdamantiumVulkan.Core.Interop.VkDeviceBufferMemoryRequirements d)
    {
        return new DeviceBufferMemoryRequirements(d);
    }

}



