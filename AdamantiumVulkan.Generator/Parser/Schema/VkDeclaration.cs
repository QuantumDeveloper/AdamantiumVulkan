using System.Xml;

namespace AdamantiumVulkan.Generator.Parser.Schema;

public class VkDeclaration
{
    public string Name { get; set; }
    public string Comment { get; set; }
    
    public IXmlLineInfo LineInfo { get; set; }
    
    public string CurrentFileName { get; set; }
}