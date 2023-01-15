using AdamantiumVulkan.Core;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Buffer = AdamantiumVulkan.Core.Buffer;
using Image = AdamantiumVulkan.Core.Image;
using Semaphore = AdamantiumVulkan.Core.Semaphore;
using CoreInterop = AdamantiumVulkan.Core.Interop;
using System.Collections.Generic;
using AdamantiumVulkan.Windows;
using Constants = AdamantiumVulkan.Core.Constants;
using System.IO;
using System.Runtime.CompilerServices;
using Adamantium.DXC;
using Adamantium.Mathematics;
using AdamantiumVulkan;
using AdamantiumVulkan.Core.Interop;
using AdamantiumVulkan.Shaders;
using AdamantiumVulkan.Shaders.Interop;
using AdamantiumVulkan.Spirv;
using AdamantiumVulkan.Spirv.Cross;
using AdamantiumVulkan.Spirv.Cross.Interop;
using AdamantiumVulkan.Spirv.Reflection;
using QuantumBinding.Utils;
using ImageLayout = AdamantiumVulkan.Core.ImageLayout;
using Result = AdamantiumVulkan.Core.Result;
using ShadercIncludeResult = AdamantiumVulkan.Shaders.ShadercIncludeResult;

namespace VulkanEngineTestCore
{
    unsafe partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
        private static AdamantiumVulkan.Shaders.Interop.ShadercIncludeResult* ResolveInclude(void* user_data, sbyte* requested_source, int type, sbyte* requesting_source, ulong include_depth)
        {
            var content = File.ReadAllText(Path.Combine("shaders\\TerrainGenShaders\\", new string(requested_source)));
            ShadercIncludeResult result = new ShadercIncludeResult();
            result.Content = content;
            result.Content_length = (uint)result.Content.Length;
            result.User_data = user_data;
            //result.Source_name = Marshal.PtrToStringAnsi(requesting_source);
            result.Source_name = new string(requesting_source);
            result.Source_name_length = (uint)result.Source_name.Length;

            var resPtr = NativeUtils.StructOrEnumToPointer(result.ToNative());
            return resPtr;
        }

        [UnmanagedCallersOnly]
        private static void ReleaseInclude(System.IntPtr user_data, AdamantiumVulkan.Shaders.Interop.ShadercIncludeResult include_result)
        {
            ShadercIncludeResult result = new ShadercIncludeResult(include_result);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AdamantiumVulkan.VulkanDllMap.Register();
            this.ClientSize = new System.Drawing.Size(800, 600);
            enableValidationLayers = true;
            _pauseEvent = new AutoResetEvent(false);
            //debugCallback = DebugCallback;

            var vertexText = File.ReadAllText("shaders\\UIEffect.fx");
            // var compiler = ShaderCompiler.New();
            // var opts = CompileOptions.New();
            // opts.EnableHlslFunctionality = true;
            // opts.UseHlslIoMapping = true;
            // opts.UseHlslOffsets = true;
            // opts.SourceLanguage = ShadercSourceLanguage.Hlsl;
            // // AdamantiumVulkan.Shaders.Interop.ShadercIncludeResolveFn resolverDelegate = ResolveInclude;
            // // AdamantiumVulkan.Shaders.Interop.ShadercIncludeResultReleaseFn releaserDelegate = ReleaseInclude;
            //
            // IntPtr userData = IntPtr.Zero;
            // ShadercIncludeResolveFn includeResolveFn = new ShadercIncludeResolveFn();
            // includeResolveFn.InvokeStdcall = &ResolveInclude;
            //
            // opts.SetIncludeCallbacks(resolver, releaser, ref userData);
            // opts.SetAutoBindUniforms = true;
            // opts.SetAutoMapLocations = true;
            
            var compilerOptions = new CompilerOptions();
            compilerOptions.Add(CompilerArguments.AllResourcesBound);
            compilerOptions.Add(CompilerArguments.SpvUseDxLayout);
            compilerOptions.Add(CompilerArguments.SpvTargetEnvVulkan1_1);
            compilerOptions.Add(CompilerArguments.SpvcExtensionGoogleHlslFunctionality1);
            compilerOptions.Add(CompilerArguments.SpvcExtensionGoogleUserType);
            compilerOptions.Add(CompilerArguments.SpvReflect);

            var dxcCompiler = DxcCompiler.Create();
            var result = dxcCompiler.CompileIntoSpirvFromText(vertexText, "UIEffect.fx", "SolidColorPixelShader", "ps_5_1", compilerOptions);

            /*
            SpirvReflection reflection = new SpirvReflection(result.Bytecode, Backend.Hlsl);
            var lst = new List<ResourceBindingKey>();
            var reflectionResult = reflection.Disassemble(lst);
            var buffer = reflectionResult.UniformBuffers[0];
            var member = buffer.GetVariable(0);
            var arraySize = member.GetArraySizeForDimension(0);
            */

            InitVulkan();
            ClientSizeChanged += Form1_ClientSizeChanged;
            thread = new Thread(RenderThread);
            thread.Start();
            FormClosing += Form1_FormClosing;
        }

        class SwapChainSupportDetails
        {
            public SurfaceCapabilitiesKHR Capabilities;
            public SurfaceFormatKHR[] Formats;
            public PresentModeKHR[] PresentModes;
        };

        class QueueFamilyIndices
        {
            public uint? graphicsFamily;
            public uint? presentFamily;

            public bool isComplete()
            {
                return graphicsFamily.HasValue && presentFamily.HasValue;
            }
        }

        const int MAX_FRAMES_IN_FLIGHT = 3;

        private bool enableDynamicRendering = true;

        Instance instance;
        PhysicalDevice physicalDevice;
        Device logicalDevice;
        Queue graphicsQueue;
        Queue presentQueue;
        SurfaceKHR surface;
        DebugUtilsMessengerEXT debugMessenger;
        SwapchainKHR swapchain;
        Image[] swapchainImages;
        ImageView[] swapchainImageViews;
        Framebuffer[] swapchainFramebuffers;
        Format swapChainImageFormat;
        Extent2D swapChainExtent;
        ImageView textureImageView;
        private Image depthImage;
        private DeviceMemory depthImageMemory;
        private ImageView depthStencilImageView;
        private Sampler textureSampler;

        RenderPass renderPass;
        PipelineLayout pipelineLayout;
        Pipeline graphicsPipeline;

        Buffer vertexBuffer;
        DeviceMemory vertexBufferMemory;

        Buffer vertexBuffer2;
        DeviceMemory vertexBufferMemory2;

        Buffer indexBuffer;
        DeviceMemory indexBufferMemory;

        CommandPool commandPool;
        CommandBuffer[] commandBuffers;

        Semaphore[] imageAvailableSemaphores;
        Semaphore[] renderFinishedSemaphores;
        Fence[] inFlightFences;
        int currentFrame = 0;

        SubmitInfo[] submitInfos = new SubmitInfo[1];
        Vertex[] vertices;
        UInt32[] indices;

        Image textureImage;
        DeviceMemory textureImageMemory;
        DescriptorSetLayout descriptorSetLayout;
        private DescriptorPool descriptorPool;
        private DescriptorSet[] descriptorSets;

        //private PFN_vkDebugUtilsMessengerCallbackEXT debugCallback;

        private delegate* unmanaged<DebugUtilsMessageSeverityFlagBitsEXT, DebugUtilsMessageTypeFlagBitsEXT, VkDebugUtilsMessengerCallbackDataEXT*,
            void*, uint> debugCallback;
        
        private bool enableValidationLayers;

        private string[] validationLayers = new[]
        {
          "VK_LAYER_KHRONOS_validation",
          //"VK_LAYER_LUNARG_core_validation",
          //"VK_LAYER_LUNARG_object_tracker",
          //"VK_LAYER_LUNARG_monitor",
          //"VK_LAYER_LUNARG_assistant_layer",
          //"VK_LAYER_AMD_switchable_graphics",
        };

        private string[] deviceExtensions = new[]
            { Constants.VK_KHR_SWAPCHAIN_EXTENSION_NAME, 
              Constants.VK_KHR_MAINTENANCE_4_EXTENSION_NAME,
              Constants.VK_GOOGLE_HLSL_FUNCTIONALITY_1_EXTENSION_NAME,
              Constants.VK_GOOGLE_USER_TYPE_EXTENSION_NAME,
              Constants.VK_KHR_DYNAMIC_RENDERING_EXTENSION_NAME,
            };

        private bool stopRendering;
        private Thread thread;
        private bool windowSizeChanged;
        AutoResetEvent _pauseEvent;

