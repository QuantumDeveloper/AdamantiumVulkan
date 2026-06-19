using QuantumBinding.Generator;

namespace Adamantium.Vulkan.Generator
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
