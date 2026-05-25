using System.Collections.Generic;
using QuantumBinding.Generator;

namespace AdamantiumVulkan.Generator.Extensions;

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