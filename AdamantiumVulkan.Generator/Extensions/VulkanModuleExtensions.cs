using AdamantiumVulkan.Generator.Parser;
using QuantumBinding.Generator;

namespace AdamantiumVulkan.Generator.Extensions;

public static class VulkanModuleExtensions
{
    public static Module WithVulkanXmlParser(this Module module, VulkanParserSettings settings)
    {
        var vulkanParser = new VulkanXmlParser(settings);
        module.MetadataProvider = vulkanParser;
        return module;
    }
}