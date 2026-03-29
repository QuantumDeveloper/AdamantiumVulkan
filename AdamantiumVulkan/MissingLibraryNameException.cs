using System;

namespace AdamantiumVulkan
{
    public class MissingLibraryNameException : Exception
    {
        public MissingLibraryNameException(string message) : base(message)
        {
        }
    }
}
