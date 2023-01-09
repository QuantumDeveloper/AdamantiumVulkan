namespace AdamantiumVulkan.Core.Interop;

public unsafe partial struct VkBool32 
{
    public VkBool32(bool val)
    {
        value = val ? 1U : 0;
    }
    
    public static implicit operator bool(VkBool32 vkBool)
    {
        return vkBool.value != 0;
    }

    public static implicit operator VkBool32(bool value)
    {
        return new VkBool32(value);
    }
}