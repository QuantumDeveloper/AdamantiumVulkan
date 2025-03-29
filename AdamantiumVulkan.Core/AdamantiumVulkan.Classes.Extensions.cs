using System;
using System.Runtime.InteropServices;
using AdamantiumVulkan.Core.Interop;
using QuantumBinding.Utils;

namespace AdamantiumVulkan.Core
{
    public unsafe partial class Instance 
    {
        public static LayerProperties[] EnumerateInstanceLayerProperties()
        {
            uint layersCount = 0;
            var result = VulkanNative.EnumerateInstanceLayerProperties(ref layersCount, null);
            ResultHelper.CheckResult(result, nameof(VulkanNative.EnumerateInstanceLayerProperties));

            LayerProperties[] layers = new LayerProperties[layersCount];
            result = VulkanNative.EnumerateInstanceLayerProperties(ref layersCount, layers);
            ResultHelper.CheckResult(result, nameof(VulkanNative.EnumerateInstanceLayerProperties));
            return layers;
        }

        public static ExtensionProperties[] EnumerateInstanceExtensionProperties(string layerName)
        {
            uint propertyCount = 0;
            var result = VulkanNative.EnumerateInstanceExtensionProperties(layerName, ref propertyCount, null);
            ResultHelper.CheckResult(result, nameof(VulkanNative.EnumerateInstanceExtensionProperties));

            ExtensionProperties[] properties = new ExtensionProperties[propertyCount];
            result = VulkanNative.EnumerateInstanceExtensionProperties(layerName, ref propertyCount, properties);
            ResultHelper.CheckResult(result, nameof(EnumeratePhysicalDevices));
            return properties;
        }

        public static ExtensionProperties[] EnumerateInstanceExtensionProperties()
        {
            uint extensionsCount = 0;
            var result = VulkanNative.EnumerateInstanceExtensionProperties(null, ref extensionsCount, null);
            ResultHelper.CheckResult(result, nameof(VulkanNative.EnumerateInstanceExtensionProperties));

            ExtensionProperties[] properties = new ExtensionProperties[extensionsCount];
            result = VulkanNative.EnumerateInstanceExtensionProperties(null, ref extensionsCount, properties);
            ResultHelper.CheckResult(result, nameof(EnumeratePhysicalDevices));
            return properties;
        }

        public static Instance Create(in InstanceCreateInfo createInfo, in AllocationCallbacks allocator = null)
        {
            var result = VulkanNative.CreateInstance(createInfo, allocator, out var instance);
            ResultHelper.CheckResult(result, nameof(Create));
            return instance;
        }

        public uint PhysicalDeviceCount
        {
            get
            {
                if (IsDisposed) return 0;

                uint physicalDeviceCount = 0;
                var result = EnumeratePhysicalDevices(ref physicalDeviceCount, null);
                ResultHelper.CheckResult(result, nameof(EnumeratePhysicalDevices));
                return physicalDeviceCount;
            }
        }

        public PhysicalDevice[] EnumeratePhysicalDevices()
        {
            var physicalDeviceCount = PhysicalDeviceCount;
            PhysicalDevice[] pPhysicalDevices = new PhysicalDevice[physicalDeviceCount];
            var result = EnumeratePhysicalDevices(ref physicalDeviceCount, pPhysicalDevices);
            ResultHelper.CheckResult(result, nameof(EnumeratePhysicalDevices));

            return pPhysicalDevices;
        }
    }

    public static partial class InstanceExtension
    {
        public static SurfaceKHR CreateHeadlessSurface(this Instance instance, HeadlessSurfaceCreateInfoEXT surfaceInfo, AllocationCallbacks allocator = null)
        {
            var result = instance.CreateHeadlessSurfaceEXT(surfaceInfo, null, out var surface);
            ResultHelper.CheckResult(result, nameof(CreateHeadlessSurface));
            return surface;
        }
    }

    public partial class PhysicalDevice
    {
        public PhysicalDeviceMemoryProperties GetPhysicalDeviceMemoryProperties()
        {
            GetPhysicalDeviceMemoryProperties(out var memoryProperties);
            return memoryProperties;
        }

        public PhysicalDeviceProperties GetPhysicalDeviceProperties()
        {
            GetPhysicalDeviceProperties(out var deviceProperties);
            return deviceProperties;
        }

        public QueueFamilyProperties[] GetQueueFamilyProperties()
        {
            uint queueFamilyCount = 0;
            GetPhysicalDeviceQueueFamilyProperties(ref queueFamilyCount, null);

            var queueFamilies = new QueueFamilyProperties[queueFamilyCount];
            GetPhysicalDeviceQueueFamilyProperties(ref queueFamilyCount, queueFamilies);

            return queueFamilies;
        }

        public PhysicalDeviceFeatures GetPhysicalDeviceFeatures()
        {
            GetPhysicalDeviceFeatures(out var deviceFeatures);
            ClearPhysicalDeviceFeatures(deviceFeatures);
            return deviceFeatures;
        }

        public Device CreateDevice(DeviceCreateInfo createInfo, AllocationCallbacks allocator = null)
        {
            var result = CreateDevice(createInfo, null, out var logicalDevice);
            ResultHelper.CheckResult(result, nameof(CreateDevice));
            return logicalDevice;
        }

        public SurfaceCapabilitiesKHR GetPhysicalDeviceSurfaceCapabilitiesKHR(SurfaceKHR surface)
        {
            var result = GetPhysicalDeviceSurfaceCapabilitiesKHR(surface, out var surfaceCapabilities);
            ResultHelper.CheckResult(result, nameof(GetPhysicalDeviceSurfaceCapabilitiesKHR));
            return surfaceCapabilities;
        }

