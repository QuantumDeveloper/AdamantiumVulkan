using System;
using System.Runtime.InteropServices;

namespace AdamantiumVulkan
{
    public class VulkanInteropException : Exception
    {
        public VulkanInteropException(string message) : base(message)
        {
        }
    }
}
