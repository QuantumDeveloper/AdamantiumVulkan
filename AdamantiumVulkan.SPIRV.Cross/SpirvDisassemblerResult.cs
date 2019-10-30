using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AdamantiumVulkan.SPIRV.Cross
{
    public class SpirvDisassemblerResult
    {
        private List<ShaderResource> uniformBuffers; // cBuffer (constant buffer)
        private List<ShaderResource> samplers; // Sampler
        private List<ShaderResource> sampledImages; // Texture
        private List<ShaderResource> storageImages; // RWTexture
        private List<ShaderResource> uniformTexelBuffers; // Buffer
        private List<ShaderResource> storageTexelBuffers; // RWBuffer
        private List<ShaderResource> storageBuffers; // StructuredBuffer

        public SpirvDisassemblerResult()
        {
            uniformBuffers = new List<ShaderResource>();
            samplers = new List<ShaderResource>();
            sampledImages = new List<ShaderResource>();
            storageImages = new List<ShaderResource>();
            uniformTexelBuffers = new List<ShaderResource>();
            storageTexelBuffers = new List<ShaderResource>();
            storageBuffers = new List<ShaderResource>();
        }

        public ReadOnlyCollection<ShaderResource> UniformBuffers => uniformBuffers.AsReadOnly();
        public ReadOnlyCollection<ShaderResource> Samplers => samplers.AsReadOnly();
        public ReadOnlyCollection<ShaderResource> SampledImages => sampledImages.AsReadOnly();
        public ReadOnlyCollection<ShaderResource> StorageImages => storageImages.AsReadOnly();
        public ReadOnlyCollection<ShaderResource> UniformTexelBuffers => uniformTexelBuffers.AsReadOnly();
        public ReadOnlyCollection<ShaderResource> StorageTexelBuffers => storageTexelBuffers.AsReadOnly();
        public ReadOnlyCollection<ShaderResource> StorageBuffers => storageBuffers.AsReadOnly();

        internal void AddShaderResource(ShaderResource resource)
        {
            switch (resource.ResourceType)
            {
                case SpvcResourceType.UniformBuffer:
                    uniformBuffers.Add(resource);
                    break;
                case SpvcResourceType.SeparateSamplers:
                    samplers.Add(resource);
                    break;
                case SpvcResourceType.SampledImage:
                    sampledImages.Add(resource);
                    break;
            }
        }
    }
}
