﻿using AdamantiumVulkan.SPIRV.Cross;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace AdamantiumVulkan.SPIRV.Reflection
{
    public class SpirvReflectionResult
    {
        private List<ShaderReflectionResource> resources; 

        public SpirvReflectionResult()
        {
            resources = new List<ShaderReflectionResource>();
        }
        
        public byte[] Bytecode { get; internal set; }

        public ReadOnlyCollection<ShaderReflectionResource> UniformBuffers => resources.Where(x=>x.Description.Class == SpvcResourceType.UniformBuffer).ToList().AsReadOnly(); // cBuffer (constant buffers)
        public ReadOnlyCollection<ShaderReflectionResource> Samplers => resources.Where(x => x.Description.Class == SpvcResourceType.SeparateSamplers).ToList().AsReadOnly(); // Samplers
        public ReadOnlyCollection<ShaderReflectionResource> Images => resources.Where(x => x.Description.Class == SpvcResourceType.SeparateImage || x.Description.Class == SpvcResourceType.SampledImage).ToList().AsReadOnly(); // Textures
        public ReadOnlyCollection<ShaderReflectionResource> StorageImages => resources.Where(x => x.Description.Class == SpvcResourceType.StorageImage).ToList().AsReadOnly(); // RWTextures
        public ReadOnlyCollection<ShaderReflectionResource> AccelerationStructures => resources.Where(x => x.Description.Class == SpvcResourceType.AccelerationStructure).ToList().AsReadOnly(); // RWBuffers
        public ReadOnlyCollection<ShaderReflectionResource> StorageBuffers => resources.Where(x => x.Description.Class == SpvcResourceType.StorageBuffer).ToList().AsReadOnly(); // StructuredBuffers

        public ReadOnlyCollection<ShaderReflectionResource> AllResources => resources.AsReadOnly();

        internal void AddShaderResource(ShaderReflectionResource resource)
        {
            if (!resources.Contains(resource))
            {
                resources.Add(resource);
            }
        }
    }
}
