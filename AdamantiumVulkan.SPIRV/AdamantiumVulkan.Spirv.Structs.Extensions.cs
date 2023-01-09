using AdamantiumVulkan.Spirv.Interop;

namespace AdamantiumVulkan.Spirv.Cross.Interop;

public unsafe partial struct SpvcBool
{
    public SpvcBool(bool val)
    {
        value = (byte)(val ? 1 : 0);
    }
    
    public static implicit operator bool(SpvcBool val)
    {
        return val.value != 0;
    }
    
    public static implicit operator SpvcBool(bool val)
    {
        return new SpvcBool(val);
    }
}

public unsafe partial struct SpvcVariableId
{
    public static implicit operator SpvId(SpvcVariableId id)
    {
        return id.value;
    }
}