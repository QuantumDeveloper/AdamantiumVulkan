namespace AdamantiumVulkan.SPIRV.Cross
{
    public class ShaderResourceMember
    {
        public string Name { get; internal set; }

        public uint Offset { get; internal set; }

        public ulong Size { get; internal set; }

        public uint ArrayStride { get; internal set; }

        public uint MatrixStride { get; internal set; }

        public uint TypeId { get; internal set; }
    }
}
