using AdamantiumVulkan.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdamantiumVulkan.Windows
{
    public static partial class InstanceExtension
    {
        public static SurfaceKHR CreateWin32Surface(this Instance instance, Win32SurfaceCreateInfoKHR surfaceInfo, AllocationCallbacks allocator = null)
        {
            var result = instance.CreateWin32SurfaceKHR(surfaceInfo, null, out var surface);
            ResultHelper.CheckResult(result, nameof(CreateWin32SurfaceKHR));
            return surface;
        }
    }
}
