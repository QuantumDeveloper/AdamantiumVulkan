using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace AdamantiumVulkan
{
    public class ResultException : Exception
    {
        public ResultException()
        {

        }

        public ResultException(string message) : base(message)
        {

        }

        public ResultException(string message, Exception innerException) : base(message, innerException)
        {

        }

        public ResultException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
