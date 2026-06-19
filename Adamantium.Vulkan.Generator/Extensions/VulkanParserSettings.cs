using System.Collections.Generic;
using QuantumBinding.Generator;

namespace Adamantium.Vulkan.Generator.Extensions;

public class VulkanParserSettings
{
    public VulkanParserSettings(IList<NamespaceMapping> mappings, string[] allowedPlatforms)
    {
        AllowedPlatforms = new List<string>(allowedPlatforms);
        NamespaceMappings = new List<NamespaceMapping>(mappings);
        VideoExtensionsPath = "video.xml";
    }
    
    public IReadOnlyList<string> AllowedPlatforms { get; }
    
    public bool IncludeVideoExtensions { get; set; }
    
    public string VideoExtensionsPath { get; set; }
    
    public IReadOnlyList<NamespaceMapping> NamespaceMappings { get; }
}