        public SurfaceFormatKHR[] GetPhysicalDeviceSurfaceFormatsKHR(SurfaceKHR surface)
        {
            uint formatCount = 0;
            var result = GetPhysicalDeviceSurfaceFormatsKHR(surface, ref formatCount, null);
            ResultHelper.CheckResult(result, nameof(GetPhysicalDeviceSurfaceFormatsKHR));

            if (formatCount != 0)
            {
                var formats = new SurfaceFormatKHR[formatCount];
                result = GetPhysicalDeviceSurfaceFormatsKHR(surface, ref formatCount, formats);
                ResultHelper.CheckResult(result, nameof(GetPhysicalDeviceSurfaceFormatsKHR));
                return formats;
            }

            return new SurfaceFormatKHR[0];
        }

        public PresentModeKHR[] GetPhysicalDeviceSurfacePresentModesKHR(SurfaceKHR surface)
        {
            uint presentModeCount = 0;
            var result = GetPhysicalDeviceSurfacePresentModesKHR(surface, ref presentModeCount, null);
            ResultHelper.CheckResult(result, nameof(GetPhysicalDeviceSurfacePresentModesKHR));

            if (presentModeCount != 0)
            {
                var presentModes = new PresentModeKHR[presentModeCount];
                result = GetPhysicalDeviceSurfacePresentModesKHR(surface, ref presentModeCount, presentModes);
                ResultHelper.CheckResult(result, nameof(GetPhysicalDeviceSurfacePresentModesKHR));
                return presentModes;
            }

            return Array.Empty<PresentModeKHR>();
        }

        public uint FindCorrespondingMemoryType(uint typeFilter, MemoryPropertyFlagBits properties)
        {
            var memProperties = GetPhysicalDeviceMemoryProperties();

            for (uint i = 0; i < memProperties.MemoryTypeCount; i++)
            {
                var shift = 1 << (int)i;
                if ((typeFilter & shift) > 0 && 
                    (memProperties.MemoryTypes[i].PropertyFlags).HasFlag(properties))
                {
                    return i;
                }
            }

            throw new Exception("failed to find suitable memory type!");
        }

        private void ClearPhysicalDeviceFeatures(PhysicalDeviceFeatures deviceFeatures)
        {
            deviceFeatures.RobustBufferAccess = VkBool32.FALSE;
            deviceFeatures.FullDrawIndexUint32 = VkBool32.FALSE;                    
            deviceFeatures.ImageCubeArray = VkBool32.FALSE;                         
            deviceFeatures.IndependentBlend = VkBool32.FALSE;                       
            deviceFeatures.GeometryShader = VkBool32.FALSE;                         
            deviceFeatures.TessellationShader = VkBool32.FALSE;                     
            deviceFeatures.SampleRateShading = VkBool32.FALSE;                      
            deviceFeatures.DualSrcBlend = VkBool32.FALSE;                           
            deviceFeatures.LogicOp = VkBool32.FALSE;                                
            deviceFeatures.MultiDrawIndirect = VkBool32.FALSE;                      
            deviceFeatures.DrawIndirectFirstInstance = VkBool32.FALSE;              
            deviceFeatures.DepthClamp = VkBool32.FALSE;                             
            deviceFeatures.DepthBiasClamp = VkBool32.FALSE;                         
            deviceFeatures.FillModeNonSolid = VkBool32.FALSE;                       
            deviceFeatures.DepthBounds = VkBool32.FALSE;                            
            deviceFeatures.WideLines = VkBool32.FALSE;                              
            deviceFeatures.LargePoints = VkBool32.FALSE;                            
            deviceFeatures.AlphaToOne = VkBool32.FALSE;                             
            deviceFeatures.MultiViewport = VkBool32.FALSE;                          
            deviceFeatures.SamplerAnisotropy = VkBool32.FALSE;                      
            deviceFeatures.TextureCompressionETC2 = VkBool32.FALSE;                 
            deviceFeatures.TextureCompressionASTC_LDR = VkBool32.FALSE;             
            deviceFeatures.TextureCompressionBC = VkBool32.FALSE;                   
            deviceFeatures.OcclusionQueryPrecise = VkBool32.FALSE;                  
            deviceFeatures.PipelineStatisticsQuery = VkBool32.FALSE;                
            deviceFeatures.VertexPipelineStoresAndAtomics = VkBool32.FALSE;         
            deviceFeatures.FragmentStoresAndAtomics = VkBool32.FALSE;              
            deviceFeatures.ShaderTessellationAndGeometryPointSize = VkBool32.FALSE; 
            deviceFeatures.ShaderImageGatherExtended = VkBool32.FALSE;              
            deviceFeatures.ShaderStorageImageExtendedFormats = VkBool32.FALSE;     
            deviceFeatures.ShaderStorageImageMultisample = VkBool32.FALSE;      
            deviceFeatures.ShaderStorageImageReadWithoutFormat = VkBool32.FALSE;
            deviceFeatures.ShaderStorageImageWriteWithoutFormat = VkBool32.FALSE;
            deviceFeatures.ShaderUniformBufferArrayDynamicIndexing = VkBool32.FALSE;
            deviceFeatures.ShaderSampledImageArrayDynamicIndexing = VkBool32.FALSE;
            deviceFeatures.ShaderStorageBufferArrayDynamicIndexing = VkBool32.FALSE;
            deviceFeatures.ShaderStorageImageArrayDynamicIndexing = VkBool32.FALSE;
            deviceFeatures.ShaderClipDistance = VkBool32.FALSE;               
            deviceFeatures.ShaderCullDistance = VkBool32.FALSE;
            deviceFeatures.ShaderFloat64 = VkBool32.FALSE;                          
            deviceFeatures.ShaderInt64 = VkBool32.FALSE;
            deviceFeatures.ShaderInt16 = VkBool32.FALSE;                            
            deviceFeatures.ShaderResourceResidency = VkBool32.FALSE;                
            deviceFeatures.ShaderResourceMinLod = VkBool32.FALSE;                   
            deviceFeatures.SparseBinding = VkBool32.FALSE;                        
            deviceFeatures.SparseResidencyBuffer = VkBool32.FALSE;                  
            deviceFeatures.SparseResidencyImage2D = VkBool32.FALSE;                 
            deviceFeatures.SparseResidencyImage3D = VkBool32.FALSE;                 
            deviceFeatures.SparseResidency2Samples = VkBool32.FALSE;               
            deviceFeatures.SparseResidency4Samples = VkBool32.FALSE;               
            deviceFeatures.SparseResidency8Samples = VkBool32.FALSE;               
            deviceFeatures.SparseResidency16Samples = VkBool32.FALSE;               
            deviceFeatures.SparseResidencyAliased = VkBool32.FALSE;                 
            deviceFeatures.VariableMultisampleRate = VkBool32.FALSE;                
            deviceFeatures.InheritedQueries = VkBool32.FALSE;                     
        }

