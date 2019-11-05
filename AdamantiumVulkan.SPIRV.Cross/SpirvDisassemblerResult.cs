using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace AdamantiumVulkan.SPIRV.Cross
{
    public class SpirvDisassemblerResult
    {
        private List<ShaderReflectionResource> resources; 

        public SpirvDisassemblerResult()
        {
            resources = new List<ShaderReflectionResource>();
        }

        public ReadOnlyCollection<ShaderReflectionResource> UniformBuffers => resources.Where(x=>x.ResourceType == SpvcResourceType.UniformBuffer).ToList().AsReadOnly(); // cBuffer (constant buffers)
        public ReadOnlyCollection<ShaderReflectionResource> Samplers => resources.Where(x => x.ResourceType == SpvcResourceType.SeparateSamplers).ToList().AsReadOnly(); // Samplers
        public ReadOnlyCollection<ShaderReflectionResource> Images => resources.Where(x => x.ResourceType == SpvcResourceType.SeparateImage || x.ResourceType == SpvcResourceType.SampledImage).ToList().AsReadOnly(); // Textures
        public ReadOnlyCollection<ShaderReflectionResource> StorageImages => resources.Where(x => x.ResourceType == SpvcResourceType.StorageImage).ToList().AsReadOnly(); // RWTextures
        public ReadOnlyCollection<ShaderReflectionResource> AccelerationStructurs => resources.Where(x => x.ResourceType == SpvcResourceType.AccelerationStructure).ToList().AsReadOnly(); // RWBuffers
        public ReadOnlyCollection<ShaderReflectionResource> StorageBuffers => resources.Where(x => x.ResourceType == SpvcResourceType.StorageBuffer).ToList().AsReadOnly(); // StructuredBuffers

        internal void AddShaderResource(ShaderReflectionResource resource)
        {
            if (!resources.Contains(resource))
            {
                resources.Add(resource);
            }
        }
    }
}
