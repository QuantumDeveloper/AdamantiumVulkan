namespace AdamantiumVulkan.SPIRV.Cross
{
    public class ShaderReflectionResourceMember
    {
        public string Name { get; internal set; }

        public uint Offset { get; internal set; }

        public ulong Size { get; internal set; }

        public uint ArrayStride { get; internal set; }

        public uint MatrixStride { get; internal set; }

        public uint TypeId { get; internal set; }

        public SpvcBasetype Type { get; internal set; }

        public override string ToString()
        {
            return $"{Name}, Offset: {Offset}, Size = {Size}, ArrayStride = {ArrayStride}, MatrixStride = {MatrixStride}, TypeId = {TypeId}";
        }
    }
}
