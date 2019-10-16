﻿using AdamantiumVulkan.Core;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Buffer = AdamantiumVulkan.Core.Buffer;
using Image = AdamantiumVulkan.Core.Image;
using ImageLayout = AdamantiumVulkan.Core.ImageLayout;
using Semaphore = AdamantiumVulkan.Core.Semaphore;
using CoreInterop = AdamantiumVulkan.Core.Interop;
using System.Collections.Generic;
using AdamantiumVulkan.Windows;
using Constants = AdamantiumVulkan.Core.Constants;
using System.IO;
using Adamantium.Mathematics;
using AdamantiumVulkan.SPIRV.Cross;
using AdamantiumVulkan;

namespace VulkanEngineTestCore
{
    partial class Form1
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
            debugCallback = DebugCallback;

            SpvcMslSamplerYcbcrConversion test = new SpvcMslSamplerYcbcrConversion();
            test.Swizzle = new SpvcMslComponentSwizzle[4];
            test.Swizzle[0] = SpvcMslComponentSwizzle.R;

            var ptr = MarshalUtils.MarshalStructToPtr(test);

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

        const int MAX_FRAMES_IN_FLIGHT = 2;

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

        private CoreInterop.PFN_vkDebugUtilsMessengerCallbackEXT debugCallback;

        private bool enableValidationLayers;

        private string[] validationLayers = new[]
        {
          //"VK_LAYER_LUNARG_parameter_validation",
          "VK_LAYER_LUNARG_core_validation",
          "VK_LAYER_LUNARG_standard_validation",
          //"VK_LAYER_LUNARG_object_tracker",
          //"VK_LAYER_LUNARG_monitor",
          //"VK_LAYER_LUNARG_assistant_layer",
          //"VK_LAYER_AMD_switchable_graphics"
        };

