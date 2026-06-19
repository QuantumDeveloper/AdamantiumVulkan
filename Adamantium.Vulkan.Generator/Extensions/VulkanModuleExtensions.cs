using Adamantium.Vulkan.Generator.Parser;
using QuantumBinding.Generator;

namespace Adamantium.Vulkan.Generator.Extensions;

public static class VulkanModuleExtensions
{
    public static Module WithVulkanXmlParser(this Module module, VulkanParserSettings settings)
    {
        var vulkanParser = new VulkanXmlParser(settings);
        module.MetadataProvider = vulkanParser;
        return module;
    }
}