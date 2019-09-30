using System;

namespace AdamantiumVulkan
{
    public class VulkanInteropException : Exception
    {
        public VulkanInteropException(string message) : base(message)
        {
        }
    }
}
