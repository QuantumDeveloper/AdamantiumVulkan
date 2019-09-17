using AdamantiumVulkan.Core;

namespace AdamantiumVulkan.MacOS
{
    public static partial class InstanceExtension
    {
        public static SurfaceKHR CreateMacOSSurfaceMVK(this Instance instance, MacOSSurfaceCreateInfoMVK surfaceInfo, AllocationCallbacks allocator = null)
        {
            var result = instance.CreateMacOSSurfaceMVK(surfaceInfo, null, out var surface);
            ResultHelper.CheckResult(result, nameof(CreateMacOSSurfaceMVK));
            return surface;
        }
    }
}
