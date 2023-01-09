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

public unsafe partial class PresentInfoKHR : QBDisposableObject
{
    private NativeStructArray<VkSemaphore_T> pWaitSemaphores;

    private NativeStructArray<VkSwapchainKHR_T> pSwapchains;

    private NativeStructArray<uint> pImageIndices;

    private NativeStructArray<Result> pResults;

    public PresentInfoKHR()
    {
    }

    public PresentInfoKHR(AdamantiumVulkan.Core.Interop.VkPresentInfoKHR _internal)
    {
        PNext = _internal.pNext;
        WaitSemaphoreCount = _internal.waitSemaphoreCount;
        PWaitSemaphores = new Semaphore[_internal.waitSemaphoreCount];
        var nativeTmpArray0 = NativeUtils.PointerToManagedArray(_internal.pWaitSemaphores, _internal.waitSemaphoreCount);
        for (int i = 0; i < nativeTmpArray0.Length; ++i)
        {
            PWaitSemaphores[i] = new Semaphore(nativeTmpArray0[i]);
        }
        NativeUtils.Free(_internal.pWaitSemaphores);
        SwapchainCount = _internal.swapchainCount;
        PSwapchains = new SwapchainKHR[_internal.swapchainCount];
        var nativeTmpArray1 = NativeUtils.PointerToManagedArray(_internal.pSwapchains, _internal.swapchainCount);
        for (int i = 0; i < nativeTmpArray1.Length; ++i)
        {
            PSwapchains[i] = new SwapchainKHR(nativeTmpArray1[i]);
        }
        NativeUtils.Free(_internal.pSwapchains);
        PImageIndices = new uint[_internal.swapchainCount];
        PImageIndices = NativeUtils.PointerToManagedArray(_internal.pImageIndices, (long)_internal.swapchainCount);
        NativeUtils.Free(_internal.pImageIndices);
        PResults = NativeUtils.PointerToManagedArray(_internal.pResults, _internal.swapchainCount);
    }

    public StructureType SType => StructureType.PresentInfoKhr;
    public void* PNext { get; set; }
    public uint WaitSemaphoreCount { get; set; }
    public Semaphore[] PWaitSemaphores { get; set; }
    public uint SwapchainCount { get; set; }
    public SwapchainKHR[] PSwapchains { get; set; }
    public uint[] PImageIndices { get; set; }
    public Result[] PResults { get; set; }

    public AdamantiumVulkan.Core.Interop.VkPresentInfoKHR ToNative()
    {
        var _internal = new AdamantiumVulkan.Core.Interop.VkPresentInfoKHR();
        _internal.sType = SType;
        _internal.pNext = PNext;
        _internal.waitSemaphoreCount = WaitSemaphoreCount;
        pWaitSemaphores.Dispose();
        if (PWaitSemaphores != null)
        {
            var tmpArray0 = new AdamantiumVulkan.Core.Interop.VkSemaphore_T[PWaitSemaphores.Length];
            for (int i = 0; i < PWaitSemaphores.Length; ++i)
            {
                tmpArray0[i] = PWaitSemaphores[i];
            }
            pWaitSemaphores = new NativeStructArray<VkSemaphore_T>(tmpArray0);
            _internal.pWaitSemaphores = pWaitSemaphores.Handle;
        }
        _internal.swapchainCount = SwapchainCount;
        pSwapchains.Dispose();
        if (PSwapchains != null)
        {
            var tmpArray1 = new AdamantiumVulkan.Core.Interop.VkSwapchainKHR_T[PSwapchains.Length];
            for (int i = 0; i < PSwapchains.Length; ++i)
            {
                tmpArray1[i] = PSwapchains[i];
            }
            pSwapchains = new NativeStructArray<VkSwapchainKHR_T>(tmpArray1);
            _internal.pSwapchains = pSwapchains.Handle;
        }
        pImageIndices.Dispose();
        if (PImageIndices != null)
        {
            var tmpArray2 = new uint[PImageIndices.Length];
            for (int i = 0; i < PImageIndices.Length; ++i)
            {
                tmpArray2[i] = PImageIndices[i];
            }
            pImageIndices = new NativeStructArray<uint>(tmpArray2);
            _internal.pImageIndices = pImageIndices.Handle;
        }
        pResults.Dispose();
        if (PResults != null)
        {
            pResults = new NativeStructArray<Result>(PResults);
            _internal.pResults = pResults.Handle;
        }
        return _internal;
    }

    protected override void UnmanagedDisposeOverride()
    {
        pWaitSemaphores.Dispose();
        pSwapchains.Dispose();
        pImageIndices.Dispose();
        pResults.Dispose();
    }


    public static implicit operator PresentInfoKHR(AdamantiumVulkan.Core.Interop.VkPresentInfoKHR p)
    {
        return new PresentInfoKHR(p);
    }

}


