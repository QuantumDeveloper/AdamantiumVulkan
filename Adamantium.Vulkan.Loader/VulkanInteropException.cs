using System;

namespace Adamantium.Vulkan.Loader
{
    public class VulkanInteropException : Exception
    {
        public VulkanInteropException(string message) : base(message)
        {
        }
    }
}
