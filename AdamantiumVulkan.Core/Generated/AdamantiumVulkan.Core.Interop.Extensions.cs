namespace AdamantiumVulkan.Core.Interop
{
    public partial struct VkBool32
    {
        public static VkBool32 False => new VkBool32() { value = 0 };

        public static VkBool32 True => new VkBool32() { value = 1 };
    }
}