        private string[] deviceExtensions = new[] { Constants.VK_KHR_SWAPCHAIN_EXTENSION_NAME };

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
            return PeekMessage(out result, IntPtr.Zero, (uint)0, (uint)0, (uint)0) == 0;
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
        }

        Stopwatch timer;
        double fps = 0;
        int frames = 0;
        CommandBuffer[] renderCommandBuffers = new CommandBuffer[1];
        CommandBufferBeginInfo beginInfo;
        RenderPassBeginInfo[] renderPassInfos;
        UInt64[] offsets = new UInt64[0];
        private void Render()
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
            beginInfo.Flags = (uint)CommandBufferUsageFlagBits.SimultaneousUseBit;

            var res = commandBuffer.ResetCommandBuffer(0);
            res = commandBuffer.BeginCommandBuffer(beginInfo);
            if (res != Result.Success)
            {
                MessageBox.Show("failed to begin recording command buffer!");
                throw new Exception();
            }

            renderPassInfos = new RenderPassBeginInfo[2];

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

            commandBuffer.CmdBeginRenderPass(renderPassInfos[imageIndex], SubpassContents.Inline);

            commandBuffer.CmdBindPipeline(PipelineBindPoint.Graphics, graphicsPipeline);

            //Buffer[] vertexBuffers = new Buffer[] { vertexBuffer };
            ulong offset = 0;
            commandBuffer.CmdBindVertexBuffers(0, 1, vertexBuffer, ref offset);

            commandBuffer.CmdBindIndexBuffer(indexBuffer, 0, IndexType.Uint32);

            commandBuffer.CmdBindDescriptorSets(PipelineBindPoint.Graphics, pipelineLayout, 0, 1, descriptorSets[imageIndex], 0, 0);

            commandBuffer.CmdDrawIndexed((uint)indices.Length, 1, 0, 0, 0);

            //Buffer[] vertexBuffers2 = new Buffer[] { vertexBuffer2 };
            commandBuffer.CmdBindVertexBuffers(0, 1, vertexBuffer2, ref offset);

            commandBuffer.CmdBindIndexBuffer(indexBuffer, 0, IndexType.Uint32);

            commandBuffer.CmdBindDescriptorSets(PipelineBindPoint.Graphics, pipelineLayout, 0, 1, descriptorSets[imageIndex], 0, 0);

            commandBuffer.CmdDrawIndexed((uint)indices.Length, 1, 0, 0, 0);


            commandBuffer.CmdEndRenderPass();

            res = commandBuffer.EndCommandBuffer();
            if (res != Result.Success)
            {
                MessageBox.Show("failed to record command buffer!");
                throw new Exception();
            }

            var submitInfo = new SubmitInfo();

            Semaphore[] waitSemaphores = new[] { imageAvailableSemaphores[currentFrame] };
            uint[] waitStages = new[] { (uint)PipelineStageFlagBits.ColorAttachmentOutputBit };
            submitInfo.WaitSemaphoreCount = 1;
            submitInfo.PWaitSemaphores = waitSemaphores;
            submitInfo.PWaitDstStageMask = waitStages;

            submitInfo.CommandBufferCount = 1;
            submitInfo.PCommandBuffers = renderCommandBuffers;

            Semaphore[] signalSemaphores = new[] { renderFinishedSemaphores[currentFrame] };
            
            submitInfo.SignalSemaphoreCount = 1;
            submitInfo.PSignalSemaphores = signalSemaphores;

            submitInfos[0] = submitInfo;

            result = logicalDevice.ResetFences(1, renderFence);

            result = graphicsQueue.QueueSubmit(1, submitInfos, inFlightFences[currentFrame]);
            if (result != Result.Success)
            {
                MessageBox.Show($"failed to submit draw command buffer! Result was {result}");
                throw new Exception();
            }

            var presentInfo = new PresentInfoKHR();

            presentInfo.WaitSemaphoreCount = 1;
            presentInfo.PWaitSemaphores = signalSemaphores;

            SwapchainKHR[] swapchains = { swapchain };
            presentInfo.SwapchainCount = 1;
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
        private void CreateInstance()
        {
            var appInfo = new ApplicationInfo();
            appInfo.PApplicationName = "Hello Triangle";
            appInfo.ApplicationVersion = AdamantiumVulkan.Core.Constants.VK_MAKE_VERSION(1, 0, 0);
            appInfo.PEngineName = "Adamantium Engine";
            appInfo.EngineVersion = Constants.VK_MAKE_VERSION(1, 0, 0);
            appInfo.ApiVersion = Constants.VK_MAKE_VERSION(1, 0, 0);

            DebugUtilsMessengerCreateInfoEXT debugInfo = new DebugUtilsMessengerCreateInfoEXT();
            debugInfo.MessageSeverity = (uint)(DebugUtilsMessageSeverityFlagBitsEXT.VerboseBitExt | DebugUtilsMessageSeverityFlagBitsEXT.WarningBitExt | DebugUtilsMessageSeverityFlagBitsEXT.ErrorBitExt);
            debugInfo.MessageType = (uint)(DebugUtilsMessageTypeFlagBitsEXT.GeneralBitExt | DebugUtilsMessageTypeFlagBitsEXT.ValidationBitExt | DebugUtilsMessageTypeFlagBitsEXT.PerformanceBitExt);
            debugInfo.PfnUserCallback = debugCallback;

            var createInfo = new InstanceCreateInfo();
            createInfo.PApplicationInfo = appInfo;

            var layersAvailable = Instance.EnumerateInstanceLayerProperties();
            var extensions = Instance.EnumerateInstanceExtensionProperties();

            string[] ext = new[] { "VK_KHR_surface", "VK_KHR_win32_surface", "VK_EXT_debug_utils" };
            //createInfo.EnabledExtensionCount = (uint)extensions.Length;
            //createInfo.PpEnabledExtensionNames = extensions.Select(x => x.ExtensionName).ToArray();
            createInfo.EnabledExtensionCount = (uint)ext.Length;
            createInfo.PpEnabledExtensionNames = ext;

            if (enableValidationLayers)
            {
                createInfo.EnabledLayerCount = (uint)validationLayers.Length;
                createInfo.PpEnabledLayerNames = validationLayers;
            }

            instance = Instance.Create(createInfo);

            createInfo.Dispose();
        }

        Result CreateDebugUtilsMessengerEXT(Instance instance, DebugUtilsMessengerCreateInfoEXT pCreateInfo, AllocationCallbacks pAllocator, out DebugUtilsMessengerEXT pDebugMessenger)
        {
            pDebugMessenger = null;
            //(PFN_vkCreateDebugUtilsMessengerEXT)
            var ptr = instance.GetInstanceProcAddr("vkCreateDebugUtilsMessengerEXT");
            var func = Marshal.GetDelegateForFunctionPointer<CoreInterop.PFN_vkCreateDebugUtilsMessengerEXT>(ptr);
            if (func != null)
            {
                var result = func(instance, pCreateInfo.ToInternal(), IntPtr.Zero, out var pDebugMessenger_t);
                pCreateInfo.Dispose();
                pDebugMessenger = pDebugMessenger_t;
                return result;
            }
            else
            {
                return Result.ErrorExtensionNotPresent;
            }
        }

        void DestroyDebugUtilsMessengerEXT(Instance instance, DebugUtilsMessengerEXT debugMessenger, AllocationCallbacks pAllocator = null)
        {
            var ptr = instance.GetInstanceProcAddr("vkDestroyDebugUtilsMessengerEXT");
            var func = Marshal.GetDelegateForFunctionPointer<CoreInterop.PFN_vkDestroyDebugUtilsMessengerEXT>(ptr);
            if (func != null)
            {
                func(instance, debugMessenger, IntPtr.Zero);
            }
        }

        private void SetupDebugMessenger()
        {
            if (!enableValidationLayers)
            {
                return;
            }

            DebugUtilsMessengerCreateInfoEXT debugInfo = new DebugUtilsMessengerCreateInfoEXT();
            debugInfo.MessageSeverity = (uint)(DebugUtilsMessageSeverityFlagBitsEXT.VerboseBitExt | DebugUtilsMessageSeverityFlagBitsEXT.WarningBitExt | DebugUtilsMessageSeverityFlagBitsEXT.ErrorBitExt);
            debugInfo.MessageType = (uint)(DebugUtilsMessageTypeFlagBitsEXT.GeneralBitExt | DebugUtilsMessageTypeFlagBitsEXT.ValidationBitExt | DebugUtilsMessageTypeFlagBitsEXT.PerformanceBitExt);
            debugInfo.PfnUserCallback = debugCallback;

            var result = CreateDebugUtilsMessengerEXT(instance, debugInfo, null, out debugMessenger);

            if (result != Result.Success)
            {
                MessageBox.Show("Failed to set up debug messenger!");
                throw new Exception();
            }
        }

        private uint DebugCallback(DebugUtilsMessageSeverityFlagBitsEXT messageSeverity, uint messageTypes, AdamantiumVulkan.Core.Interop.VkDebugUtilsMessengerCallbackDataEXT pCallbackData, IntPtr pUserData)
        {
            Console.WriteLine(Marshal.PtrToStringAnsi(pCallbackData.pMessage));
            return 1;
        }

        private void PickPhysicalDevice()
        {
            var devices = instance.EnumeratePhysicalDevices();
            physicalDevice = devices[0];
            var deviceProperties = physicalDevice.GetPhysicalDeviceProperties();
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

            var deviceFeatures = physicalDevice.GetPhysicalDeviceFeatures();
            deviceFeatures.SamplerAnisotropy = true;

            var createInfo = new DeviceCreateInfo();
            createInfo.QueueCreateInfoCount = (uint)queueInfos.Count;
            createInfo.PQueueCreateInfos = queueInfos.ToArray();
            createInfo.PEnabledFeatures = deviceFeatures;
            createInfo.EnabledExtensionCount = (uint)deviceExtensions.Length;
            createInfo.PpEnabledExtensionNames = deviceExtensions;

            if (enableValidationLayers)
            {
                createInfo.EnabledLayerCount = (uint)validationLayers.Length;
                createInfo.PpEnabledLayerNames = validationLayers;
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

                bool presentSupport = false;
                device.GetPhysicalDeviceSurfaceSupportKHR(i, surface, ref presentSupport);

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

            uint imageCount = swapChainSupport.Capabilities.MinImageCount + 1;
            if (swapChainSupport.Capabilities.MaxImageCount > 0 && imageCount > swapChainSupport.Capabilities.MaxImageCount)
            {
                imageCount = swapChainSupport.Capabilities.MaxImageCount;
            }

            SwapchainCreateInfoKHR createInfo = new SwapchainCreateInfoKHR();
            createInfo.Surface = surface;

            createInfo.MinImageCount = imageCount;
            createInfo.ImageFormat = surfaceFormat.Format;
            createInfo.ImageColorSpace = surfaceFormat.ColorSpace;
            createInfo.ImageExtent = extent;
            createInfo.ImageArrayLayers = 1;
            createInfo.ImageUsage = (uint)ImageUsageFlagBits.ColorAttachmentBit;
            createInfo.Flags = (uint)SwapchainCreateFlagBitsKHR.SplitInstanceBindRegionsBitKhr;

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
                subresourceRange.AspectMask = (uint)ImageAspectFlagBits.ColorBit;
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
            samplerLayoutBinding.StageFlags = (uint)ShaderStageFlagBits.FragmentBit;

            bindings.Add(samplerLayoutBinding);

            DescriptorSetLayoutCreateInfo layoutInfo = new DescriptorSetLayoutCreateInfo();
            layoutInfo.BindingCount = 1;
            layoutInfo.PBindings = bindings.ToArray();

            descriptorSetLayout = logicalDevice.CreateDescriptorSetLayout(layoutInfo, null);
        }

        private void CreateGraphicsPipeline()
        {
            var vertexContent = File.ReadAllBytes(@"shaders\vert.spv");
            var fragmentContent = File.ReadAllBytes(@"shaders\frag.spv");

            var vertexShaderModule = CreateShaderModule(vertexContent);
            var fragmentShaderModule = CreateShaderModule(fragmentContent);

            var vertShaderStageInfo = new PipelineShaderStageCreateInfo();
            vertShaderStageInfo.Stage = ShaderStageFlagBits.VertexBit;
            vertShaderStageInfo.Module = vertexShaderModule;
            vertShaderStageInfo.PName = "main";

            var fragShaderStageInfo = new PipelineShaderStageCreateInfo();
            fragShaderStageInfo.Stage = ShaderStageFlagBits.FragmentBit;
            fragShaderStageInfo.Module = fragmentShaderModule;
            fragShaderStageInfo.PName = "main";

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
            viewportState.PViewports = viewport;
            viewportState.ScissorCount = 1;
            viewportState.PScissors = scissor;

            var rasterizer = new PipelineRasterizationStateCreateInfo();
            rasterizer.DepthClampEnable = false;
            rasterizer.RasterizerDiscardEnable = false;
            rasterizer.PolygonMode = PolygonMode.Fill;
            rasterizer.LineWidth = 1.0f;
            rasterizer.CullMode = (uint)CullModeFlagBits.BackBit;
            rasterizer.FrontFace = FrontFace.Clockwise;
            rasterizer.DepthBiasEnable = false;

            var multisampling = new PipelineMultisampleStateCreateInfo();
            multisampling.SampleShadingEnable = false;
            multisampling.RasterizationSamples = SampleCountFlagBits._1Bit;

            var colorBlendAttachment = new PipelineColorBlendAttachmentState();
            colorBlendAttachment.ColorWriteMask = (uint)(ColorComponentFlagBits.RBit | ColorComponentFlagBits.GBit | ColorComponentFlagBits.BBit | ColorComponentFlagBits.ABit);
            colorBlendAttachment.BlendEnable = false;

            var colorBlending = new PipelineColorBlendStateCreateInfo();
            colorBlending.LogicOpEnable = false;
            colorBlending.LogicOp = LogicOp.Copy;
            colorBlending.AttachmentCount = 1;
            colorBlending.PAttachments = colorBlendAttachment;
            colorBlending.BlendConstants = new float[4];
            colorBlending.BlendConstants[0] = 0.0f;
            colorBlending.BlendConstants[1] = 0.0f;
            colorBlending.BlendConstants[2] = 0.0f;
            colorBlending.BlendConstants[3] = 0.0f;

            var pipelineLayoutInfo = new PipelineLayoutCreateInfo();
            pipelineLayoutInfo.SetLayoutCount = 1;
            pipelineLayoutInfo.PSetLayouts = new DescriptorSetLayout[] { descriptorSetLayout };

            pipelineLayout = logicalDevice.CreatePipelineLayout(pipelineLayoutInfo);

            var pipelineInfo = new GraphicsPipelineCreateInfo();
            pipelineInfo.StageCount = 2;
            pipelineInfo.PStages = shaderStages;
            pipelineInfo.PVertexInputState = vertexInputInfo;
            pipelineInfo.PInputAssemblyState = inputAssembly;
            pipelineInfo.PViewportState = viewportState;
            pipelineInfo.PRasterizationState = rasterizer;
            pipelineInfo.PMultisampleState = multisampling;
            pipelineInfo.PColorBlendState = colorBlending;
            pipelineInfo.Layout = pipelineLayout;
            pipelineInfo.RenderPass = renderPass;
            pipelineInfo.Subpass = 0;

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
            poolInfo.Flags = (uint)CommandPoolCreateFlagBits.ResetCommandBufferBit;
            commandPool = logicalDevice.CreateCommandPool(poolInfo);
        }

        void СreateTextureImageView()
        {
            textureImageView = СreateImageView(textureImage, Format.R8G8B8A8_UNORM);
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

        ImageView СreateImageView(Image image, Format format)
        {
            ImageViewCreateInfo viewInfo = new ImageViewCreateInfo();
            viewInfo.Image = image;
            viewInfo.ViewType = ImageViewType._2d;
            viewInfo.Format = format;
            viewInfo.SubresourceRange = new ImageSubresourceRange();
            viewInfo.SubresourceRange.AspectMask = (uint)ImageAspectFlagBits.ColorBit;
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

            //Buffer stagingBuffer;
            //DeviceMemory stagingBufferMemory;
            //CreateBuffer((ulong)img.TotalSizeInBytes, BufferUsageFlagBits.TransferSrcBit, MemoryPropertyFlagBits.HostVisibleBit | MemoryPropertyFlagBits.HostCoherentBit, out var stagingBuffer, out var stagingBufferMemory);

            //unsafe
            //{
            //    var data = logicalDevice.MapMemory(stagingBufferMemory, 0, (ulong) img.TotalSizeInBytes, 0);
            //    System.Buffer.MemoryCopy(img.DataPointer.ToPointer(), data.ToPointer(), (long)img.TotalSizeInBytes, (long)img.TotalSizeInBytes);
            //    logicalDevice.UnmapMemory(stagingBufferMemory);
            //}

            //var imageDescr = img.Description;
            //img?.Dispose();

            //ImageUsageFlagBits usage = ImageUsageFlagBits.TransferDstBit | ImageUsageFlagBits.SampledBit;
            //CreateImage((uint)imageDescr.Width, (uint)imageDescr.Height, imageDescr.Format, ImageTiling.Optimal, usage, MemoryPropertyFlagBits.DeviceLocalBit, out textureImage, out textureImageMemory);

            //TransitionImageLayout(textureImage, imageDescr.Format, ImageLayout.Undefined, ImageLayout.TransferDstOptimal);
            //CopyBufferToImage(stagingBuffer, textureImage, (uint)imageDescr.Width, (uint)imageDescr.Height);
            //TransitionImageLayout(textureImage, imageDescr.Format,  ImageLayout.TransferDstOptimal, ImageLayout.ShaderReadOnlyOptimal);

            //logicalDevice.DestroyBuffer(stagingBuffer);
            //logicalDevice.FreeMemory(stagingBufferMemory);

            var imageDescr = img.Description;
            ImageUsageFlagBits usage = ImageUsageFlagBits.TransferDstBit | ImageUsageFlagBits.SampledBit;
            CreateImage((uint)imageDescr.Width, (uint)imageDescr.Height, imageDescr.Format, ImageTiling.Linear, ImageUsageFlagBits.TransferSrcBit, MemoryPropertyFlagBits.HostVisibleBit | MemoryPropertyFlagBits.HostCoherentBit, out var stagingTextureImage, out var staingTextureImageMemory);

            unsafe
            {
                var data = logicalDevice.MapMemory(staingTextureImageMemory, 0, (ulong)img.TotalSizeInBytes, 0);
                System.Buffer.MemoryCopy(img.DataPointer.ToPointer(), data.ToPointer(), (long)img.TotalSizeInBytes, (long)img.TotalSizeInBytes);
                logicalDevice.UnmapMemory(staingTextureImageMemory);
                img?.Dispose();
            }

            CreateImage((uint)imageDescr.Width, (uint)imageDescr.Height, imageDescr.Format, ImageTiling.Optimal, usage, MemoryPropertyFlagBits.DeviceLocalBit, out textureImage, out textureImageMemory);

            TransitionImageLayout(stagingTextureImage, imageDescr.Format, ImageLayout.Preinitialized, ImageLayout.TransferSrcOptimal);
            TransitionImageLayout(textureImage, imageDescr.Format, ImageLayout.Undefined, ImageLayout.TransferDstOptimal);
            CopyImageToImage(stagingTextureImage, textureImage, (uint)imageDescr.Width, (uint)imageDescr.Height);
            TransitionImageLayout(textureImage, imageDescr.Format, ImageLayout.TransferDstOptimal, ImageLayout.ShaderReadOnlyOptimal);

            stagingTextureImage.Destroy(logicalDevice);
            staingTextureImageMemory.FreeMemory(logicalDevice);
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
            imageInfo.Usage = (uint)usage;
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

        void TransitionImageLayout(Image image, Format format, ImageLayout oldLayout, ImageLayout newLayout)
        {
            CommandBuffer commandBuffer = logicalDevice.BeginSingleTimeCommand(commandPool);

            ImageMemoryBarrier barrier = new ImageMemoryBarrier();
            barrier.OldLayout = oldLayout;
            barrier.NewLayout = newLayout;
            barrier.SrcQueueFamilyIndex = (~0U);
            barrier.DstQueueFamilyIndex = (~0U);
            barrier.Image = image;
            barrier.SubresourceRange = new ImageSubresourceRange();
            barrier.SubresourceRange.AspectMask = (uint)ImageAspectFlagBits.ColorBit;
            barrier.SubresourceRange.BaseMipLevel = 0;
            barrier.SubresourceRange.LevelCount = 1;
            barrier.SubresourceRange.BaseArrayLayer = 0;
            barrier.SubresourceRange.LayerCount = 1;

            PipelineStageFlagBits sourceStage;
            PipelineStageFlagBits destinationStage;

            if ((oldLayout == ImageLayout.Undefined || oldLayout == ImageLayout.Preinitialized) && newLayout == ImageLayout.TransferDstOptimal)
            {
                barrier.SrcAccessMask = 0;
                barrier.DstAccessMask = (uint)AccessFlagBits.TransferWriteBit;

                sourceStage = PipelineStageFlagBits.TopOfPipeBit;
                destinationStage = PipelineStageFlagBits.TransferBit;
            }
            else if ((oldLayout == ImageLayout.Undefined || oldLayout == ImageLayout.Preinitialized) && newLayout == ImageLayout.TransferSrcOptimal)
            {
                barrier.SrcAccessMask = 0;
                barrier.DstAccessMask = (uint)AccessFlagBits.TransferWriteBit;

                sourceStage = PipelineStageFlagBits.TopOfPipeBit;
                destinationStage = PipelineStageFlagBits.TransferBit;
            }
            else if (oldLayout == ImageLayout.TransferSrcOptimal && newLayout == ImageLayout.ShaderReadOnlyOptimal)
            {
                barrier.SrcAccessMask = (uint)AccessFlagBits.TransferWriteBit;
                barrier.DstAccessMask = (uint)AccessFlagBits.ShaderReadBit;

                sourceStage = PipelineStageFlagBits.TransferBit;
                destinationStage = PipelineStageFlagBits.FragmentShaderBit;
            }
            else if (oldLayout == ImageLayout.TransferDstOptimal && newLayout == ImageLayout.ShaderReadOnlyOptimal)
            {
                barrier.SrcAccessMask = (uint)AccessFlagBits.TransferWriteBit;
                barrier.DstAccessMask = (uint)AccessFlagBits.ShaderReadBit;

                sourceStage = PipelineStageFlagBits.TransferBit;
                destinationStage = PipelineStageFlagBits.FragmentShaderBit;
            }
            else
            {
                throw new Exception("unsupported layout transition!");
            }

            commandBuffer.CmdPipelineBarrier(
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
            region.ImageSubresource.AspectMask = (uint)ImageAspectFlagBits.ColorBit;
            region.ImageSubresource.MipLevel = 0;
            region.ImageSubresource.BaseArrayLayer = 0;
            region.ImageSubresource.LayerCount = 1;
            region.ImageOffset = new Offset3D() { X = 0, Y = 0, Z = 0};
            region.ImageExtent = new Extent3D() {Width = width, Height = height, Depth = 1}; 
            
            commandBuffer.CmdCopyBufferToImage(buffer, image, ImageLayout.TransferDstOptimal, 1, region);
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
            region.SrcSubresource.AspectMask = (uint)ImageAspectFlagBits.ColorBit;
            region.DstSubresource.LayerCount = 1;
            region.DstSubresource.AspectMask = (uint)ImageAspectFlagBits.ColorBit;
            region.Extent = new Extent3D() { Width = width, Height = height, Depth = 1 };

            commandBuffer.CmdCopyImage(source, ImageLayout.TransferSrcOptimal, destination, ImageLayout.TransferDstOptimal, 1, region);
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
                System.Buffer.MemoryCopy(handle.ToPointer(), data.ToPointer(), (long)bufferSize, (long)bufferSize);
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
                System.Buffer.MemoryCopy(handle.ToPointer(), data.ToPointer(), (long)bufferSize, (long)bufferSize);
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
                System.Buffer.MemoryCopy(handle.ToPointer(), data.ToPointer(), (long)bufferSize, (long)bufferSize);
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
            bufferInfo.Usage = (uint)usage;
            bufferInfo.SharingMode = SharingMode.Exclusive;

            buffer = logicalDevice.CreateBuffer(bufferInfo);

            MemoryRequirements memoryRequirements = logicalDevice.GetBufferMemoryRequirements(buffer);

            MemoryAllocateInfo allocInfo = new MemoryAllocateInfo();
            allocInfo.AllocationSize = memoryRequirements.Size;

            var memProperties = physicalDevice.GetPhysicalDeviceMemoryProperties();
            for (uint i = 0; i < memProperties.MemoryTypeCount; i++)
            {
                if (((memoryRequirements.MemoryTypeBits >> (int)i) & 1) == 1
                    && memProperties.MemoryTypes[i].PropertyFlags == (uint)memoryProperties)
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
            commandBuffer.CmdCopyBuffer(srcBuffer, dstBuffer, 1, regions);

            logicalDevice.EndSingleTimeCommands(graphicsQueue, commandPool, commandBuffer);
        }

        uint FindMemoryType(uint typeFilter, MemoryPropertyFlagBits properties)
        {
            var memProperties = physicalDevice.GetPhysicalDeviceMemoryProperties();

            for (uint i = 0; i < memProperties.MemoryTypeCount; i++)
            {
                var shift = (int)1 << (int)i;
                if ((typeFilter & shift) > 0 && memProperties.MemoryTypes[i].PropertyFlags == (uint)properties)
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
            poolInfo.PPoolSizes = pool;
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
                descriptorWriter.PImageInfo = imageInfo;

                logicalDevice.UpdateDescriptorSets(1, descriptorWriter, 0, null);
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

            renderPassInfos = new RenderPassBeginInfo[2];

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

            //for (int i = 0; i < commandBuffers.Length; i++)
            //{
            //    var commandBuffer = commandBuffers[i];
            //    var beginInfo = new CommandBufferBeginInfo();
            //    beginInfo.Flags = (uint)CommandBufferUsageFlagBits.SimultaneousUseBit;

            //    var result = commandBuffer.BeginCommandBuffer(beginInfo);
            //    if (result != Result.Success)
            //    {
            //        MessageBox.Show("failed to begin recording command buffer!");
            //        throw new Exception();
            //    }

            //    var renderPassInfo = new RenderPassBeginInfo();
            //    renderPassInfo.RenderPass = renderPass;
            //    renderPassInfo.Framebuffer = swapchainFramebuffers[i];
            //    renderPassInfo.RenderArea = new Rect2D();
            //    renderPassInfo.RenderArea.Offset = new Offset2D();
            //    renderPassInfo.RenderArea.Extent = swapChainExtent;

            //    ClearValue clearValue = new ClearValue();
            //    clearValue.Color = new ClearColorValue();
            //    clearValue.Color.Float32 = new float[4] { 0.5f, 0.7f, 1.0f, 0.0f };

            //    renderPassInfo.ClearValueCount = 1;
            //    renderPassInfo.PClearValues = new ClearValue[] { clearValue };
            //    commandBuffer.CmdBeginRenderPass(renderPassInfo, SubpassContents.Inline);

            //    commandBuffer.CmdBindPipeline(PipelineBindPoint.Graphics, graphicsPipeline);

            //    UInt64[] offsets = new UInt64[0];
            //    Buffer[] vertexBuffers = new Buffer[] { vertexBuffer };
            //    commandBuffer.CmdBindVertexBuffers(0, 1, vertexBuffers, offsets);

            //    commandBuffer.CmdBindIndexBuffer(indexBuffer, 0, IndexType.Uint32);

            //    commandBuffer.CmdBindDescriptorSets(PipelineBindPoint.Graphics, pipelineLayout, 0, 1, descriptorSets[i], 0, 0);

            //    commandBuffer.CmdDrawIndexed((uint)indices.Length, 1, 0, 0, 0);

            //    commandBuffer.CmdEndRenderPass();

            //    result = commandBuffer.EndCommandBuffer();
            //    if (result != Result.Success)
            //    {
            //        MessageBox.Show("failed to record command buffer!");
            //        throw new Exception();
            //    }
            //}
        }

        private void CreateSyncObjects()
        {
            var semaphoreInfo = new SemaphoreCreateInfo();

            var fenceInfo = new FenceCreateInfo();
            fenceInfo.Flags = (uint)FenceCreateFlagBits.SignaledBit;

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
                return new SurfaceFormatKHR() { Format = Format.B8G8R8A8_UNORM, ColorSpace = ColorSpaceKHR.ColorspaceSrgbNonlinearKhr };
            }

            foreach (var availableFormat in availableFormats)
            {
                if (availableFormat.Format == Format.B8G8R8A8_UNORM && availableFormat.ColorSpace == ColorSpaceKHR.ColorspaceSrgbNonlinearKhr)
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
            if (capabilities.CurrentExtent.Width != uint.MaxValue)
            {
                return capabilities.CurrentExtent;
            }
            else
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