        public Result GetPhysicalDeviceSurfaceSupport(uint queueFamilyIndex, SurfaceKHR surface, out bool pSupported)
        {
            var result = GetPhysicalDeviceSurfaceSupportKHR(queueFamilyIndex, surface, out var supported);
            pSupported = (VkBool32)supported;
            return result;
        }
    }

    public unsafe partial class Device
    {
        protected PFN_vkCreateShadersEXT CreateShadersDelegate { get; private set; }
        
        protected PFN_vkCmdBindShadersEXT BindShadersDelegate { get; private set; }

        protected PFN_vkGetDescriptorSetLayoutSizeEXT DescriptorSetLayoutSizeDelegate { get; private set; }
        
        protected PFN_vkGetDescriptorSetLayoutBindingOffsetEXT DescriptorSetLayoutOffsetDelegate { get; private set; }
        
        protected PFN_vkGetDescriptorEXT GetDescriptorDelegate { get; private set; }
        
        protected PFN_vkCmdBindDescriptorBuffersEXT BindDescriptorBuffersDelegate { get; private set; }
        
        protected PFN_vkCmdSetDescriptorBufferOffsetsEXT SetDescriptorBufferOffsetsDelegate { get; private set; }
        
        protected PFN_vkCmdSetViewportWithCountEXT SetViewportWithCountDelegate { get; private set; }
        
        protected PFN_vkCmdSetScissorWithCountEXT SetScissorWithCountDelegate { get; private set; }
        
        protected PFN_vkCmdSetRasterizerDiscardEnableEXT SetRasterizerDiscardEnableDelegate { get; private set; }
        protected PFN_vkCmdSetColorBlendEquationEXT SetColorBlendEquationDelegate { get; private set; }
        
        protected PFN_vkCmdSetVertexInputEXT SetVertexInputDelegate { get; private set; }
        protected PFN_vkCmdSetPrimitiveTopologyEXT SetPrimitiveTopologyDelegate { get; private set; }
        protected PFN_vkCmdSetPrimitiveRestartEnableEXT SetPrimitiveRestartEnableDelegate { get; private set; }
        protected PFN_vkCmdSetRasterizationSamplesEXT SetRasterizationSamplesDelegate { get; private set; }
        protected PFN_vkCmdSetSampleMaskEXT SetSampleMaskDelegate { get; private set; }
        protected PFN_vkCmdSetAlphaToCoverageEnableEXT SetAlphaToCoverageDelegate { get; private set; }
        protected PFN_vkCmdSetAlphaToOneEnableEXT SetAlphaToOneDelegate { get; private set; }
        protected PFN_vkCmdSetPolygonModeEXT SetPolygonModeDelegate { get; private set; }
        protected PFN_vkCmdSetFrontFaceEXT SetFrontFaceDelegate { get; private set; }
        protected PFN_vkCmdSetCullModeEXT SetCullModeDelegate { get; private set; }
        
        protected PFN_vkCmdSetDepthWriteEnableEXT SetDepthWriteEnableDelegate { get; private set; }
        protected PFN_vkCmdSetDepthTestEnableEXT SetDepthTestEnableDelegate { get; private set; }
        protected PFN_vkCmdSetDepthCompareOpEXT SetDepthCompareOpDelegate { get; private set; }
        protected PFN_vkCmdSetDepthBoundsTestEnableEXT SetDepthBoundsTestEnableDelegate { get; private set; }
        protected PFN_vkCmdSetDepthBiasEnableEXT SetDepthBiasEnableDelegate { get; private set; }
        protected PFN_vkCmdSetStencilTestEnableEXT SetStencilTestEnableDelegate { get; private set; }
        protected PFN_vkCmdSetLogicOpEnableEXT SetLogicOpEnableDelegate { get; private set; }
        protected PFN_vkCmdSetColorBlendEnableEXT SetColorBlendEnableDelegate { get; private set; }
        protected PFN_vkCmdSetColorWriteMaskEXT SetColorWriteMaskDelegate { get; private set; }
        
        protected PFN_vkSetDebugUtilsObjectNameEXT SetDebugUtilsObjectNameDelegate { get; private set; }

