using System;
using System.Collections.Generic;
using System.Text;

namespace AdamantiumVulkan
{
    public class MissingLibraryNameException : Exception
    {
        public MissingLibraryNameException(string message) : base(message)
        {
        }
    }
}
