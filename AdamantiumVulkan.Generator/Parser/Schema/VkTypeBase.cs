namespace AdamantiumVulkan.Generator.Parser.Schema;

public class VkTypeBase
{
    public string Name { get; set; }
    public string Type { get; set; }
    public string FullType { get; set; }
    public bool IsPointer { get; set; }
    public int PointerDepth { get; set; }
    public bool IsConst { get; set; }
    public string Len { get; set; }
    public string LenExpression { get; set; }
    public bool IsArray => !string.IsNullOrEmpty(Len) || !string.IsNullOrEmpty(LenExpression);
    public string Comment { get; set; }
    public virtual bool IsFixedArray => false;
    
    public override string ToString()
    {
        return $"{Type} {Name}";
    }
}