        public void InitializeExtensions()
        {
            CreateShadersDelegate = (PFN_vkCreateShadersEXT)GetDeviceProcAddr("vkCreateShadersEXT");
            BindShadersDelegate = (PFN_vkCmdBindShadersEXT)GetDeviceProcAddr("vkCmdBindShadersEXT");
            DescriptorSetLayoutSizeDelegate =
                (PFN_vkGetDescriptorSetLayoutSizeEXT)GetDeviceProcAddr("vkGetDescriptorSetLayoutSizeEXT");
            DescriptorSetLayoutOffsetDelegate =
                (PFN_vkGetDescriptorSetLayoutBindingOffsetEXT)GetDeviceProcAddr(
                    "vkGetDescriptorSetLayoutBindingOffsetEXT");
            GetDescriptorDelegate = (PFN_vkGetDescriptorEXT)GetDeviceProcAddr("vkGetDescriptorEXT");
            BindDescriptorBuffersDelegate = (PFN_vkCmdBindDescriptorBuffersEXT)GetDeviceProcAddr("vkCmdBindDescriptorBuffersEXT");
            SetDescriptorBufferOffsetsDelegate = (PFN_vkCmdSetDescriptorBufferOffsetsEXT)GetDeviceProcAddr("vkCmdSetDescriptorBufferOffsetsEXT");
            SetViewportWithCountDelegate =
                (PFN_vkCmdSetViewportWithCountEXT)GetDeviceProcAddr("vkCmdSetViewportWithCountEXT");
            SetScissorWithCountDelegate = (PFN_vkCmdSetScissorWithCountEXT)GetDeviceProcAddr("vkCmdSetScissorWithCountEXT");
            SetRasterizerDiscardEnableDelegate =
                (PFN_vkCmdSetRasterizerDiscardEnableEXT)GetDeviceProcAddr("vkCmdSetRasterizerDiscardEnableEXT");
            SetColorBlendEquationDelegate =
                (PFN_vkCmdSetColorBlendEquationEXT)GetDeviceProcAddr("vkCmdSetColorBlendEquationEXT");

            SetVertexInputDelegate = (PFN_vkCmdSetVertexInputEXT)GetDeviceProcAddr("vkCmdSetVertexInputEXT");
            SetPrimitiveTopologyDelegate = (PFN_vkCmdSetPrimitiveTopologyEXT)GetDeviceProcAddr("vkCmdSetPrimitiveTopologyEXT");
            SetPrimitiveRestartEnableDelegate = (PFN_vkCmdSetPrimitiveRestartEnableEXT)GetDeviceProcAddr("vkCmdSetPrimitiveRestartEnableEXT");
            SetRasterizationSamplesDelegate =
                (PFN_vkCmdSetRasterizationSamplesEXT)GetDeviceProcAddr("vkCmdSetRasterizationSamplesEXT");
            SetSampleMaskDelegate = (PFN_vkCmdSetSampleMaskEXT)GetDeviceProcAddr("vkCmdSetSampleMaskEXT");
            SetAlphaToCoverageDelegate = (PFN_vkCmdSetAlphaToCoverageEnableEXT)GetDeviceProcAddr("vkCmdSetAlphaToCoverageEnableEXT");
            SetAlphaToOneDelegate = (PFN_vkCmdSetAlphaToOneEnableEXT)GetDeviceProcAddr("vkCmdSetAlphaToOneEnableEXT");
            SetPolygonModeDelegate = (PFN_vkCmdSetPolygonModeEXT)GetDeviceProcAddr("vkCmdSetPolygonModeEXT");
            SetFrontFaceDelegate = (PFN_vkCmdSetFrontFaceEXT)GetDeviceProcAddr("vkCmdSetFrontFaceEXT");
            SetCullModeDelegate = (PFN_vkCmdSetCullModeEXT)GetDeviceProcAddr("vkCmdSetCullModeEXT");
            SetDepthWriteEnableDelegate = (PFN_vkCmdSetDepthWriteEnableEXT)GetDeviceProcAddr("vkCmdSetDepthWriteEnableEXT");
            SetDepthTestEnableDelegate = (PFN_vkCmdSetDepthTestEnableEXT)GetDeviceProcAddr("vkCmdSetDepthTestEnableEXT");
            SetDepthCompareOpDelegate = (PFN_vkCmdSetDepthCompareOpEXT)GetDeviceProcAddr("vkCmdSetDepthCompareOpEXT");
            SetDepthBoundsTestEnableDelegate = (PFN_vkCmdSetDepthBoundsTestEnableEXT)GetDeviceProcAddr("vkCmdSetDepthBoundsTestEnableEXT");
            SetDepthBiasEnableDelegate = (PFN_vkCmdSetDepthBiasEnableEXT)GetDeviceProcAddr("vkCmdSetDepthBiasEnableEXT");
            SetStencilTestEnableDelegate = (PFN_vkCmdSetStencilTestEnableEXT)GetDeviceProcAddr("vkCmdSetStencilTestEnableEXT");
            SetLogicOpEnableDelegate = (PFN_vkCmdSetLogicOpEnableEXT)GetDeviceProcAddr("vkCmdSetLogicOpEnableEXT");
            SetColorBlendEnableDelegate = (PFN_vkCmdSetColorBlendEnableEXT)GetDeviceProcAddr("vkCmdSetColorBlendEnableEXT");
            SetColorWriteMaskDelegate = (PFN_vkCmdSetColorWriteMaskEXT)GetDeviceProcAddr("vkCmdSetColorWriteMaskEXT");
            
            SetDebugUtilsObjectNameDelegate = (PFN_vkSetDebugUtilsObjectNameEXT)GetDeviceProcAddr("vkSetDebugUtilsObjectNameEXT");
        }
        
        public Queue GetDeviceQueue(uint queueFamilyIndex, uint queueIndex)
        {
            GetDeviceQueue(queueFamilyIndex, queueIndex, out Queue queue);
            return queue;
        }

        public Queue GetDeviceQueue2(DeviceQueueInfo2 queueInfo)
        {
            GetDeviceQueue2(queueInfo, out Queue pQueue);
            return pQueue;
        }

        public SwapchainKHR CreateSwapchainKHR(SwapchainCreateInfoKHR createInfo, AllocationCallbacks allocator = null)
        {
            var result = CreateSwapchainKHR(createInfo, allocator, out SwapchainKHR swapchain);
            ResultHelper.CheckResult(result, nameof(CreateSwapchainKHR));
            return swapchain;
        }

