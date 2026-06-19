using System;
using System.Runtime.Serialization;

namespace Adamantium.Vulkan.Spirv;

public class SpirvResultException : Exception
{
    public SpirvResultException()
    {

    }

    public SpirvResultException(string message) : base(message)
    {

    }

    public SpirvResultException(string message, Exception innerException) : base(message, innerException)
    {

    }

    public SpirvResultException(SerializationInfo info, StreamingContext context) : base(info, context)
    {

    }
}