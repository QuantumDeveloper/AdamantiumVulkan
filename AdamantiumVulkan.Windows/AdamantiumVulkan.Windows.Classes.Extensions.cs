using AdamantiumVulkan.Core;
using AdamantiumVulkan.Core.Interop;
using AdamantiumVulkan.Windows.Interop;
using QuantumBinding.Utils;

namespace AdamantiumVulkan.Windows
{
    public static partial class InstanceExtension
    {
        public static unsafe SurfaceKHR CreateWin32Surface(this Instance instance, Win32SurfaceCreateInfoKHR surfaceInfo, AllocationCallbacks allocator = null)
        {
            var infoPtr = NativeUtils.StructOrEnumToPointer(surfaceInfo.ToNative());
            var result = VulkanInterop.vkCreateWin32SurfaceKHR(instance, infoPtr, null, out var surfacePtr);
            ResultHelper.CheckResult(result, nameof(CreateWin32Surface));
            return new SurfaceKHR(surfacePtr);
        }
    }
}
