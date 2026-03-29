using AdamantiumVulkan.Core;
using AdamantiumVulkan.Windows.Interop;
using QuantumBinding.Utils;

namespace AdamantiumVulkan.Windows
{
    public static partial class InstanceExtension
    {
        public static unsafe SurfaceKHR CreateWin32Surface(this Instance instance, Win32SurfaceCreateInfoKHR surfaceInfo, AllocationCallbacks allocator = null)
        {
            using var ctx = new NativeContext(surfaceInfo.GetSize(), stackalloc byte[(int)MarshalingUtils.StackAllocThreshold]);
            var native = surfaceInfo.MarshalToNative(ctx);
            var infoPtr = (VkWin32SurfaceCreateInfoKHR*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref native);
            var result = VulkanInterop.vkCreateWin32SurfaceKHR(instance, infoPtr, null, out var surfacePtr);
            ResultHelper.CheckResult(result, nameof(CreateWin32Surface));
            return new SurfaceKHR(surfacePtr);
        }
    }
}
