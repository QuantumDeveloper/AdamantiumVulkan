using AdamantiumVulkan.SPIRV.Cross;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace AdamantiumVulkan.SPIRV.Reflection
{
    public class SpirvReflectionResult
    {
        private List<ShaderReflectionVariable> resources; 

        public SpirvReflectionResult()
        {
            resources = new List<ShaderReflectionVariable>();
        }
        
        public byte[] Bytecode { get; internal set; }

        public ReadOnlyCollection<ShaderReflectionVariable> UniformBuffers => resources.Where(x=>x.Class == SpvcResourceType.UniformBuffer).ToList().AsReadOnly(); // cBuffer (constant buffers)
        public ReadOnlyCollection<ShaderReflectionVariable> Samplers => resources.Where(x => x.Class == SpvcResourceType.SeparateSamplers).ToList().AsReadOnly(); // Samplers
        public ReadOnlyCollection<ShaderReflectionVariable> Images => resources.Where(x => x.Class == SpvcResourceType.SeparateImage || x.Class == SpvcResourceType.SampledImage).ToList().AsReadOnly(); // Textures
        public ReadOnlyCollection<ShaderReflectionVariable> StorageImages => resources.Where(x => x.Class == SpvcResourceType.StorageImage).ToList().AsReadOnly(); // RWTextures
        public ReadOnlyCollection<ShaderReflectionVariable> AccelerationStructures => resources.Where(x => x.Class == SpvcResourceType.AccelerationStructure).ToList().AsReadOnly(); // RWBuffers
        public ReadOnlyCollection<ShaderReflectionVariable> StorageBuffers => resources.Where(x => x.Class == SpvcResourceType.StorageBuffer).ToList().AsReadOnly(); // StructuredBuffers

        internal void AddShaderResource(ShaderReflectionVariable resource)
        {
            if (!resources.Contains(resource))
            {
                resources.Add(resource);
            }
        }
    }
}
