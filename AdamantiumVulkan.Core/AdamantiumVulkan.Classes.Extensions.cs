using System;
using AdamantiumVulkan.Core.Interop;

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
        public static SurfaceKHR CreateHeadlesSurface(this Instance instance, HeadlessSurfaceCreateInfoEXT surfaceInfo, AllocationCallbacks allocator = null)
        {
            var result = instance.CreateHeadlessSurfaceEXT(surfaceInfo, null, out var surface);
            ResultHelper.CheckResult(result, nameof(CreateHeadlesSurface));
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

        public Result GetPhysicalDeviceSurfaceSupport(uint queueFamilyIndex, AdamantiumVulkan.Core.SurfaceKHR surface, out bool pSupported)
        {
            var result = GetPhysicalDeviceSurfaceSupportKHR(queueFamilyIndex, surface, out var supported);
            pSupported = (VkBool32)supported;
            return result;
        }
    }

    public unsafe partial class Device
    {
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
            //void** data = default;
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

            SubmitInfo submitInfo = new SubmitInfo();
            submitInfo.CommandBufferCount = 1;
            submitInfo.PCommandBuffers = new CommandBuffer[] {commandBuffer};

            var submitInfoArray = new SubmitInfo[1];
            submitInfoArray[0] = submitInfo;
            queue.QueueSubmit(1, submitInfoArray, null);
            queue.QueueWaitIdle();

            FreeCommandBuffers(commandPool, 1, commandBuffer);
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