        public Image[] GetSwapchainImagesKHR(SwapchainKHR swapchain)
        {
            uint imageCount = 0;
            var result = GetSwapchainImagesKHR(swapchain, ref imageCount, null);
            ResultHelper.CheckResult(result, nameof(GetSwapchainImagesKHR));

            var swapchainImages = new Image[imageCount];
            result = GetSwapchainImagesKHR(swapchain, ref imageCount, swapchainImages);
            ResultHelper.CheckResult(result, nameof(GetSwapchainImagesKHR));

            return swapchainImages;
        }

        public ImageView CreateImageView(ImageViewCreateInfo createInfo, AllocationCallbacks allocator = null)
        {
            var result = CreateImageView(createInfo, allocator, out ImageView view);
            ResultHelper.CheckResult(result, nameof(CreateImageView));
            return view;
        }

        public RenderPass CreateRenderPass(RenderPassCreateInfo createInfo, AllocationCallbacks allocator = null)
        {
            var result = CreateRenderPass(createInfo, allocator, out RenderPass renderPass);
            ResultHelper.CheckResult(result, nameof(CreateRenderPass));
            return renderPass;
        }

        public PipelineLayout CreatePipelineLayout(PipelineLayoutCreateInfo createInfo, AllocationCallbacks allocator = null)
        {
            var result = CreatePipelineLayout(createInfo, allocator, out PipelineLayout pipelineLayout);
            ResultHelper.CheckResult(result, nameof(CreatePipelineLayout));
            return pipelineLayout;
        }

        public Pipeline[] CreateGraphicsPipelines(PipelineCache pipelineCache, uint createInfoCount, GraphicsPipelineCreateInfo createInfos, AllocationCallbacks allocator = null)
        {
            var result = CreateGraphicsPipelines(pipelineCache, createInfoCount, createInfos, allocator, out Pipeline[] pipelines);
            ResultHelper.CheckResult(result, nameof(CreateGraphicsPipelines));
            return pipelines;
        }

        public Pipeline[] CreateComputePipelines(PipelineCache pipelineCache, uint createInfoCount, ComputePipelineCreateInfo createInfos, AllocationCallbacks allocator = null)
        {
            var result = CreateComputePipelines(pipelineCache, createInfoCount, createInfos, allocator, out Pipeline[] pipelines);
            ResultHelper.CheckResult(result, nameof(CreateComputePipelines));
            return pipelines;
        }

        public Framebuffer CreateFramebuffer(FramebufferCreateInfo createInfo, AllocationCallbacks allocator = null)
        {
            var result = CreateFramebuffer(createInfo, allocator, out Framebuffer framebuffer);
            ResultHelper.CheckResult(result, nameof(CreateFramebuffer));
            return framebuffer;
        }

        public CommandPool CreateCommandPool(CommandPoolCreateInfo createInfo, AllocationCallbacks allocator = null)
        {
            var result = CreateCommandPool(createInfo, allocator, out CommandPool commandPool);
            ResultHelper.CheckResult(result, nameof(CreateCommandPool));
            return commandPool;
        }

        public Buffer CreateBuffer(BufferCreateInfo createInfo, AllocationCallbacks allocator = null)
        {
            var result = CreateBuffer(createInfo, allocator, out Buffer buffer);
            ResultHelper.CheckResult(result, nameof(CreateBuffer));
            return buffer;
        }

        public MemoryRequirements GetBufferMemoryRequirements(Buffer buffer)
        {
            GetBufferMemoryRequirements(buffer, out MemoryRequirements memoryRequirements);
            return memoryRequirements;
        }

        public DeviceMemory AllocateMemory(MemoryAllocateInfo allocateInfo, AllocationCallbacks allocator = null)
        {
            var result = AllocateMemory(allocateInfo, allocator, out DeviceMemory deviceMemory);
            ResultHelper.CheckResult(result, nameof(AllocateMemory));
            return deviceMemory;
        }

        public void* MapMemory(DeviceMemory memory, ulong offset, ulong size, uint flags)
        {
            var result = MapMemory(memory, offset, size, flags, out var data);
            ResultHelper.CheckResult(result, nameof(MapMemory));
            return data;
        }

        public CommandBuffer[] AllocateCommandBuffers(CommandBufferAllocateInfo allocateInfo)
        {
            CommandBuffer[] commandBuffers = new CommandBuffer[allocateInfo.CommandBufferCount];
            var result = AllocateCommandBuffers(allocateInfo, commandBuffers);
            ResultHelper.CheckResult(result, nameof(AllocateCommandBuffers));
            return commandBuffers;
        }

        public Semaphore CreateSemaphore(SemaphoreCreateInfo createInfo, AllocationCallbacks allocator = null)
        {
            var result = CreateSemaphore(createInfo, allocator, out Semaphore semaphore);
            ResultHelper.CheckResult(result, nameof(CreateSemaphore));
            return semaphore;
        }

        public Semaphore[] CreateSemaphores(SemaphoreCreateInfo createInfo, uint semaphoreCount, AllocationCallbacks allocator = null)
        {
            if (semaphoreCount == 0)
            {
                throw new ArgumentOutOfRangeException("Semaphore count should be non-zero");
            }

            var semaphores = new Semaphore[semaphoreCount];
            for (int i = 0; i < semaphoreCount; ++i)
            {
                semaphores[i] = CreateSemaphore(createInfo, allocator);
            }

            return semaphores;
        }

        public Fence CreateFence(FenceCreateInfo createInfo, AllocationCallbacks allocator = null)
        {
            var result = CreateFence(createInfo, allocator, out Fence fence);
            ResultHelper.CheckResult(result, nameof(CreateFence));
            return fence;
        }

        public Fence[] CreateFences(FenceCreateInfo createInfo, uint fenceCount, AllocationCallbacks allocator = null)
        {
            if (fenceCount == 0)
            {
                throw new ArgumentOutOfRangeException("Fence count count should be non-zero");
            }

            var fences = new Fence[fenceCount];
            for (int i = 0; i < fenceCount; ++i)
            {
                fences[i] = CreateFence(createInfo, allocator);
            }

            return fences;
        }

