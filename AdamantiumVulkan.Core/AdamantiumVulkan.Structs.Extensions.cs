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

    public static bool IsTrue(VkBool32 vkBool)
    {
        return vkBool.value != 0;
    }

    public override string ToString()
    {
        return $"{IsTrue(this)}";
    }

    public static VkBool32 TRUE => new VkBool32(true);
    
    public static VkBool32 FALSE => new VkBool32(false);
}