        private void Form1_ClientSizeChanged(object sender, EventArgs e)
        {
            if (ClientSize.Width > 0 && ClientSize.Height > 0)
            {
                windowSizeChanged = true;
            }

            if ((WindowState == FormWindowState.Normal || WindowState == FormWindowState.Maximized))
            {
                _pauseEvent.Set();
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct NativeMessage
        {
            public IntPtr Handle;
            public uint Message;
            public IntPtr WParameter;
            public IntPtr LParameter;
            public uint Time;
            public System.Drawing.Point Location;
        }

        [DllImport("user32.dll")]
        public static extern int PeekMessage(out NativeMessage message, IntPtr window, uint filterMin, uint filterMax, uint remove);

        bool IsApplicationIdle()
        {
            NativeMessage result;
            return PeekMessage(out result, IntPtr.Zero, 0, 0, 0) == 0;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopRendering = true;
        }

        private void RenderThread()
        {
            timer = Stopwatch.StartNew();
            while (!stopRendering)
            {
                Render();
            }

            logicalDevice.DeviceWaitIdle();
            Cleanup();
        }

        private void InitVulkan()
        {
            CreateInstance();
            SetupDebugMessenger();
            PickPhysicalDevice();
            CreateSurface();
            CreateLogicalDevice();
            CreateSwapchain();
            CreateImageViews();
            CreateRenderPass();
            CreateDescriptorSetLayout();
            CreateGraphicsPipeline();
            CreateFramebuffers();
            CreateCommandPool();
            CreateTextureImage();
            СreateTextureImageView();
            CreateDepthStencilView();
            CreateTextureSampler();
            CreateVertexBuffer();
            CreateVertexBuffer2();
            CreateIndexBuffer();
            CreateDescriptorPool();
            CreateDescriptorSets();
            CreateCommandBuffers();
            CreateSyncObjects();
        }

        private void RecreateSwapchain()
        {
            if (WindowState == FormWindowState.Minimized)
            {
                _pauseEvent.WaitOne();
            }

            logicalDevice.DeviceWaitIdle();

            CleanupSwapChain();

            CreateSwapchain();
            CreateImageViews();
            CreateDepthStencilView();
            CreateGraphicsPipeline();
            CreateFramebuffers();
        }

        private void Cleanup()
        {
            CleanupSwapChain();

            logicalDevice.DestroyRenderPass(renderPass);

            logicalDevice.DestroySampler(textureSampler);
            logicalDevice.DestroyImageView(textureImageView);
            logicalDevice.DestroyImage(textureImage);
            logicalDevice.FreeMemory(textureImageMemory);

            logicalDevice.DestroyDescriptorPool(descriptorPool, null);
            logicalDevice.DestroyDescriptorSetLayout(descriptorSetLayout, null);

            logicalDevice.DestroyBuffer(vertexBuffer);
            logicalDevice.FreeMemory(vertexBufferMemory);

            logicalDevice.DestroyBuffer(vertexBuffer2);
            logicalDevice.FreeMemory(vertexBufferMemory2);

            logicalDevice.DestroyBuffer(indexBuffer);
            logicalDevice.FreeMemory(indexBufferMemory);

            for (int i = 0; i < MAX_FRAMES_IN_FLIGHT; i++)
            {
                logicalDevice.DestroySemaphore(renderFinishedSemaphores[i]);
                logicalDevice.DestroySemaphore(imageAvailableSemaphores[i]);
                logicalDevice.DestroyFence(inFlightFences[i]);
            }

            logicalDevice.DestroyCommandPool(commandPool);

            logicalDevice.Dispose();

            if (enableValidationLayers)
            {
                DestroyDebugUtilsMessengerEXT(instance, debugMessenger);
            }

            instance.DestroySurfaceKHR(surface);
            instance.Dispose();
        }

        private void CleanupSwapChain()
        {
            foreach (var buffer in swapchainFramebuffers)
            {
                buffer.Destroy(logicalDevice);
            }

            foreach (var view in swapchainImageViews)
            {
                logicalDevice.DestroyImageView(view);
            }

            swapchain.Destroy(logicalDevice);
            graphicsPipeline.Destroy(logicalDevice);
            depthImage?.Destroy(logicalDevice);
            depthImageMemory?.FreeMemory(logicalDevice);
        }

        Stopwatch timer;
        double fps = 0;
        int frames = 0;
        CommandBuffer[] renderCommandBuffers = new CommandBuffer[1];
        CommandBufferBeginInfo beginInfo;
        RenderPassBeginInfo[] renderPassInfos;
        UInt64[] offsets = new UInt64[0];
        private unsafe void Render()
        {
            if (WindowState == FormWindowState.Minimized)
            {
                _pauseEvent.WaitOne();
            }

            var renderFence = inFlightFences[currentFrame];
            var result = logicalDevice.WaitForFences(1, renderFence, true, ulong.MaxValue);
            uint imageIndex = 0;
            result = logicalDevice.AcquireNextImageKHR(swapchain, ulong.MaxValue, imageAvailableSemaphores[currentFrame], null, ref imageIndex);

            if (result == Result.ErrorOutOfDateKhr)
            {
                RecreateSwapchain();
                return;
            }
            else if (result != Result.Success && result != Result.SuboptimalKhr)
            {
                MessageBox.Show("Failed to acquire swap chain image!");
                throw new ArgumentException();
            }

            renderCommandBuffers[0] = commandBuffers[imageIndex];

            var commandBuffer = commandBuffers[imageIndex];

            beginInfo = new CommandBufferBeginInfo();
            beginInfo.Flags = CommandBufferUsageFlagBits.SimultaneousUseBit;

            var res = commandBuffer.ResetCommandBuffer(0);
            res = commandBuffer.BeginCommandBuffer(beginInfo);
            if (res != Result.Success)
            {
                MessageBox.Show("failed to begin recording command buffer!");
                throw new Exception();
            }
            
            ClearValue clearValue = new ClearValue();
            clearValue.Color = new ClearColorValue();
            clearValue.Color.Float32 = new float[4] { 0.5f, 0.7f, 1.0f, 0.0f };
            
            commandBuffer.SetViewport(0, 1,
                new Viewport()
                {
                    X = 0, Y = 0, Width = this.ClientSize.Width, Height = this.ClientSize.Height, MinDepth = 0,
                    MaxDepth = 1
                });

            if (enableDynamicRendering)
            {
                var colorAttachmentInfo = new RenderingAttachmentInfo();
                colorAttachmentInfo.SType = StructureType.RenderingAttachmentInfo;
                colorAttachmentInfo.ImageView = swapchainImageViews[imageIndex];
                colorAttachmentInfo.ImageLayout = ImageLayout.ColorAttachmentOptimal;
                colorAttachmentInfo.ResolveMode = ResolveModeFlagBits.None;
                colorAttachmentInfo.LoadOp = AttachmentLoadOp.Clear;
                colorAttachmentInfo.StoreOp = AttachmentStoreOp.Store;
                colorAttachmentInfo.ClearValue = clearValue;

                var depthAttachmentInfo = new RenderingAttachmentInfo();
                depthAttachmentInfo.SType = StructureType.RenderingAttachmentInfo;
                depthAttachmentInfo.ImageView = depthStencilImageView;
                depthAttachmentInfo.ImageLayout = ImageLayout.DepthStencilAttachmentOptimal;
                depthAttachmentInfo.ResolveMode = ResolveModeFlagBits.None;
                depthAttachmentInfo.LoadOp = AttachmentLoadOp.Clear;
                depthAttachmentInfo.StoreOp = AttachmentStoreOp.DontCare;
                depthAttachmentInfo.ClearValue = new ClearValue()
                    { DepthStencil = new ClearDepthStencilValue() { Depth = 0.0f, Stencil = 0 } };

                var renderingInfo = new RenderingInfo();
                renderingInfo.SType = StructureType.RenderingInfo;
                renderingInfo.RenderArea = new Rect2D();
                renderingInfo.RenderArea.Extent = swapChainExtent;
                renderingInfo.RenderArea.Offset = new Offset2D();
                renderingInfo.PColorAttachments = new[] { colorAttachmentInfo };
                renderingInfo.ColorAttachmentCount = 1U;
                renderingInfo.PDepthAttachment = depthAttachmentInfo;
                renderingInfo.PStencilAttachment = depthAttachmentInfo;
                renderingInfo.LayerCount = 1;

                ImageSubresourceRange range = new ImageSubresourceRange();
                range.AspectMask = ImageAspectFlagBits.ColorBit;
                range.BaseMipLevel = 0;
                range.LevelCount = (~0U);
                range.BaseArrayLayer = 0;
                range.LayerCount = (~0U);

                ImageSubresourceRange depth_range = new ImageSubresourceRange();
                depth_range.AspectMask = ImageAspectFlagBits.DepthBit | ImageAspectFlagBits.StencilBit;
                depth_range.BaseMipLevel = 0;
                depth_range.LevelCount = (~0U);
                depth_range.BaseArrayLayer = 0;
                depth_range.LayerCount = (~0U);

                InsertImageMemoryBarrier(commandBuffer,
                    swapchainImages[imageIndex],
                    0,
                    AccessFlagBits.ColorAttachmentWriteBit,
                    ImageLayout.Undefined,
                    ImageLayout.ColorAttachmentOptimal,
                    PipelineStageFlagBits.TopOfPipeBit,
                    PipelineStageFlagBits.ColorAttachmentOutputBit,
                    range
                );

                InsertImageMemoryBarrier(commandBuffer,
                    depthImage,
                    0,
                    AccessFlagBits.DepthStencilAttachmentWriteBit,
                    ImageLayout.Undefined,
                    ImageLayout.DepthStencilAttachmentOptimal,
                    PipelineStageFlagBits.EarlyFragmentTestsBit | PipelineStageFlagBits.LateFragmentTestsBit,
                    PipelineStageFlagBits.EarlyFragmentTestsBit | PipelineStageFlagBits.LateFragmentTestsBit,
                    depth_range
                );

                commandBuffer.BeginRendering(renderingInfo);

                RenderInternal(commandBuffer, imageIndex);

                commandBuffer.EndRendering();

                InsertImageMemoryBarrier(commandBuffer,
                    swapchainImages[imageIndex],
                    AccessFlagBits.ColorAttachmentWriteBit,
                    0,
                    ImageLayout.ColorAttachmentOptimal,
                    ImageLayout.PresentSrcKhr,
                    PipelineStageFlagBits.ColorAttachmentOutputBit,
                    PipelineStageFlagBits.BottomOfPipeBit,
                    range);
            }
            else
            {
                renderPassInfos = new RenderPassBeginInfo[MAX_FRAMES_IN_FLIGHT];
                
                var renderPassInfo = new RenderPassBeginInfo();
                renderPassInfo.RenderPass = renderPass;
                renderPassInfo.Framebuffer = swapchainFramebuffers[0];
                renderPassInfo.RenderArea = new Rect2D();
                renderPassInfo.RenderArea.Offset = new Offset2D();
                renderPassInfo.RenderArea.Extent = swapChainExtent;
                
                renderPassInfo.ClearValueCount = 1;
                renderPassInfo.PClearValues = new ClearValue[] { clearValue };
                
                renderPassInfos[0] = renderPassInfo;
                
                renderPassInfo = new RenderPassBeginInfo();
                renderPassInfo.RenderPass = renderPass;
                renderPassInfo.Framebuffer = swapchainFramebuffers[1];
                renderPassInfo.RenderArea = new Rect2D();
                renderPassInfo.RenderArea.Offset = new Offset2D();
                renderPassInfo.RenderArea.Extent = swapChainExtent;
                
                renderPassInfo.ClearValueCount = 1;
                renderPassInfo.PClearValues = new ClearValue[] { clearValue };
                
                renderPassInfos[1] = renderPassInfo;
                
                renderPassInfo = new RenderPassBeginInfo();
                renderPassInfo.RenderPass = renderPass;
                renderPassInfo.Framebuffer = swapchainFramebuffers[2];
                renderPassInfo.RenderArea = new Rect2D();
                renderPassInfo.RenderArea.Offset = new Offset2D();
                renderPassInfo.RenderArea.Extent = swapChainExtent;
                
                renderPassInfo.ClearValueCount = 1;
                renderPassInfo.PClearValues = new ClearValue[] { clearValue };
                
                renderPassInfos[2] = renderPassInfo;
                
                commandBuffer.BeginRenderPass(renderPassInfos[imageIndex], SubpassContents.Inline);

                RenderInternal(commandBuffer, imageIndex);

                commandBuffer.EndRenderPass();
            }
            
            res = commandBuffer.EndCommandBuffer();
            if (res != Result.Success)
            {
                MessageBox.Show("failed to record command buffer!");
                throw new Exception();
            }

            var submitInfo = new SubmitInfo();

            Semaphore[] waitSemaphores = new[] { imageAvailableSemaphores[currentFrame] };
            var waitStages = new[] { PipelineStageFlagBits.ColorAttachmentOutputBit };
            submitInfo.WaitSemaphoreCount = 1;
            submitInfo.PWaitSemaphores = waitSemaphores;
            submitInfo.PWaitDstStageMask = waitStages;

            submitInfo.CommandBufferCount = 1;
            submitInfo.PCommandBuffers = renderCommandBuffers;

            Semaphore[] signalSemaphores = new[] { renderFinishedSemaphores[currentFrame] };
            
            submitInfo.SignalSemaphoreCount = 1;
            submitInfo.PSignalSemaphores = signalSemaphores;

            //submitInfos[0] = submitInfo;

            result = logicalDevice.ResetFences(1, renderFence);

            result = graphicsQueue.QueueSubmit(1, submitInfo, inFlightFences[currentFrame]);
            if (result != Result.Success)
            {
                MessageBox.Show($"failed to submit draw command buffer! Result was {result}");
                throw new Exception();
            }

            var presentInfo = new PresentInfoKHR();

            presentInfo.WaitSemaphoreCount = 1;
            presentInfo.PWaitSemaphores = signalSemaphores;

            SwapchainKHR[] swapchains = { swapchain };
            presentInfo.SwapchainCount = (uint)swapchains.Length;
            presentInfo.PSwapchains = swapchains;
            presentInfo.PImageIndices = new uint[]{ imageIndex };

            result = presentQueue.QueuePresentKHR(presentInfo);

            if (result == Result.ErrorOutOfDateKhr || result == Result.SuboptimalKhr || windowSizeChanged)
            {
                Console.WriteLine(result);
                RecreateSwapchain();
                windowSizeChanged = false;
            }
            else if (result != Result.Success)
            {
                MessageBox.Show("Failed to present swap chain image");
                throw new Exception();
            }

            submitInfo.Dispose();
            presentInfo.Dispose();

            frames++;

            if (timer.ElapsedMilliseconds >= 1000)
            {
                timer.Stop();
                fps = frames;
                //Text = frames.ToString();
                Console.WriteLine(frames);
                frames = 0;
                timer.Restart();
            }

            currentFrame = (currentFrame + 1) % MAX_FRAMES_IN_FLIGHT;
        }

        private void RenderInternal(CommandBuffer commandBuffer, uint imageIndex)
        {
            commandBuffer.BindPipeline(PipelineBindPoint.Graphics, graphicsPipeline);

            ulong offset = 0;

            commandBuffer.BindVertexBuffers(0, 1, vertexBuffer, ref offset);

            commandBuffer.BindIndexBuffer(indexBuffer, 0, IndexType.Uint32);

            commandBuffer.BindDescriptorSets(PipelineBindPoint.Graphics, pipelineLayout, 0, 1, descriptorSets[imageIndex], 0, 0);

            commandBuffer.DrawIndexed((uint)indices.Length, 1, 0, 0, 0);

            commandBuffer.BindVertexBuffers(0, 1, vertexBuffer2, ref offset);

            commandBuffer.BindIndexBuffer(indexBuffer, 0, IndexType.Uint32);

            commandBuffer.BindDescriptorSets(PipelineBindPoint.Graphics, pipelineLayout, 0, 1, descriptorSets[imageIndex], 0, 0);

            commandBuffer.DrawIndexed((uint)indices.Length, 1, 0, 0, 0);
        }

        private void InsertImageMemoryBarrier(CommandBuffer commandBuffer,
            Image image,
            AccessFlagBits sourceAccessMask,
            AccessFlagBits destinationAccessMask,
            ImageLayout oldLayout,
            ImageLayout newLayout,
            PipelineStageFlagBits sourceStageMask,
            PipelineStageFlagBits destinationStageMask,
            ImageSubresourceRange subresourceRange)
        {
            ImageMemoryBarrier barrier = new ImageMemoryBarrier();
            barrier.SrcQueueFamilyIndex = (~0U);
            barrier.DstQueueFamilyIndex = (~0U);
            barrier.SrcAccessMask = sourceAccessMask;
            barrier.DstAccessMask = destinationAccessMask;
            barrier.OldLayout = oldLayout;
            barrier.NewLayout = newLayout;
            barrier.Image = image;
            barrier.SubresourceRange = subresourceRange;

            commandBuffer.PipelineBarrier(
                (uint)sourceStageMask,
                (uint)destinationStageMask,
                0,
                0,
                null,
                0,
                null,
                1,
                barrier);
        }

        private void CreateInstance()
        {
            enableValidationLayers = false;
            
            var appInfo = new ApplicationInfo();
            appInfo.PApplicationName = "Hello Triangle";
            appInfo.ApplicationVersion = AdamantiumVulkan.Core.Constants.VK_MAKE_API_VERSION(0, 1, 0, 0);
            appInfo.PEngineName = "Adamantium Engine";
            appInfo.EngineVersion = Constants.VK_MAKE_API_VERSION(0, 1, 0, 0);
            appInfo.ApiVersion = Constants.VK_API_VERSION_1_3;

            var createInfo = new InstanceCreateInfo();
            createInfo.PApplicationInfo = appInfo;
            //createInfo.Flags = InstanceCreateFlagBits.EnumeratePortabilityBitKhr;

            var layersAvailable = Instance.EnumerateInstanceLayerProperties();
            var extensions = Instance.EnumerateInstanceExtensionProperties();

            string[] ext = new[]
            {
                Constants.VK_KHR_SURFACE_EXTENSION_NAME, 
                AdamantiumVulkan.Windows.Constants.VK_KHR_WIN32_SURFACE_EXTENSION_NAME,
                Constants.VK_EXT_DEBUG_UTILS_EXTENSION_NAME,
                Constants.VK_KHR_GET_PHYSICAL_DEVICE_PROPERTIES_2_EXTENSION_NAME,
            };
            
            createInfo.EnabledExtensionCount = (uint)ext.Length;
            createInfo.PEnabledExtensionNames = ext;
            //createInfo.EnabledExtensionCount = (uint)extensions.Length;
            //createInfo.PpEnabledExtensionNames = extensions.Select(x => x.ExtensionName).ToArray();

            if (enableValidationLayers)
            {
                createInfo.EnabledLayerCount = (uint)validationLayers.Length;
                createInfo.PEnabledLayerNames = validationLayers;
            }
            
            instance = Instance.Create(createInfo);
        }

        unsafe Result CreateDebugUtilsMessengerEXT(Instance instance, DebugUtilsMessengerCreateInfoEXT pCreateInfo, AllocationCallbacks pAllocator, out DebugUtilsMessengerEXT pDebugMessenger)
        {
            pDebugMessenger = null;
            
            var ptr = instance.GetInstanceProcAddr("vkCreateDebugUtilsMessengerEXT");
            var createInfoPointer = NativeUtils.StructOrEnumToPointer(pCreateInfo.ToNative());
            var result = PFN_vkCreateDebugUtilsMessengerEXT.Invoke(ptr, instance, createInfoPointer, null,
                out VkDebugUtilsMessengerEXT_T pDebugMessenger_t);
            NativeUtils.Free(createInfoPointer);
            pDebugMessenger = new DebugUtilsMessengerEXT(pDebugMessenger_t);

            return result;

        }

        void DestroyDebugUtilsMessengerEXT(Instance instance, DebugUtilsMessengerEXT debugMessenger, AllocationCallbacks pAllocator = null)
        {
            var ptr = instance.GetInstanceProcAddr("vkDestroyDebugUtilsMessengerEXT");
            PFN_vkDestroyDebugUtilsMessengerEXT.Invoke(ptr, instance, debugMessenger, null);
        }

        private unsafe void SetupDebugMessenger()
        {
            if (!enableValidationLayers)
            {
                return;
            }

            debugCallback = &DebugCallback;
            
            DebugUtilsMessengerCreateInfoEXT debugInfo = new DebugUtilsMessengerCreateInfoEXT();
            debugInfo.MessageSeverity = DebugUtilsMessageSeverityFlagBitsEXT.VerboseBitExt | DebugUtilsMessageSeverityFlagBitsEXT.WarningBitExt | DebugUtilsMessageSeverityFlagBitsEXT.ErrorBitExt;
            debugInfo.MessageType = DebugUtilsMessageTypeFlagBitsEXT.GeneralBitExt | DebugUtilsMessageTypeFlagBitsEXT.ValidationBitExt | DebugUtilsMessageTypeFlagBitsEXT.PerformanceBitExt;
            debugInfo.PfnUserCallback = debugCallback;

            var result = CreateDebugUtilsMessengerEXT(instance, debugInfo, null, out debugMessenger);

            if (result != Result.Success)
            {
                MessageBox.Show("Failed to set up debug messenger!");
                throw new Exception();
            }
        }

        [UnmanagedCallersOnly]
        private static unsafe uint DebugCallback(DebugUtilsMessageSeverityFlagBitsEXT messageSeverity, DebugUtilsMessageTypeFlagBitsEXT messageTypes, VkDebugUtilsMessengerCallbackDataEXT* pCallbackData, void* pUserData)
        {
            var data = *pCallbackData;
            Console.WriteLine(new string(data.pMessage));
            return 0;
        }

        private void PickPhysicalDevice()
        {
            var devices = instance.EnumeratePhysicalDevices();
            physicalDevice = devices[0];
            var deviceProperties = physicalDevice.GetPhysicalDeviceProperties();
            uint count = 0;
            var result = physicalDevice.EnumerateDeviceExtensionProperties("", ref count, null);
            var props = new ExtensionProperties[count];
            result = physicalDevice.EnumerateDeviceExtensionProperties("", ref count, props);
        }

        private void CreateLogicalDevice()
        {
            var indices = FindQueueFamilies(physicalDevice);

            var queueInfos = new List<DeviceQueueCreateInfo>();
            HashSet<uint> uniqueQueueFamilies = new HashSet<uint>() { indices.graphicsFamily.Value, indices.presentFamily.Value };
            float queuePriority = 1.0f;
            foreach (var queueFamily in uniqueQueueFamilies)
            {
                var queueCreateInfo = new DeviceQueueCreateInfo();
                queueCreateInfo.QueueFamilyIndex = queueFamily;
                queueCreateInfo.QueueCount = 1;
                queueCreateInfo.PQueuePriorities = queuePriority;
                queueInfos.Add(queueCreateInfo);
            }
            
            // var deviceFeatures = physicalDevice.GetPhysicalDeviceFeatures();
            // deviceFeatures.SamplerAnisotropy = true;
            
            var createInfo = new DeviceCreateInfo();
            createInfo.QueueCreateInfoCount = (uint)queueInfos.Count;
            createInfo.PQueueCreateInfos = queueInfos.ToArray();
            //createInfo.PEnabledFeatures = deviceFeatures;
            createInfo.EnabledExtensionCount = (uint)deviceExtensions.Length;
            createInfo.PEnabledExtensionNames = deviceExtensions;

            if (enableDynamicRendering)
            {
                var dynamicRendering = new PhysicalDeviceDynamicRenderingFeatures();
                dynamicRendering.SType = StructureType.PhysicalDeviceDynamicRenderingFeatures;
                dynamicRendering.DynamicRendering = true;

                var vulkan12Features = new PhysicalDeviceVulkan12Features();
                vulkan12Features.SType = StructureType.PhysicalDeviceVulkan12Features;
                var dynamicRenderingPtr = NativeUtils.StructOrEnumToPointer(dynamicRendering.ToNative());
                vulkan12Features.PNext = dynamicRenderingPtr;
                
                var vulkan11Features = new PhysicalDeviceVulkan11Features();
                vulkan11Features.SType = StructureType.PhysicalDeviceVulkan11Features;
                var vulkan12FeaturesPtr = NativeUtils.StructOrEnumToPointer(vulkan12Features.ToNative());
                vulkan11Features.PNext = vulkan12FeaturesPtr;

                var features2 = new PhysicalDeviceFeatures2();
                features2.Features = new PhysicalDeviceFeatures();
                features2.Features.SamplerAnisotropy = true;
                var vulkan11FeaturesPtr = NativeUtils.StructOrEnumToPointer(vulkan11Features.ToNative());
                features2.PNext = vulkan11FeaturesPtr;

                var features2Ptr = NativeUtils.StructOrEnumToPointer(features2.ToNative());
                createInfo.PNext = features2Ptr;
            }
            
            
            if (enableValidationLayers)
            {
                createInfo.EnabledLayerCount = (uint)validationLayers.Length;
                createInfo.PEnabledLayerNames = validationLayers;
            }

            logicalDevice = physicalDevice.CreateDevice(createInfo);

            createInfo.Dispose();

            graphicsQueue = logicalDevice.GetDeviceQueue(indices.graphicsFamily.Value, 0);
            presentQueue = logicalDevice.GetDeviceQueue(indices.presentFamily.Value, 0);
        }

        private void CreateSurface()
        {
            var surfaceInfo = new Win32SurfaceCreateInfoKHR();
            surfaceInfo.Hwnd = this.Handle;
            surfaceInfo.Hinstance = Process.GetCurrentProcess().Handle;
            surface = instance.CreateWin32Surface(surfaceInfo);
            //var headlessSurfaceInfo = new HeadlessSurfaceCreateInfoEXT();
            //var addr = instance.GetInstanceProcAddr("PFN_vkCreateHeadlessSurfaceEXT");
            //var sufaceFunc = Marshal.GetDelegateForFunctionPointer<PFN_vkCreateHeadlessSurfaceEXT>(addr);
            //surface = instance.CreateHeadlesSurface(headlessSurfaceInfo);
            //var displaySurfaceInfo = new DisplaySurfaceCreateInfoKHR();
            //displaySurfaceInfo.ImageExtent = new Extent2D();
            //displaySurfaceInfo.ImageExtent.Width = 800;
            //displaySurfaceInfo.ImageExtent.Height = 600;
            //uint displayCount = 0;
            //physicalDevice.GetPhysicalDeviceFeatures(out var features);
            //physicalDevice.GetPhysicalDeviceDisplayPlanePropertiesKHR(ref displayCount, out var props);
            //physicalDevice.GetDisplayPlaneSupportedDisplaysKHR(0, ref displayCount, out var displays);
            //physicalDevice.GetDisplayPlaneCapabilities2KHR()
        }

        QueueFamilyIndices FindQueueFamilies(PhysicalDevice device)
        {
            QueueFamilyIndices indices = new QueueFamilyIndices();

            uint queueFamilyCount = 0;
            device.GetPhysicalDeviceQueueFamilyProperties(ref queueFamilyCount, null);

            var queueFamilies = new QueueFamilyProperties[queueFamilyCount];
            device.GetPhysicalDeviceQueueFamilyProperties(ref queueFamilyCount, queueFamilies);

            uint i = 0;
            foreach (var queueFamily in queueFamilies)
            {
                if ((queueFamily.QueueFlags & (uint)QueueFlagBits.GraphicsBit) > 0)
                {
                    indices.graphicsFamily = i;
                }

                device.GetPhysicalDeviceSurfaceSupportKHR(i, surface, out var presentSupport);

                if (queueFamily.QueueCount > 0 && presentSupport)
                {
                    indices.presentFamily = i;
                }

                if (indices.isComplete())
                {
                    break;
                }

                i++;
            }

            return indices;
        }

        SwapChainSupportDetails QuerySwapChainSupport(PhysicalDevice device)
        {
            SwapChainSupportDetails details = new SwapChainSupportDetails();
            details.Capabilities = device.GetPhysicalDeviceSurfaceCapabilitiesKHR(surface);
            details.Formats = device.GetPhysicalDeviceSurfaceFormatsKHR(surface);
            details.PresentModes = device.GetPhysicalDeviceSurfacePresentModesKHR(surface);
            return details;
        }

        private void CreateSwapchain()
        {
            var swapChainSupport = QuerySwapChainSupport(physicalDevice);

            SurfaceFormatKHR surfaceFormat = ChooseSwapSurfaceFormat(swapChainSupport.Formats);
            PresentModeKHR presentMode = ChooseSwapPresentMode(swapChainSupport.PresentModes);
            Extent2D extent = ChooseSwapExtent(swapChainSupport.Capabilities);

            //uint imageCount = swapChainSupport.Capabilities.MinImageCount + 1;
            //if (swapChainSupport.Capabilities.MaxImageCount > 0 && imageCount > swapChainSupport.Capabilities.MaxImageCount)
            //{
            //    imageCount = swapChainSupport.Capabilities.MaxImageCount;
            //}

            SwapchainCreateInfoKHR createInfo = new SwapchainCreateInfoKHR();
            createInfo.Surface = surface;

            //createInfo.MinImageCount = imageCount;
            createInfo.MinImageCount = MAX_FRAMES_IN_FLIGHT;
            createInfo.ImageFormat = surfaceFormat.Format;
            createInfo.ImageColorSpace = surfaceFormat.ColorSpace;
            createInfo.ImageExtent = extent;
            createInfo.ImageArrayLayers = 1;
            createInfo.ImageUsage = ImageUsageFlagBits.ColorAttachmentBit;
            createInfo.Flags = 0;

            QueueFamilyIndices indices = FindQueueFamilies(physicalDevice);
            var queueFamilyIndices = new uint[] { indices.graphicsFamily.Value, indices.presentFamily.Value };

            if (indices.graphicsFamily != indices.presentFamily)
            {
                createInfo.ImageSharingMode = SharingMode.Concurrent;
                createInfo.QueueFamilyIndexCount = (uint)queueFamilyIndices.Length;
                createInfo.PQueueFamilyIndices = queueFamilyIndices;
            }
            else
            {
                createInfo.ImageSharingMode = SharingMode.Exclusive;
            }

            createInfo.PreTransform = swapChainSupport.Capabilities.CurrentTransform;
            createInfo.CompositeAlpha = CompositeAlphaFlagBitsKHR.OpaqueBitKhr;
            createInfo.PresentMode = presentMode;
            createInfo.Clipped = true;

            swapchain = logicalDevice.CreateSwapchainKHR(createInfo);

            createInfo.Dispose();

            swapchainImages = logicalDevice.GetSwapchainImagesKHR(swapchain);

            swapChainImageFormat = surfaceFormat.Format;
            swapChainExtent = extent;
        }

        private void CreateImageViews()
        {
            swapchainImageViews = new ImageView[swapchainImages.Length];

            for (int i = 0; i < swapchainImages.Length; i++)
            {
                var createInfo = new ImageViewCreateInfo();
                createInfo.Image = swapchainImages[i];
                createInfo.ViewType = ImageViewType._2d;
                createInfo.Format = swapChainImageFormat;
                ComponentMapping componentMapping = new ComponentMapping();
                componentMapping.R = ComponentSwizzle.Identity;
                componentMapping.G = ComponentSwizzle.Identity;
                componentMapping.B = ComponentSwizzle.Identity;
                componentMapping.A = ComponentSwizzle.Identity;
                createInfo.Components = componentMapping;
                ImageSubresourceRange subresourceRange = new ImageSubresourceRange();
                subresourceRange.AspectMask = ImageAspectFlagBits.ColorBit;
                subresourceRange.BaseMipLevel = 0;
                subresourceRange.LevelCount = 1;
                subresourceRange.BaseArrayLayer = 0;
                subresourceRange.LayerCount = 1;
                createInfo.SubresourceRange = subresourceRange;

                swapchainImageViews[i] = logicalDevice.CreateImageView(createInfo);
            }
        }

        private void CreateRenderPass()
        {
            var colorAttachment = new AttachmentDescription();
            colorAttachment.Format = swapChainImageFormat;
            colorAttachment.Samples = SampleCountFlagBits._1Bit;
            colorAttachment.LoadOp = AttachmentLoadOp.Clear;
            colorAttachment.StoreOp = AttachmentStoreOp.Store;
            colorAttachment.StencilLoadOp = AttachmentLoadOp.DontCare;
            colorAttachment.StencilStoreOp = AttachmentStoreOp.DontCare;
            colorAttachment.InitialLayout = ImageLayout.Undefined;
            colorAttachment.FinalLayout = ImageLayout.PresentSrcKhr;

            var colorAttachmentRef = new AttachmentReference();
            colorAttachmentRef.Attachment = 0;
            colorAttachmentRef.Layout = ImageLayout.ColorAttachmentOptimal;

            var subpass = new SubpassDescription();
            subpass.PipelineBindPoint = PipelineBindPoint.Graphics;
            subpass.ColorAttachmentCount = 1;
            subpass.PColorAttachments = new[] { colorAttachmentRef };

            var renderPassInfo = new RenderPassCreateInfo();
            renderPassInfo.AttachmentCount = 1;
            renderPassInfo.PAttachments = new[] { colorAttachment };
            renderPassInfo.SubpassCount = 1;
            renderPassInfo.PSubpasses = new[] { subpass };

            renderPass = logicalDevice.CreateRenderPass(renderPassInfo);
        }

        private void CreateDescriptorSetLayout()
        {
            var bindings = new List<DescriptorSetLayoutBinding>();

            //DescriptorSetLayoutBinding uboLayoutBinding = new DescriptorSetLayoutBinding();
            //uboLayoutBinding.Binding = 0;
            //uboLayoutBinding.DescriptorCount = 1;
            //uboLayoutBinding.DescriptorType = DescriptorType.UniformBuffer;
            //uboLayoutBinding.PImmutableSamplers = null;
            //uboLayoutBinding.StageFlags = (uint)ShaderStageFlagBits.VertexBit;

            DescriptorSetLayoutBinding samplerLayoutBinding = new DescriptorSetLayoutBinding();
            samplerLayoutBinding.Binding = 0;
            samplerLayoutBinding.DescriptorCount = 1;
            samplerLayoutBinding.DescriptorType = DescriptorType.CombinedImageSampler;
            samplerLayoutBinding.PImmutableSamplers = null;
            samplerLayoutBinding.StageFlags = ShaderStageFlagBits.FragmentBit;

            bindings.Add(samplerLayoutBinding);

            DescriptorSetLayoutCreateInfo layoutInfo = new DescriptorSetLayoutCreateInfo();
            layoutInfo.BindingCount = (uint)bindings.Count;
            layoutInfo.PBindings = bindings.ToArray();

            descriptorSetLayout = logicalDevice.CreateDescriptorSetLayout(layoutInfo);
        }

        private void CreateGraphicsPipeline()
        {
            var compilerOptions = new CompilerOptions();
            compilerOptions.Add(CompilerArguments.AllResourcesBound);
            compilerOptions.Add(CompilerArguments.SpvUseDxLayout);
            compilerOptions.Add($"{CompilerArguments.SpvTargetEnv}vulkan1.1");
            compilerOptions.Add($"{CompilerArguments.SpvExtension}SPV_GOOGLE_hlsl_functionality1");
            compilerOptions.Add($"{CompilerArguments.SpvExtension}SPV_GOOGLE_user_type");
            compilerOptions.Add(CompilerArguments.SpvReflect);
            var compiler = DxcCompiler.Create();
            var vertexContent = compiler.CompileIntoSpirvFromFile(@"shaders\BasicShader.hlsl", "VertexMain", "vs_6_0", compilerOptions);
            var fragmentContent = compiler.CompileIntoSpirvFromFile(@"shaders\BasicShader.hlsl", "FragmentMain", "ps_6_0", compilerOptions);
            
            compiler.Dispose();
        
            //var vertexContent = File.ReadAllBytes(@"shaders\vert.spv");
            //var fragmentContent = File.ReadAllBytes(@"shaders\frag.spv");

            var vertexShaderModule = CreateShaderModule(vertexContent);
            var fragmentShaderModule = CreateShaderModule(fragmentContent);

            var vertShaderStageInfo = new PipelineShaderStageCreateInfo();
            vertShaderStageInfo.Stage = ShaderStageFlagBits.VertexBit;
            vertShaderStageInfo.Module = vertexShaderModule;
            vertShaderStageInfo.PName = "VertexMain";

            var fragShaderStageInfo = new PipelineShaderStageCreateInfo();
            fragShaderStageInfo.Stage = ShaderStageFlagBits.FragmentBit;
            fragShaderStageInfo.Module = fragmentShaderModule;
            fragShaderStageInfo.PName = "FragmentMain";

            PipelineShaderStageCreateInfo[] shaderStages = new[] { vertShaderStageInfo, fragShaderStageInfo };

            var bindingDescr = GetBindingDescription<Vertex>();
            var attributesDescriptions = GetVertexAttributeDescription<Vertex>();

            var vertexInputInfo = new PipelineVertexInputStateCreateInfo();
            vertexInputInfo.VertexBindingDescriptionCount = 1;
            vertexInputInfo.VertexAttributeDescriptionCount = (uint)attributesDescriptions.Length;
            vertexInputInfo.PVertexBindingDescriptions = new VertexInputBindingDescription[] { bindingDescr };
            vertexInputInfo.PVertexAttributeDescriptions = attributesDescriptions;

            var inputAssembly = new PipelineInputAssemblyStateCreateInfo();
            inputAssembly.Topology = PrimitiveTopology.TriangleList;
            inputAssembly.PrimitiveRestartEnable = false;

            var viewport = new Viewport();
            viewport.X = 0.0f;
            viewport.Y = 0.0f;
            viewport.Width = (float)swapChainExtent.Width;
            viewport.Height = (float)swapChainExtent.Height;
            viewport.MinDepth = 0.0f;
            viewport.MaxDepth = 1.0f;

            Rect2D scissor = new Rect2D();
            scissor.Offset = new Offset2D();
            scissor.Extent = swapChainExtent;

            var viewportState = new PipelineViewportStateCreateInfo();
            viewportState.ViewportCount = 1;
            viewportState.PViewports = new Viewport[] { viewport };
            viewportState.ScissorCount = 1;
            viewportState.PScissors = new Rect2D[] { scissor };

            var rasterizer = new PipelineRasterizationStateCreateInfo();
            rasterizer.DepthClampEnable = false;
            rasterizer.RasterizerDiscardEnable = false;
            rasterizer.PolygonMode = PolygonMode.Fill;
            rasterizer.LineWidth = 1.0f;
            rasterizer.CullMode = CullModeFlagBits.None;
            rasterizer.FrontFace = FrontFace.Clockwise;
            rasterizer.DepthBiasEnable = false;

            var multisampling = new PipelineMultisampleStateCreateInfo();
            multisampling.SampleShadingEnable = false;
            multisampling.RasterizationSamples = SampleCountFlagBits._1Bit;

            var colorBlendAttachment = new PipelineColorBlendAttachmentState();
            colorBlendAttachment.ColorWriteMask = (ColorComponentFlagBits.RBit | ColorComponentFlagBits.GBit | ColorComponentFlagBits.BBit | ColorComponentFlagBits.ABit);
            colorBlendAttachment.BlendEnable = false;

            var colorBlending = new PipelineColorBlendStateCreateInfo();
            colorBlending.LogicOpEnable = false;
            colorBlending.LogicOp = LogicOp.Copy;
            colorBlending.AttachmentCount = 1;
            colorBlending.PAttachments = new PipelineColorBlendAttachmentState[] { colorBlendAttachment };
            colorBlending.BlendConstants = new float[4];
            colorBlending.BlendConstants[0] = 0.0f;
            colorBlending.BlendConstants[1] = 0.0f;
            colorBlending.BlendConstants[2] = 0.0f;
            colorBlending.BlendConstants[3] = 0.0f;

            var pipelineLayoutInfo = new PipelineLayoutCreateInfo();
            pipelineLayoutInfo.SetLayoutCount = 1;
            pipelineLayoutInfo.PSetLayouts = new DescriptorSetLayout[] { descriptorSetLayout };

            pipelineLayout = logicalDevice.CreatePipelineLayout(pipelineLayoutInfo);

            var dynamicState = new PipelineDynamicStateCreateInfo();
            dynamicState.PDynamicStates = new[] { DynamicState.Viewport };
            dynamicState.DynamicStateCount = 1;

            var renderingCreateInfo = new PipelineRenderingCreateInfo();
            renderingCreateInfo.SType = StructureType.PipelineRenderingCreateInfo;
            renderingCreateInfo.ColorAttachmentCount = 1U;
            renderingCreateInfo.PColorAttachmentFormats = new Format[] { swapChainImageFormat};
            renderingCreateInfo.DepthAttachmentFormat = Format.D32_SFLOAT_S8_UINT;
            renderingCreateInfo.StencilAttachmentFormat = Format.D32_SFLOAT_S8_UINT;
            var nativeInfo = renderingCreateInfo.ToNative();

            var info = new PipelineRenderingCreateInfo(nativeInfo);

            var depthStencilState = new PipelineDepthStencilStateCreateInfo();
            depthStencilState.DepthWriteEnable = false;
            depthStencilState.DepthTestEnable = false;
            depthStencilState.DepthCompareOp = CompareOp.Greater;
            
            
            var pipelineInfo = new GraphicsPipelineCreateInfo();
            pipelineInfo.PNext = NativeUtils.StructOrEnumToPointer(nativeInfo);
            pipelineInfo.StageCount = 2;
            pipelineInfo.PStages = shaderStages;
            pipelineInfo.PVertexInputState = vertexInputInfo;
            pipelineInfo.PInputAssemblyState = inputAssembly;
            pipelineInfo.PViewportState = viewportState;
            pipelineInfo.PRasterizationState = rasterizer;
            pipelineInfo.PMultisampleState = multisampling;
            pipelineInfo.PColorBlendState = colorBlending;
            pipelineInfo.Layout = pipelineLayout;
            pipelineInfo.RenderPass = null;
            pipelineInfo.Subpass = 0;
            pipelineInfo.PDynamicState = dynamicState;
            pipelineInfo.PDepthStencilState = depthStencilState; 

            if (!enableDynamicRendering)
            {
                pipelineInfo.PNext = null;
                pipelineInfo.RenderPass = renderPass;
            }

            var pipelines = logicalDevice.CreateGraphicsPipelines(null, 1, pipelineInfo);
            graphicsPipeline = pipelines[0];

            pipelineInfo.Dispose();
            logicalDevice.DestroyShaderModule(vertexShaderModule);
            logicalDevice.DestroyShaderModule(fragmentShaderModule);
        }

        private void CreateFramebuffers()
        {
            swapchainFramebuffers = new Framebuffer[swapchainImageViews.Length];

            for (int i = 0; i < swapchainImageViews.Length; i++)
            {
                FramebufferCreateInfo framebufferInfo = new FramebufferCreateInfo();
                framebufferInfo.RenderPass = renderPass;
                framebufferInfo.AttachmentCount = 1;

                framebufferInfo.PAttachments = new[] { swapchainImageViews[i] };
                framebufferInfo.Width = swapChainExtent.Width;
                framebufferInfo.Height = swapChainExtent.Height;
                framebufferInfo.Layers = 1;

                swapchainFramebuffers[i] = logicalDevice.CreateFramebuffer(framebufferInfo);

                framebufferInfo.Dispose();
            }
        }

        private void CreateCommandPool()
        {
            QueueFamilyIndices queueFamilyIndices = FindQueueFamilies(physicalDevice);

            var poolInfo = new CommandPoolCreateInfo();
            poolInfo.QueueFamilyIndex = queueFamilyIndices.graphicsFamily.Value;
            poolInfo.Flags = CommandPoolCreateFlagBits.ResetCommandBufferBit;
            commandPool = logicalDevice.CreateCommandPool(poolInfo);
        }

        void СreateTextureImageView()
        {
            textureImageView = СreateImageView(textureImage, Format.R8G8B8A8_UNORM, ImageAspectFlagBits.ColorBit);
        }

        void CreateDepthStencilView()
        {
            CreateImage(swapChainExtent.Width, 
                swapChainExtent.Height, 
                Format.D32_SFLOAT_S8_UINT, 
                ImageTiling.Optimal, 
                ImageUsageFlagBits.DepthStencilAttachmentBit,
                MemoryPropertyFlagBits.DeviceLocalBit,
                out depthImage,
                out depthImageMemory);
            depthStencilImageView = СreateImageView(depthImage, Format.D32_SFLOAT_S8_UINT, ImageAspectFlagBits.DepthBit | ImageAspectFlagBits.StencilBit);
            
            TransitionImageLayout(depthImage, ImageLayout.Undefined, ImageLayout.DepthStencilAttachmentOptimal, ImageAspectFlagBits.DepthBit | ImageAspectFlagBits.StencilBit);
        }

        void CreateTextureSampler()
        {
            SamplerCreateInfo samplerInfo = new SamplerCreateInfo();
            samplerInfo.MagFilter = Filter.Linear;
            samplerInfo.MinFilter = Filter.Linear;
            samplerInfo.AddressModeU = SamplerAddressMode.Repeat;
            samplerInfo.AddressModeV = SamplerAddressMode.Repeat;
            samplerInfo.AddressModeW = SamplerAddressMode.Repeat;
            samplerInfo.AnisotropyEnable = true;
            samplerInfo.MaxAnisotropy = 16;
            samplerInfo.BorderColor = BorderColor.IntOpaqueBlack;
            samplerInfo.UnnormalizedCoordinates = false;
            samplerInfo.CompareEnable = false;
            samplerInfo.CompareOp = CompareOp.Always;
            samplerInfo.MipmapMode = SamplerMipmapMode.Linear;

            if (logicalDevice.CreateSampler(samplerInfo, null, out textureSampler) != Result.Success)
            {
                throw new Exception("failed to create texture sampler!");
            }
        }

        ImageView СreateImageView(Image image, Format format, ImageAspectFlagBits aspectFlags)
        {
            ImageViewCreateInfo viewInfo = new ImageViewCreateInfo();
            viewInfo.Image = image;
            viewInfo.ViewType = ImageViewType._2d;
            viewInfo.Format = format;
            viewInfo.SubresourceRange = new ImageSubresourceRange();
            viewInfo.SubresourceRange.AspectMask = aspectFlags;
            viewInfo.SubresourceRange.BaseMipLevel = 0;
            viewInfo.SubresourceRange.LevelCount = 1;
            viewInfo.SubresourceRange.BaseArrayLayer = 0;
            viewInfo.SubresourceRange.LayerCount = 1;

            if (logicalDevice.CreateImageView(viewInfo, null, out var imageView) != Result.Success)
            {
                throw new Exception("failed to create texture image view!");
            }

            return imageView;
        }

        private void CreateTextureImage()
        {
            var img = Adamantium.Imaging.Image.Load(@"Textures\BaseAlbedoTexture_Text.png");

            Buffer stagingBuffer;
            DeviceMemory stagingBufferMemory;
            CreateBuffer((ulong)img.TotalSizeInBytes, BufferUsageFlagBits.TransferSrcBit, MemoryPropertyFlagBits.HostVisibleBit | MemoryPropertyFlagBits.HostCoherentBit, out stagingBuffer, out stagingBufferMemory);

            unsafe
            {
                var data = logicalDevice.MapMemory(stagingBufferMemory, 0, (ulong)img.TotalSizeInBytes, 0);
                System.Buffer.MemoryCopy(img.DataPointer.ToPointer(), data, (long)img.TotalSizeInBytes, (long)img.TotalSizeInBytes);
                logicalDevice.UnmapMemory(stagingBufferMemory);
            }

            var imageDescr = img.Description;
            img?.Dispose();

            ImageUsageFlagBits usage = ImageUsageFlagBits.TransferDstBit | ImageUsageFlagBits.SampledBit;
            CreateImage((uint)imageDescr.Width, (uint)imageDescr.Height, imageDescr.Format, ImageTiling.Optimal, usage, MemoryPropertyFlagBits.DeviceLocalBit, out textureImage, out textureImageMemory);

            TransitionImageLayout(textureImage, ImageLayout.Undefined, ImageLayout.TransferDstOptimal, ImageAspectFlagBits.ColorBit);
            CopyBufferToImage(stagingBuffer, textureImage, (uint)imageDescr.Width, (uint)imageDescr.Height);
            TransitionImageLayout(textureImage, ImageLayout.TransferDstOptimal, ImageLayout.ShaderReadOnlyOptimal, ImageAspectFlagBits.ColorBit);

            logicalDevice.DestroyBuffer(stagingBuffer);
            logicalDevice.FreeMemory(stagingBufferMemory);
        }

        void CreateImage(uint width, uint height, Format format, ImageTiling tiling, ImageUsageFlagBits usage, MemoryPropertyFlagBits properties, out Image image, out DeviceMemory imageMemory)
        {
            ImageCreateInfo imageInfo = new ImageCreateInfo();
            imageInfo.ImageType = ImageType._2d;
            imageInfo.Extent = new Extent3D();
            imageInfo.Extent.Width = width;
            imageInfo.Extent.Height = height;
            imageInfo.Extent.Depth = 1;
            imageInfo.MipLevels = 1;
            imageInfo.ArrayLayers = 1;
            imageInfo.Format = format;
            imageInfo.Tiling = tiling;
            imageInfo.InitialLayout = ImageLayout.Preinitialized;
            imageInfo.Usage = usage;
            imageInfo.Samples = SampleCountFlagBits._1Bit;
            imageInfo.SharingMode = SharingMode.Exclusive;
            

            if (logicalDevice.CreateImage(imageInfo, null, out image) != Result.Success)
            {
                throw new Exception("failed to create image!");
            }

            logicalDevice.GetImageMemoryRequirements(image, out var memRequirements);

            MemoryAllocateInfo allocInfo = new MemoryAllocateInfo();
            allocInfo.AllocationSize = memRequirements.Size;
            allocInfo.MemoryTypeIndex = FindMemoryType(memRequirements.MemoryTypeBits, properties);

            if (logicalDevice.AllocateMemory(allocInfo, null, out imageMemory) != Result.Success)
            {
                throw new Exception("failed to allocate image memory!");
            }

            logicalDevice.BindImageMemory(image, imageMemory, 0);
        }

        void TransitionImageLayout(Image image, ImageLayout oldLayout, ImageLayout newLayout, ImageAspectFlagBits aspectFlags)
        {
            CommandBuffer commandBuffer = logicalDevice.BeginSingleTimeCommand(commandPool);

            ImageMemoryBarrier barrier = new ImageMemoryBarrier();
            barrier.OldLayout = oldLayout;
            barrier.NewLayout = newLayout;
            barrier.SrcQueueFamilyIndex = (~0U);
            barrier.DstQueueFamilyIndex = (~0U);
            barrier.Image = image;
            barrier.SubresourceRange = new ImageSubresourceRange();
            barrier.SubresourceRange.AspectMask = aspectFlags;
            barrier.SubresourceRange.BaseMipLevel = 0;
            barrier.SubresourceRange.LevelCount = 1;
            barrier.SubresourceRange.BaseArrayLayer = 0;
            barrier.SubresourceRange.LayerCount = 1;

            PipelineStageFlagBits sourceStage;
            PipelineStageFlagBits destinationStage;

            if ((oldLayout == ImageLayout.Undefined || oldLayout == ImageLayout.Preinitialized) && newLayout == ImageLayout.TransferDstOptimal)
            {
                barrier.SrcAccessMask = 0;
                barrier.DstAccessMask = AccessFlagBits.TransferWriteBit;

                sourceStage = PipelineStageFlagBits.TopOfPipeBit;
                destinationStage = PipelineStageFlagBits.TransferBit;
            }
            else if ((oldLayout == ImageLayout.Undefined || oldLayout == ImageLayout.Preinitialized) && newLayout == ImageLayout.TransferSrcOptimal)
            {
                barrier.SrcAccessMask = 0;
                barrier.DstAccessMask = AccessFlagBits.TransferWriteBit;

                sourceStage = PipelineStageFlagBits.TopOfPipeBit;
                destinationStage = PipelineStageFlagBits.TransferBit;
            }
            else if (oldLayout == ImageLayout.TransferSrcOptimal && newLayout == ImageLayout.ShaderReadOnlyOptimal)
            {
                barrier.SrcAccessMask = AccessFlagBits.TransferWriteBit;
                barrier.DstAccessMask = AccessFlagBits.ShaderReadBit;

                sourceStage = PipelineStageFlagBits.TransferBit;
                destinationStage = PipelineStageFlagBits.FragmentShaderBit;
            }
            else if (oldLayout == ImageLayout.TransferDstOptimal && newLayout == ImageLayout.ShaderReadOnlyOptimal)
            {
                barrier.SrcAccessMask = AccessFlagBits.TransferWriteBit;
                barrier.DstAccessMask = AccessFlagBits.ShaderReadBit;

                sourceStage = PipelineStageFlagBits.TransferBit;
                destinationStage = PipelineStageFlagBits.FragmentShaderBit;
            }
            else if (oldLayout == ImageLayout.Undefined && newLayout == ImageLayout.DepthStencilAttachmentOptimal)
            {
                barrier.SrcAccessMask = 0;
                barrier.DstAccessMask = (AccessFlagBits.DepthStencilAttachmentReadBit |
                                               AccessFlagBits.DepthStencilAttachmentWriteBit);

                sourceStage = PipelineStageFlagBits.TopOfPipeBit;
                destinationStage = PipelineStageFlagBits.EarlyFragmentTestsBit;
            }
            else
            {
                throw new Exception("unsupported layout transition!");
            }

            commandBuffer.PipelineBarrier(
                (uint)sourceStage, 
                (uint)destinationStage, 
                0, 
                0, 
                null, 
                0, 
                null, 
                1, 
                barrier);

            logicalDevice.EndSingleTimeCommands(graphicsQueue, commandPool, commandBuffer);
        }

        void CopyBufferToImage(Buffer buffer, Image image, uint width, uint height)
        {
            var commandBuffer = logicalDevice.BeginSingleTimeCommand(commandPool);

            BufferImageCopy region = new BufferImageCopy();
            region.BufferOffset = 0;
            region.BufferRowLength = 0;
            region.BufferImageHeight = 0;
            region.ImageSubresource = new ImageSubresourceLayers();
            region.ImageSubresource.AspectMask = ImageAspectFlagBits.ColorBit;
            region.ImageSubresource.MipLevel = 0;
            region.ImageSubresource.BaseArrayLayer = 0;
            region.ImageSubresource.LayerCount = 1;
            region.ImageOffset = new Offset3D() { X = 0, Y = 0, Z = 0};
            region.ImageExtent = new Extent3D() {Width = width, Height = height, Depth = 1}; 
            
            commandBuffer.CopyBufferToImage(buffer, image, ImageLayout.TransferDstOptimal, 1, region);
            logicalDevice.EndSingleTimeCommands(graphicsQueue, commandPool, commandBuffer);
        }

        void CopyImageToImage(Image source, Image destination, uint width, uint height)
        {
            var commandBuffer = logicalDevice.BeginSingleTimeCommand(commandPool);

            ImageCopy region = new ImageCopy();
            region.SrcOffset = new Offset3D();
            region.DstOffset = new Offset3D();
            region.SrcSubresource = new ImageSubresourceLayers();
            region.DstSubresource = new ImageSubresourceLayers();
            region.SrcSubresource.LayerCount = 1;
            region.SrcSubresource.AspectMask = ImageAspectFlagBits.ColorBit;
            region.DstSubresource.LayerCount = 1;
            region.DstSubresource.AspectMask = ImageAspectFlagBits.ColorBit;
            region.Extent = new Extent3D() { Width = width, Height = height, Depth = 1 };

            commandBuffer.CopyImage(source, ImageLayout.TransferSrcOptimal, destination, ImageLayout.TransferDstOptimal, 1, region);
            logicalDevice.EndSingleTimeCommands(graphicsQueue, commandPool, commandBuffer);
        }

        private void CreateVertexBuffer()
        {
            vertices = GetVertexArray();
            var bufferSize = (ulong)(Marshal.SizeOf(vertices[0]) * vertices.Length);
            Buffer stagingBuffer;
            DeviceMemory stagingBufferMemory;
            CreateBuffer(bufferSize, BufferUsageFlagBits.TransferSrcBit, MemoryPropertyFlagBits.HostVisibleBit | MemoryPropertyFlagBits.HostCoherentBit, out stagingBuffer, out stagingBufferMemory);

            var data = logicalDevice.MapMemory(stagingBufferMemory, 0, bufferSize, 0);
            unsafe
            {
                var sourcePtr = GCHandle.Alloc(vertices, GCHandleType.Pinned);
                var handle = sourcePtr.AddrOfPinnedObject();
                System.Buffer.MemoryCopy(handle.ToPointer(), data, (long)bufferSize, (long)bufferSize);
                sourcePtr.Free();
            }

            logicalDevice.UnmapMemory(stagingBufferMemory);

            CreateBuffer(bufferSize, BufferUsageFlagBits.TransferDstBit | BufferUsageFlagBits.VertexBufferBit, MemoryPropertyFlagBits.DeviceLocalBit, out vertexBuffer, out vertexBufferMemory);

            CopyBuffer(stagingBuffer, vertexBuffer, bufferSize);

            logicalDevice.DestroyBuffer(stagingBuffer);
            logicalDevice.FreeMemory(stagingBufferMemory);
        }

        private void CreateVertexBuffer2()
        {
            vertices = GetVertexArray2();
            var bufferSize = (ulong)(Marshal.SizeOf(vertices[0]) * vertices.Length);
            Buffer stagingBuffer;
            DeviceMemory stagingBufferMemory;
            CreateBuffer(bufferSize, BufferUsageFlagBits.TransferSrcBit, MemoryPropertyFlagBits.HostVisibleBit | MemoryPropertyFlagBits.HostCoherentBit, out stagingBuffer, out stagingBufferMemory);

            var data = logicalDevice.MapMemory(stagingBufferMemory, 0, bufferSize, 0);
            unsafe
            {
                var sourcePtr = GCHandle.Alloc(vertices, GCHandleType.Pinned);
                var handle = sourcePtr.AddrOfPinnedObject();
                System.Buffer.MemoryCopy(handle.ToPointer(), data, (long)bufferSize, (long)bufferSize);
                sourcePtr.Free();
            }

            logicalDevice.UnmapMemory(stagingBufferMemory);

            CreateBuffer(bufferSize, BufferUsageFlagBits.TransferDstBit | BufferUsageFlagBits.VertexBufferBit, MemoryPropertyFlagBits.DeviceLocalBit, out vertexBuffer2, out vertexBufferMemory2);

            CopyBuffer(stagingBuffer, vertexBuffer2, bufferSize);

            logicalDevice.DestroyBuffer(stagingBuffer);
            logicalDevice.FreeMemory(stagingBufferMemory);
        }

        void CreateIndexBuffer()
        {
            indices = GetIndices();
            ulong bufferSize = (ulong)(Marshal.SizeOf(indices[0]) * indices.Length);

            Buffer stagingBuffer;
            DeviceMemory stagingBufferMemory;
            CreateBuffer(bufferSize, BufferUsageFlagBits.TransferSrcBit, MemoryPropertyFlagBits.HostVisibleBit | MemoryPropertyFlagBits.HostCoherentBit, out stagingBuffer, out stagingBufferMemory);

            var result = logicalDevice.MapMemory(stagingBufferMemory, 0, bufferSize, 0, out var data);
            unsafe
            {
                var sourcePtr = GCHandle.Alloc(indices, GCHandleType.Pinned);
                var handle = sourcePtr.AddrOfPinnedObject();
                System.Buffer.MemoryCopy(handle.ToPointer(), data, (long)bufferSize, (long)bufferSize);
                sourcePtr.Free();
            }

            logicalDevice.UnmapMemory(stagingBufferMemory);

            CreateBuffer(bufferSize, BufferUsageFlagBits.TransferDstBit | BufferUsageFlagBits.IndexBufferBit, MemoryPropertyFlagBits.DeviceLocalBit, out indexBuffer, out indexBufferMemory);

            CopyBuffer(stagingBuffer, indexBuffer, bufferSize);

            logicalDevice.DestroyBuffer(stagingBuffer);
            logicalDevice.FreeMemory(stagingBufferMemory);
        }

        private void CreateBuffer(ulong size, BufferUsageFlagBits usage, MemoryPropertyFlagBits memoryProperties, out Buffer buffer, out DeviceMemory bufferMemory)
        {
            BufferCreateInfo bufferInfo = new BufferCreateInfo();
            bufferInfo.Size = size;
            bufferInfo.Usage = usage;
            bufferInfo.SharingMode = SharingMode.Exclusive;

            buffer = logicalDevice.CreateBuffer(bufferInfo);

            MemoryRequirements memoryRequirements = logicalDevice.GetBufferMemoryRequirements(buffer);

            MemoryAllocateInfo allocInfo = new MemoryAllocateInfo();
            allocInfo.AllocationSize = memoryRequirements.Size;

            var memProperties = physicalDevice.GetPhysicalDeviceMemoryProperties();
            for (uint i = 0; i < memProperties.MemoryTypeCount; i++)
            {
                if (((memoryRequirements.MemoryTypeBits >> (int)i) & 1) == 1
                    && memProperties.MemoryTypes[i].PropertyFlags.HasFlag(memoryProperties))
                {
                    allocInfo.MemoryTypeIndex = i;
                    break;
                }
            }

            bufferMemory = logicalDevice.AllocateMemory(allocInfo);

            var result = logicalDevice.BindBufferMemory(buffer, bufferMemory, 0);
        }

        private void CopyBuffer(Buffer srcBuffer, Buffer dstBuffer, ulong size)
        {
            var commandBuffer = logicalDevice.BeginSingleTimeCommand(commandPool);

            BufferCopy copyRegin = new BufferCopy();
            copyRegin.Size = size;
            var regions = new BufferCopy[1] { copyRegin };
            commandBuffer.CopyBuffer(srcBuffer, dstBuffer, 1, regions);

            logicalDevice.EndSingleTimeCommands(graphicsQueue, commandPool, commandBuffer);
        }

        uint FindMemoryType(uint typeFilter, MemoryPropertyFlagBits properties)
        {
            var memProperties = physicalDevice.GetPhysicalDeviceMemoryProperties();

            for (uint i = 0; i < memProperties.MemoryTypeCount; i++)
            {
                var shift = (int)1 << (int)i;
                if ((typeFilter & shift) > 0 && memProperties.MemoryTypes[i].PropertyFlags == properties)
                {
                    return i;
                }
            }

            throw new Exception("failed to find suitable memory type!");
        }

        private void CreateDescriptorPool()
        {
            DescriptorPoolSize pool = new DescriptorPoolSize();
            pool.Type = DescriptorType.CombinedImageSampler;
            pool.DescriptorCount = (uint)swapchainImages.Length;

            DescriptorPoolCreateInfo poolInfo = new DescriptorPoolCreateInfo();
            poolInfo.PoolSizeCount = 1;
            poolInfo.PoolSizes = new[] { pool };
            poolInfo.MaxSets = (uint)swapchainImages.Length;

            descriptorPool = logicalDevice.CreateDescriptorPool(poolInfo);
        }

        private void CreateDescriptorSets()
        {
            var layouts = new List<DescriptorSetLayout>();
            foreach (var swapchainImage in swapchainImages)
            {
                layouts.Add(descriptorSetLayout);
            }

            DescriptorSetAllocateInfo allocInfo = new DescriptorSetAllocateInfo();
            allocInfo.DescriptorPool = descriptorPool;
            allocInfo.DescriptorSetCount = (uint)swapchainImages.Length;
            allocInfo.PSetLayouts = layouts.ToArray();

            descriptorSets = new DescriptorSet[allocInfo.DescriptorSetCount];
            if (logicalDevice.AllocateDescriptorSets(allocInfo, descriptorSets) != Result.Success)
            {
                throw new Exception("failed to allocate descriptor sets!");
            }

            for (int i = 0; i < swapchainImages.Length; ++i)
            {
                DescriptorImageInfo imageInfo = new DescriptorImageInfo();
                imageInfo.ImageLayout = ImageLayout.ShaderReadOnlyOptimal;
                imageInfo.ImageView = textureImageView;
                imageInfo.Sampler = textureSampler;

                WriteDescriptorSet descriptorWriter = new WriteDescriptorSet();
                descriptorWriter.DstSet = descriptorSets[i];
                descriptorWriter.DstBinding = 0;
                descriptorWriter.DstArrayElement = 0;
                descriptorWriter.DescriptorType = DescriptorType.CombinedImageSampler;
                descriptorWriter.DescriptorCount = 1;
                descriptorWriter.PImageInfo = new DescriptorImageInfo[] { imageInfo };

                logicalDevice.UpdateDescriptorSets(1, descriptorWriter, 0, out var copies);
            }
        }

        private void CreateCommandBuffers()
        {
            commandBuffers = new CommandBuffer[swapchainFramebuffers.Length];

            var allocInfo = new CommandBufferAllocateInfo();
            allocInfo.CommandPool = commandPool;
            allocInfo.Level = CommandBufferLevel.Primary;
            allocInfo.CommandBufferCount = (uint)swapchainFramebuffers.Length;

            commandBuffers = logicalDevice.AllocateCommandBuffers(allocInfo);

            renderPassInfos = new RenderPassBeginInfo[MAX_FRAMES_IN_FLIGHT];
            
            var renderPassInfo = new RenderPassBeginInfo();
            renderPassInfo.RenderPass = renderPass;
            renderPassInfo.Framebuffer = swapchainFramebuffers[0];
            renderPassInfo.RenderArea = new Rect2D();
            renderPassInfo.RenderArea.Offset = new Offset2D();
            renderPassInfo.RenderArea.Extent = swapChainExtent;
            
            ClearValue clearValue = new ClearValue();
            clearValue.Color = new ClearColorValue();
            clearValue.Color.Float32 = new float[4] { 0.5f, 0.7f, 1.0f, 0.0f };
            
            renderPassInfo.ClearValueCount = 1;
            renderPassInfo.PClearValues = new ClearValue[] { clearValue };
            
            renderPassInfos[0] = renderPassInfo;
            
            renderPassInfo = new RenderPassBeginInfo();
            renderPassInfo.RenderPass = renderPass;
            renderPassInfo.Framebuffer = swapchainFramebuffers[1];
            renderPassInfo.RenderArea = new Rect2D();
            renderPassInfo.RenderArea.Offset = new Offset2D();
            renderPassInfo.RenderArea.Extent = swapChainExtent;
            
            renderPassInfo.ClearValueCount = 1;
            renderPassInfo.PClearValues = new ClearValue[] { clearValue };
            
            renderPassInfos[1] = renderPassInfo;
            
            renderPassInfo = new RenderPassBeginInfo();
            renderPassInfo.RenderPass = renderPass;
            renderPassInfo.Framebuffer = swapchainFramebuffers[2];
            renderPassInfo.RenderArea = new Rect2D();
            renderPassInfo.RenderArea.Offset = new Offset2D();
            renderPassInfo.RenderArea.Extent = swapChainExtent;
            
            renderPassInfo.ClearValueCount = 1;
            renderPassInfo.PClearValues = new ClearValue[] { clearValue };
            
            renderPassInfos[2] = renderPassInfo;
        }

        private void CreateSyncObjects()
        {
            var semaphoreInfo = new SemaphoreCreateInfo();

            var fenceInfo = new FenceCreateInfo();
            fenceInfo.Flags = FenceCreateFlagBits.SignaledBit;

            imageAvailableSemaphores = logicalDevice.CreateSemaphores(semaphoreInfo, (uint)MAX_FRAMES_IN_FLIGHT);
            renderFinishedSemaphores = logicalDevice.CreateSemaphores(semaphoreInfo, (uint)MAX_FRAMES_IN_FLIGHT);
            inFlightFences = logicalDevice.CreateFences(fenceInfo, (uint)MAX_FRAMES_IN_FLIGHT);
        }

        ShaderModule CreateShaderModule(byte[] code)
        {
            ShaderModuleCreateInfo createInfo = new ShaderModuleCreateInfo();
            createInfo.CodeSize = (ulong)code.Length;
            createInfo.PCode = code;

            var shaderModule = logicalDevice.CreateShaderModule(createInfo);
            createInfo.Dispose();
            return shaderModule;
        }

        SurfaceFormatKHR ChooseSwapSurfaceFormat(SurfaceFormatKHR[] availableFormats)
        {
            if (availableFormats.Length == 1 && availableFormats[0].Format == Format.UNDEFINED)
            {
                return new SurfaceFormatKHR() { Format = Format.B8G8R8A8_UNORM, ColorSpace = ColorSpaceKHR.SrgbNonlinearKhr };
            }

            foreach (var availableFormat in availableFormats)
            {
                if (availableFormat.Format == Format.B8G8R8A8_UNORM && availableFormat.ColorSpace == ColorSpaceKHR.SrgbNonlinearKhr)
                {
                    return availableFormat;
                }
            }

            return availableFormats[0];
        }

        PresentModeKHR ChooseSwapPresentMode(PresentModeKHR[] availablePresentModes)
        {
            PresentModeKHR bestMode = PresentModeKHR.FifoKhr;

            foreach (var availablePresentMode in availablePresentModes)
            {
                if (availablePresentMode == PresentModeKHR.MailboxKhr)
                {
                    return availablePresentMode;
                }
                else if (availablePresentMode == PresentModeKHR.ImmediateKhr)
                {
                    bestMode = availablePresentMode;
                }
            }

            return bestMode;
        }

        Extent2D ChooseSwapExtent(SurfaceCapabilitiesKHR capabilities)
        {
            //if (capabilities.CurrentExtent.Width != uint.MaxValue)
            //{
            //    return capabilities.CurrentExtent;
            //}
            //else
            {
                Extent2D actualExtent = new Extent2D() { Width = (uint)ClientSize.Width, Height = (uint)ClientSize.Height };

                actualExtent.Width = Math.Max(capabilities.MinImageExtent.Width, Math.Min(capabilities.MaxImageExtent.Width, actualExtent.Width));
                actualExtent.Height = Math.Max(capabilities.MinImageExtent.Height, Math.Min(capabilities.MaxImageExtent.Height, actualExtent.Height));

                return actualExtent;
            }
        }

        private Vertex[] GetVertexArray()
        {
            Vertex[] v = new Vertex[]
            {
                new Vertex(){Position = new Vector2F(-0.5f, -0.5f), Color = new Vector3F(0.0f, 0.0f, 1.0f), TexCoord = new Vector2F(0.0f, 0.0f)},
                new Vertex(){Position = new Vector2F(0.5f, -0.5f), Color = new Vector3F(1.0f, 1.0f, 1.0f), TexCoord = new Vector2F(1.0f, 0.0f)},
                new Vertex(){Position = new Vector2F(0.5f, 0.5f), Color = new Vector3F(0.0f, 1.0f, 0.0f), TexCoord = new Vector2F(1.0f, 1.0f)},
                new Vertex(){Position = new Vector2F(-0.5f, 0.5f), Color = new Vector3F(1.0f, 0.0f, 1.0f), TexCoord = new Vector2F(0.0f, 1.0f)},
            };

            return v;
        }

        private Vertex[] GetVertexArray2()
        {
            Vertex[] v = new Vertex[]
            {
                new Vertex(){Position = new Vector2F(-1f, -0.25f), Color = new Vector3F(0.0f, 0.0f, 1.0f), TexCoord = new Vector2F(0.0f, 0.0f)},
                new Vertex(){Position = new Vector2F(1f, -0.25f), Color = new Vector3F(1.0f, 1.0f, 1.0f), TexCoord = new Vector2F(1.0f, 0.0f)},
                new Vertex(){Position = new Vector2F(1f, 0.25f), Color = new Vector3F(0.0f, 1.0f, 0.0f), TexCoord = new Vector2F(1.0f, 1.0f)},
                new Vertex(){Position = new Vector2F(-1f, 0.25f), Color = new Vector3F(1.0f, 0.0f, 1.0f), TexCoord = new Vector2F(0.0f, 1.0f)},
            };

            return v;
        }

        private UInt32[] GetIndices()
        {
            return new UInt32[] { 0, 1, 2, 0, 2, 3 };
        }

        private VertexInputBindingDescription GetBindingDescription<T>() where T : struct
        {
            var decr = new VertexInputBindingDescription();
            decr.Binding = 0;
            decr.Stride = (uint)Marshal.SizeOf<T>();
            decr.InputRate = VertexInputRate.Vertex;

            return decr;
        }

        private VertexInputAttributeDescription[] GetVertexAttributeDescription<T>()
        {
            var fields = typeof(T).GetFields();

            var attributes = new List<VertexInputAttributeDescription>();
            uint location = 0;

            foreach (var field in fields)
            {
                var desc = new VertexInputAttributeDescription();
                desc.Binding = 0;
                desc.Location = location;
                desc.Format = GetFormat(Marshal.SizeOf(field.FieldType));
                desc.Offset = (uint)Marshal.OffsetOf<T>(field.Name).ToInt32();
                location++;
                attributes.Add(desc);
            }

            return attributes.ToArray();
        }

        private Format GetFormat(int size)
        {
            switch (size)
            {
                case 4:
                    return Format.R32_SFLOAT;
                case 8:
                    return Format.R32G32_SFLOAT;
                case 12:
                    return Format.R32G32B32_SFLOAT;
                case 16:
                    return Format.R32G32B32A32_SFLOAT;

                default:
                    throw new Exception($"size {size} is not supported");
            }
        }
    }
}

