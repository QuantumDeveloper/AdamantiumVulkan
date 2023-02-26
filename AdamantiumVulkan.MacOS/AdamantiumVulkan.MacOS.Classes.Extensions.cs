using AdamantiumVulkan.Core;
using AdamantiumVulkan.MacOS.Interop;
using QuantumBinding.Utils;

namespace AdamantiumVulkan.MacOS
{
    public static unsafe partial class InstanceExtension
    {
        public static SurfaceKHR CreateMacOSSurfaceMVK(this Instance instance, MacOSSurfaceCreateInfoMVK surfaceInfo, AllocationCallbacks allocator = null)
        {
            var infoPtr = NativeUtils.StructOrEnumToPointer(surfaceInfo.ToNative());
            var result = VulkanInterop.vkCreateMacOSSurfaceMVK(instance, infoPtr, null, out var surface);
            ResultHelper.CheckResult(result, nameof(CreateMacOSSurfaceMVK));
            return surface;
        }
    }
}
