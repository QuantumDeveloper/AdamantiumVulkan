using System;

namespace Adamantium.Vulkan.Loader
{
    public class MissingLibraryNameException : Exception
    {
        public MissingLibraryNameException(string message) : base(message)
        {
        }
    }
}
