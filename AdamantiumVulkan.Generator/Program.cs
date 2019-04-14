using QuantumBinding.Generator;
using System;

namespace AdamantiumVulkan.Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            QuantumBindingGenerator generator = new VulkanBindingGenerator();
            generator.Run();
        }
    }
}
