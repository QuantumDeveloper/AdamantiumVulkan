using AdamantiumVulkan.Core;
using AdamantiumVulkan.MacOS.Interop;
using QuantumBinding.Utils;

namespace AdamantiumVulkan.MacOS
{
    public static unsafe partial class InstanceExtension
    {
        public static SurfaceKHR CreateMacOSSurfaceMVK(this Instance instance, MacOSSurfaceCreateInfoMVK surfaceInfo, AllocationCallbacks allocator = null)
        {
            using var ctx = new NativeContext(surfaceInfo.GetSize(), stackalloc byte[(int)MarshalingUtils.StackAllocThreshold]);
            var native = surfaceInfo.MarshalToNative(ctx);
            var infoPtr = (VkMacOSSurfaceCreateInfoMVK*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref native);
            var result = VulkanInterop.vkCreateMacOSSurfaceMVK(instance, infoPtr, null, out var surface);
            ResultHelper.CheckResult(result, nameof(CreateMacOSSurfaceMVK));
            return surface;
        }
    }
}