        public ShaderModule CreateShaderModule(ShaderModuleCreateInfo createInfo, AllocationCallbacks allocator = null)
        {
            var result = CreateShaderModule(createInfo, allocator, out ShaderModule shaderModule);
            ResultHelper.CheckResult(result, nameof(CreateShaderModule));
            return shaderModule;
        }

        public CommandBuffer BeginSingleTimeCommand(CommandPool commandPool)
        {
            var allocInfo = new CommandBufferAllocateInfo();
            allocInfo.Level = CommandBufferLevel.Primary;
            allocInfo.CommandPool = commandPool;
            allocInfo.CommandBufferCount = 1;

            var commandBuffers = AllocateCommandBuffers(allocInfo);

            var beginInfo = new CommandBufferBeginInfo();
            beginInfo.Flags = CommandBufferUsageFlagBits.OneTimeSubmitBit;

            var commandBuffer = commandBuffers[0];
            commandBuffer.BeginCommandBuffer(beginInfo);

            return commandBuffer;
        }

        public void EndSingleTimeCommands(Queue queue, CommandPool commandPool, CommandBuffer commandBuffer)
        {
            commandBuffer.EndCommandBuffer();
            var fenceInfo = new FenceCreateInfo();
            var fence = CreateFence(fenceInfo);

            SubmitInfo submitInfo = new SubmitInfo();
            submitInfo.CommandBufferCount = 1;
            submitInfo.PCommandBuffers = new CommandBuffer[] {commandBuffer};

            var submitInfoArray = new SubmitInfo[1];
            submitInfoArray[0] = submitInfo;
            queue.QueueSubmit(1, submitInfoArray, fence);
            WaitForFences(1, fence, true, ulong.MaxValue);
            
            FreeCommandBuffers(commandPool, 1, commandBuffer);
            DestroyFence(fence);
        }

        public DescriptorSetLayout CreateDescriptorSetLayout(DescriptorSetLayoutCreateInfo layoutInfo, AllocationCallbacks allocator = null)
        {
            var result = CreateDescriptorSetLayout(layoutInfo, null, out var descriptorSetLayout);
            ResultHelper.CheckResult(result, nameof(CreateDescriptorSetLayout));
            return descriptorSetLayout;
        }

        public DescriptorPool CreateDescriptorPool(DescriptorPoolCreateInfo descriptorPoolInfo, AllocationCallbacks allocator = null)
        {
            var result = CreateDescriptorPool(descriptorPoolInfo, null, out var descriptorPool);
            ResultHelper.CheckResult(result, nameof(CreateDescriptorPool));
            return descriptorPool;
        }
        
        public ShaderEXT CreateShader(ShaderCreateInfoEXT createInfo, AllocationCallbacks allocator = null)
        {
            VkShaderCreateInfoEXT* createInfoPtr = NativeUtils.StructOrEnumToPointer(createInfo.ToNative());
            var shaders = new VkShaderEXT_T[1];
            var arrayPtr = NativeUtils.ManagedArrayToPointer(shaders);
            var result = CreateShadersDelegate.Invoke(this, 1, createInfoPtr, null, arrayPtr);
            ResultHelper.CheckResult(result, nameof(CreateShader));
            shaders = NativeUtils.PointerToManagedArray(arrayPtr, 1);
            return shaders[0];
        }
        
        public ShaderEXT[] CreateShaders(ShaderCreateInfoEXT[] createInfo, AllocationCallbacks allocator = null)
        {
            VkShaderCreateInfoEXT[] nativeCreateInfo = new VkShaderCreateInfoEXT[createInfo.Length];
            for (int i = 0; i < createInfo.Length; i++)
            {
                nativeCreateInfo[i] = createInfo[i].ToNative();
            }
            VkShaderCreateInfoEXT* createInfoPtr = NativeUtils.ManagedArrayToPointer(nativeCreateInfo);
            var nativeShaders = new VkShaderEXT_T[createInfo.Length];
            var arrayPtr = NativeUtils.ManagedArrayToPointer(nativeShaders);
            var result = CreateShadersDelegate.Invoke(this, (uint)createInfo.Length, createInfoPtr, null, arrayPtr);
            ResultHelper.CheckResult(result, nameof(CreateShader));
            nativeShaders = NativeUtils.PointerToManagedArray(arrayPtr, (uint)createInfo.Length);
            ShaderEXT[] shaders = new ShaderEXT[createInfo.Length];
            for (int i = 0; i < createInfo.Length; i++)
            {
                shaders[i] = nativeShaders[i];
            }
            return shaders;
        }

        public void BindShader(CommandBuffer cmd, ShaderStageFlagBits stage, ShaderEXT shader)
        {
            var stagePtr = NativeUtils.StructOrEnumToPointer(stage);
            VkShaderEXT_T* shadersPtr = NativeUtils.ManagedArrayToPointer(new VkShaderEXT_T[] { shader });
            BindShadersDelegate.Invoke(cmd, 1, stagePtr, shadersPtr);
            NativeUtils.Free(stagePtr);
            NativeUtils.Free(shadersPtr);
        }

        public uint GetDescriptorSetLayoutSize(DescriptorSetLayout layout)
        {
            DescriptorSetLayoutSizeDelegate.Invoke(this, layout, out var deviceSize);
            return (uint)deviceSize;
        }
        
        public uint GetDescriptorSetLayoutOffset(DescriptorSetLayout layout, uint bindingSlot)
        {
            DescriptorSetLayoutOffsetDelegate.Invoke(this, layout, bindingSlot, out var offsetSize);
            return (uint)offsetSize;
        }

        public void GetDescriptor(DescriptorGetInfoEXT descriptorInfo, uint descriptorSize, void* descriptorPtr)
        {
            var infoPtr = NativeUtils.StructOrEnumToPointer(descriptorInfo.ToNative()); 
            GetDescriptorDelegate.Invoke(this, infoPtr, descriptorSize, descriptorPtr);
            NativeMemory.Free(infoPtr);
            descriptorInfo?.Dispose();
        }
        
