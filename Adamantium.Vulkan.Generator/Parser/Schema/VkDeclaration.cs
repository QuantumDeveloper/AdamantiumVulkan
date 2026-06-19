using System.Xml;

namespace Adamantium.Vulkan.Generator.Parser.Schema;

public class VkDeclaration
{
    public string Name { get; set; }
    public string Comment { get; set; }
    
    public IXmlLineInfo LineInfo { get; set; }
    
    public string CurrentFileName { get; set; }
}