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

public unsafe partial class RenderPassBeginInfo : QBDisposableObject
{
    private NativeStructArray<AdamantiumVulkan.Core.Interop.VkClearValue> pClearValues;

    public RenderPassBeginInfo()
    {
    }

    public RenderPassBeginInfo(AdamantiumVulkan.Core.Interop.VkRenderPassBeginInfo _internal)
    {
        PNext = _internal.pNext;
        RenderPass = new RenderPass(_internal.renderPass);
        Framebuffer = new Framebuffer(_internal.framebuffer);
        RenderArea = new Rect2D(_internal.renderArea);
        ClearValueCount = _internal.clearValueCount;
        PClearValues = new ClearValue[_internal.clearValueCount];
        var nativeTmpArray0 = NativeUtils.PointerToManagedArray(_internal.pClearValues, _internal.clearValueCount);
        for (int i = 0; i < nativeTmpArray0.Length; ++i)
        {
            PClearValues[i] = new ClearValue(nativeTmpArray0[i]);
        }
        NativeUtils.Free(_internal.pClearValues);
    }

    public StructureType SType => StructureType.RenderPassBeginInfo;
    public void* PNext { get; set; }
    public RenderPass RenderPass { get; set; }
    public Framebuffer Framebuffer { get; set; }
    public Rect2D RenderArea { get; set; }
    public uint ClearValueCount { get; set; }
    public ClearValue[] PClearValues { get; set; }

    public AdamantiumVulkan.Core.Interop.VkRenderPassBeginInfo ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkRenderPassBeginInfo();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.renderPass = RenderPass;
        _internal.framebuffer = Framebuffer;
        if (RenderArea != null)
        {
            _internal.renderArea = RenderArea.ToNative();
        }
        _internal.clearValueCount = ClearValueCount;
        pClearValues.Dispose();
        if (PClearValues != null)
        {
            var tmpArray0 = new AdamantiumVulkan.Core.Interop.VkClearValue[PClearValues.Length];
            for (int i = 0; i < PClearValues.Length; ++i)
            {
                tmpArray0[i] = PClearValues[i].ToNative();
            }
            pClearValues = new NativeStructArray<AdamantiumVulkan.Core.Interop.VkClearValue>(tmpArray0);
            _internal.pClearValues = pClearValues.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        pClearValues.Dispose();
    }


    public static implicit operator RenderPassBeginInfo(AdamantiumVulkan.Core.Interop.VkRenderPassBeginInfo r)
    {
        return new RenderPassBeginInfo(r);
    }

}