        public void BindDescriptorBuffers(CommandBuffer commandBuffer, DescriptorBufferBindingInfoEXT[] bindingInfos)
        {
            var infos = new VkDescriptorBufferBindingInfoEXT[bindingInfos.Length];
            for (int i = 0; i < bindingInfos.Length; i++)
            {
                infos[i] = bindingInfos[i].ToNative();
            }
            var arrayPtr = NativeUtils.ManagedArrayToPointer(infos); 
            BindDescriptorBuffersDelegate.Invoke(commandBuffer, (uint)bindingInfos.Length, arrayPtr);
            NativeMemory.Free(arrayPtr);
        }

        public void SetDescriptorBufferOffsets(CommandBuffer commandBuffer, PipelineBindPoint bindPoint, PipelineLayout layout, uint firstSet, uint setCount, uint[] bufferIndices, ulong[] offsets)
        {
            uint* indicesPtr = NativeUtils.ManagedArrayToPointer(bufferIndices);
            var offsetsPtr = NativeUtils.ManagedArrayToPointer(offsets);
            SetDescriptorBufferOffsetsDelegate.Invoke(commandBuffer, bindPoint, layout, firstSet, setCount, indicesPtr, offsetsPtr);
            NativeMemory.Free(indicesPtr);
            NativeMemory.Free(offsetsPtr);
        }

        public void SetViewportWithCountEXT(CommandBuffer commandBuffer, params Viewport[] viewports)
        {
            if (viewports == null) return;
            
            var vkViewports = new VkViewport[viewports.Length];
            for (int i = 0; i < viewports.Length; i++)
            {
                vkViewports[i] = viewports[i].ToNative();
            }
            var nativeViewportsPtr = NativeUtils.ManagedArrayToPointer(vkViewports);
            SetViewportWithCountDelegate.Invoke(commandBuffer, (uint)viewports.Length, nativeViewportsPtr);
        }

        public void SetScissorsWithCountEXT(CommandBuffer commandBuffer, params Rect2D[] scissors)
        {
            if (scissors == null) return;
            
            var vkScissors = new VkRect2D[scissors.Length];
            for (int i = 0; i < scissors.Length; i++)
            {
                vkScissors[i] = scissors[i].ToNative();
            }
            var nativeScissorsPtr = NativeUtils.ManagedArrayToPointer(vkScissors);
            SetScissorWithCountDelegate.Invoke(commandBuffer, (uint)scissors.Length, nativeScissorsPtr);
        }

        public void SetRasterizerDiscardEnableEXT(CommandBuffer commandBuffer, bool value)
        {
            SetRasterizerDiscardEnableDelegate.Invoke(commandBuffer, value);
        }
        
        public void SetColorBlendEquationEXT(CommandBuffer commandBuffer, uint firstAttachment, uint attachmentCount, params ColorBlendEquationEXT[] colorBlendEquations)
        {
            if (colorBlendEquations == null) return;
            
            var items = new VkColorBlendEquationEXT[colorBlendEquations.Length];
            for (int i = 0; i < colorBlendEquations.Length; i++)
            {
                items[i] = colorBlendEquations[i].ToNative();
            }
            var nativePtr = NativeUtils.ManagedArrayToPointer(items);
            SetColorBlendEquationDelegate.Invoke(commandBuffer, firstAttachment, attachmentCount, nativePtr);
        }

        public void SetVertexInputEXT(CommandBuffer commandBuffer,
            uint vertexBindingDescriptionCount,
            in VertexInputBindingDescription2EXT pVertexBindingDescriptions,
            uint vertexAttributeDescriptionCount,
            params VertexInputAttributeDescription2EXT[] pVertexAttributeDescriptions)
        {
            var arg2 = ReferenceEquals(pVertexBindingDescriptions, null)
                ? null
                : NativeUtils.StructOrEnumToPointer(pVertexBindingDescriptions.ToNative());
            var arg4 = ReferenceEquals(pVertexAttributeDescriptions, null)
                ? null
                : NativeUtils.GetPointerToManagedArray<VkVertexInputAttributeDescription2EXT>(
                        vertexAttributeDescriptionCount);
            if (!ReferenceEquals(pVertexAttributeDescriptions, null))
            {
                for (var i = 0U; i < vertexAttributeDescriptionCount; ++i)
                {
                    arg4[i] = pVertexAttributeDescriptions[i].ToNative();
                }
            }

            SetVertexInputDelegate.Invoke(commandBuffer, 
                vertexBindingDescriptionCount, 
                arg2,
                vertexAttributeDescriptionCount, 
                arg4);

            pVertexBindingDescriptions?.Dispose();
            NativeUtils.Free(arg2);
            if (!ReferenceEquals(pVertexAttributeDescriptions, null))
            {
                for (var i = 0U; i < vertexAttributeDescriptionCount; ++i)
                {
                    pVertexAttributeDescriptions[i]?.Dispose();
                }
            }
        }

        public void SetPrimitiveTopologyEXT(CommandBuffer commandBuffer, PrimitiveTopology primitiveTopology)
        {
            SetPrimitiveTopologyDelegate.Invoke(commandBuffer, primitiveTopology);
        }

        public void SetPrimitiveRestartEnableEXT(CommandBuffer commandBuffer, bool value)
        {
            SetPrimitiveRestartEnableDelegate.Invoke(commandBuffer, value);
        }

        public void SetRasterizationSamplesEXT(CommandBuffer commandBuffer, SampleCountFlagBits sampleCount)
        {
            SetRasterizationSamplesDelegate.Invoke(commandBuffer, sampleCount);
        }

        public void SetSampleMaskEXT(CommandBuffer commandBuffer, SampleCountFlagBits sampleCount, VkSampleMask[] sampleMasks)
        {
            fixed (VkSampleMask* mask = &sampleMasks[0])
            {
                SetSampleMaskDelegate.Invoke(commandBuffer, sampleCount, mask);
            }
        }

        public void SetAlphaToCoverageEnableEXT(CommandBuffer commandBuffer, bool value)
        {
            SetAlphaToCoverageDelegate.Invoke(commandBuffer, value);
        }
        
        public void SetAlphaToOneEnableEXT(CommandBuffer commandBuffer, bool value)
        {
            SetAlphaToOneDelegate.Invoke(commandBuffer, value);
        }

        public void SetPolygonModeEXT(CommandBuffer commandBuffer, PolygonMode polygonMode)
        {
            SetPolygonModeDelegate.Invoke(commandBuffer, polygonMode);
        }
        
        public void SetCullModeEXT(CommandBuffer commandBuffer, CullModeFlagBits cullMode)
        {
            SetCullModeDelegate.Invoke(commandBuffer, cullMode);
        }

        public void SetFrontFaceEXT(CommandBuffer commandBuffer, FrontFace frontFace)
        {
            SetFrontFaceDelegate.Invoke(commandBuffer, frontFace);
        }
        
        public void SetDepthWriteEnableEXT(CommandBuffer commandBuffer, bool value)
        {
            SetDepthWriteEnableDelegate.Invoke(commandBuffer, value);
        }

        public void SetDepthTestEnableEXT(CommandBuffer commandBuffer, bool value)
        {
            SetDepthTestEnableDelegate.Invoke(commandBuffer, value);
        }
        
        public void SetDepthCompareOpEXT(CommandBuffer commandBuffer, CompareOp compareOp)
        {
            SetDepthCompareOpDelegate.Invoke(commandBuffer, compareOp);
        }
        
        public void SetDepthBoundsTestEnableEXT(CommandBuffer commandBuffer, bool value)
        {
            SetDepthBoundsTestEnableDelegate.Invoke(commandBuffer, value);
        }
        
        public void SetDepthBiasEnableEXT(CommandBuffer commandBuffer, bool value)
        {
            SetDepthBiasEnableDelegate.Invoke(commandBuffer, value);
        }
        
        public void SetStencilTestEnableEXT(CommandBuffer commandBuffer, bool value)
        {
            SetStencilTestEnableDelegate.Invoke(commandBuffer, value);
        }

        public void SetLogicOpEnableEXT(CommandBuffer commandBuffer, bool value)
        {
            SetLogicOpEnableDelegate.Invoke(commandBuffer, value);
        }

        public void SetColorBlendEnableEXT(CommandBuffer commandBuffer, bool value)
        {
            VkBool32 val = value;
            SetColorBlendEnableDelegate.Invoke(commandBuffer, 0, 1, &val);
        }
        
        public void SetColorWriteMaskEXT(CommandBuffer commandBuffer, ColorComponentFlagBits colorComponents)
        {
            SetColorWriteMaskDelegate.Invoke(commandBuffer, 0, 1, &colorComponents);
        }
        
        public Result SetObjectDebugNameEXT(ulong objectHandle, ObjectType objectType, string name)
        {
            var nameInfo = new DebugUtilsObjectNameInfoEXT();
            nameInfo.ObjectType = objectType;
            nameInfo.ObjectHandle = objectHandle;
            nameInfo.PObjectName = name;
            var infoPtr = NativeUtils.StructOrEnumToPointer(nameInfo.ToNative());
            var result = SetDebugUtilsObjectNameDelegate.Invoke(this, infoPtr);
            NativeUtils.Free(infoPtr);
            return result;
        }
    }

    public unsafe partial class Framebuffer
    {
        public void Destroy(Device device)
        {
            if (NativePointer == null) return;

            device.DestroyFramebuffer(this);
            __Instance.pointer = null;
        }
    }

    public unsafe partial class Image
    {
        public void Destroy(Device device)
        {
            if (NativePointer == null) return;

            device.DestroyImage(this);
            __Instance.pointer = null;
        }
    }

    public unsafe partial class ImageView
    {
        public void Destroy(Device device)
        {
            if (NativePointer == null) return;

            device.DestroyImageView(this);
            __Instance.pointer = null;
        }
    }

    public unsafe partial class Pipeline
    {
        public void Destroy(Device device)
        {
            if (NativePointer == null) return;

            device.DestroyPipeline(this);
            __Instance.pointer = null;
        }
    }

    public unsafe partial class SwapchainKHR
    {
        public void Destroy(Device device)
        {
            if (NativePointer == null) return;

            device.DestroySwapchainKHR(this);
            __Instance.pointer = null;
        }
    }

    public unsafe partial class DeviceMemory
    {
        public void FreeMemory(Device device)
        {
            if (NativePointer == null) return;

            device.FreeMemory(this);
            __Instance.pointer = null;
        }
    }

    public unsafe partial class Buffer
    {
        public void Destroy(Device device)
        {
            if (NativePointer == null) return;

            device.DestroyBuffer(this);
            __Instance.pointer = null;
        }
    }

    public unsafe partial class BufferView
    {
        public void Destroy(Device device)
        {
            if (NativePointer == null) return;

            device.DestroyBufferView(this);
            __Instance.pointer = null;
        }
    }

    public unsafe partial class DescriptorSetLayout
    {
        public void Destroy(Device device)
        {
            if (NativePointer == null) return;

            device.DestroyDescriptorSetLayout(this);
            __Instance.pointer = null;

        }
    }

    public unsafe partial class PipelineLayout
    {
        public void Destroy(Device device)
        {
            if (NativePointer == null) return;

            device.DestroyPipelineLayout(this);
            __Instance.pointer = null;

        }
    }

    public unsafe partial class ExtensionProperties
    {
        public override string ToString()
        {
            return $"{ExtensionName} : {SpecVersion}";
        }
    }
}
