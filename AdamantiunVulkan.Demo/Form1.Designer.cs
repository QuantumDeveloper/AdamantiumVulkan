using AdamantiumVulkan.Core;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using VulkanEngineTestCore.Vectors;
using Buffer = AdamantiumVulkan.Core.Buffer;
using Image = AdamantiumVulkan.Core.Image;
using ImageLayout = AdamantiumVulkan.Core.ImageLayout;
using Semaphore = AdamantiumVulkan.Core.Semaphore;
using CoreInterop = AdamantiumVulkan.Core.Interop;
using System.Collections.Generic;
using AdamantiumVulkan.Windows;
using Constants = AdamantiumVulkan.Core.Constants;
using System.IO;

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
            this.ClientSize = new System.Drawing.Size(800, 600);
            enableValidationLayers = true;
            _pauseEvent = new AutoResetEvent(false);
            InitVulkan();
            ClientSizeChanged += Form1_ClientSizeChanged;
            thread = new Thread(RenderThread);
            thread.Start();
            FormClosing += Form1_FormClosing;
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExit;

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
        AdamantiumVulkan.Core.Interop.Extent2D swapChainExtent;

        RenderPass renderPass;
        PipelineLayout pipelineLayout;
        Pipeline graphicsPipeline;

        Buffer vertexBuffer;
        DeviceMemory vertexBufferMemory;

        Buffer indexBuffer;
        DeviceMemory indexBufferMemory;

        CommandPool commandPool;
        CommandBuffer[] commandBuffers;

        Semaphore[] imageAvailableSemaphores;
        Semaphore[] renderFinishedSemaphores;
        Fence[] inFlightFences;
        int currentFrame = 0;

        Fence[] renderFence = new Fence[1];
        SubmitInfo[] submitInfos = new SubmitInfo[1];
        Vertex[] vertices;
        UInt32[] indices;

        private bool enableValidationLayers;

        private string[] validationLayers = new[]
        { "VK_LAYER_LUNARG_standard_validation",
          //"VK_LAYER_LUNARG_parameter_validation",
          //"VK_LAYER_LUNARG_object_tracker",
          "VK_LAYER_LUNARG_monitor",
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
            public Point Location;
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
            CreateVkInstance();
            SetupDebugMessenger();
            CreateSurface();
            PickPhysicalDevice();
            CreateLogicalDevice();
            CreateSwapchain();
            CreateImageViews();
            CreateRenderPass();
            CreateGraphicsPipeline();
            CreateFramebuffers();
            CreateCommandPool();
            CreateVertexBuffer();
            CreateIndexBuffer();
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
            CreateRenderPass();
            CreateGraphicsPipeline();
            CreateFramebuffers();
            CreateCommandBuffers();
        }

        private void Cleanup()
        {
            CleanupSwapChain();

            logicalDevice.DestroyBuffer(vertexBuffer);
            logicalDevice.FreeMemory(vertexBufferMemory);

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
                logicalDevice.DestroyFramebuffer(buffer);
            }

            logicalDevice.FreeCommandBuffers(commandPool, (uint)commandBuffers.Length, commandBuffers);
            logicalDevice.DestroyPipeline(graphicsPipeline);
            logicalDevice.DestroyPipelineLayout(pipelineLayout);
            logicalDevice.DestroyRenderPass(renderPass);

            foreach (var view in swapchainImageViews)
            {
                logicalDevice.DestroyImageView(view);
            }

            logicalDevice.DestroySwapchainKHR(swapchain);
        }

        Stopwatch timer;
        double fps = 0;
        int frames = 0;
        CommandBuffer[] renderCommandBuffers = new CommandBuffer[1];
        private void Render()
        {
            if (WindowState == FormWindowState.Minimized)
            {
                _pauseEvent.WaitOne();
            }

            renderFence[0] = inFlightFences[currentFrame];
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
            var submitInfo = new SubmitInfo();
            submitInfo.SType = StructureType.SubmitInfo;

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
                MessageBox.Show("failed to submit draw command buffer!");
                throw new Exception();
            }

            var presentInfo = new PresentInfoKHR();
            presentInfo.SType = StructureType.PresentInfoKhr;

            presentInfo.WaitSemaphoreCount = 1;
            presentInfo.PWaitSemaphores = signalSemaphores;

            SwapchainKHR[] swapchains = { swapchain };
            presentInfo.SwapchainCount = 1;
            presentInfo.PSwapchains = swapchains;
            presentInfo.PImageIndices = imageIndex;

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
        private void CreateVkInstance()
        {
            var appInfo = new ApplicationInfo();
            appInfo.SType = StructureType.ApplicationInfo;
            appInfo.PApplicationName = "Hello Triangle";
            appInfo.ApplicationVersion = AdamantiumVulkan.Core.Constants.VK_MAKE_VERSION(1, 0, 0);
            appInfo.PEngineName = "Adamantium Renderer";
            appInfo.EngineVersion = Constants.VK_MAKE_VERSION(1, 0, 0);
            appInfo.ApiVersion = Constants.VK_MAKE_VERSION(1, 0, 0);

            DebugUtilsMessengerCreateInfoEXT debugInfo = new DebugUtilsMessengerCreateInfoEXT();
            debugInfo.SType = StructureType.DebugUtilsMessengerCreateInfoExt;
            debugInfo.MessageSeverity = (uint)(DebugUtilsMessageSeverityFlagBitsEXT.VerboseBitExt | DebugUtilsMessageSeverityFlagBitsEXT.WarningBitExt | DebugUtilsMessageSeverityFlagBitsEXT.ErrorBitExt);
            debugInfo.MessageType = (uint)(DebugUtilsMessageTypeFlagBitsEXT.GeneralBitExt | DebugUtilsMessageTypeFlagBitsEXT.ValidationBitExt | DebugUtilsMessageTypeFlagBitsEXT.PerformanceBitExt);
            debugInfo.PfnUserCallback = DebugCallback;

            var createInfo = new InstanceCreateInfo();
            createInfo.SType = StructureType.InstanceCreateInfo;
            createInfo.PApplicationInfo = appInfo;

            var layersAvailable = Instance.EnumerateInstanceLayerProperties();
            var extensions = Instance.EnumerateInstanceExtensionProperties();

            createInfo.EnabledExtensionCount = (uint)extensions.Length;
            createInfo.PpEnabledExtensionNames = extensions.Select(x => x.ExtensionName).ToArray();

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
                var result = func(instance, pCreateInfo, IntPtr.Zero, out var pDebugMessenger_t);
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
            debugInfo.SType = StructureType.DebugUtilsMessengerCreateInfoExt;
            debugInfo.MessageSeverity = (uint)(DebugUtilsMessageSeverityFlagBitsEXT.VerboseBitExt | DebugUtilsMessageSeverityFlagBitsEXT.WarningBitExt | DebugUtilsMessageSeverityFlagBitsEXT.ErrorBitExt);
            debugInfo.MessageType = (uint)(DebugUtilsMessageTypeFlagBitsEXT.GeneralBitExt | DebugUtilsMessageTypeFlagBitsEXT.ValidationBitExt | DebugUtilsMessageTypeFlagBitsEXT.PerformanceBitExt);
            debugInfo.PfnUserCallback = DebugCallback;

            var result = CreateDebugUtilsMessengerEXT(instance, debugInfo, null, out debugMessenger);

            if (result != Result.Success)
            {
                MessageBox.Show("Failed to set up debug messenger!");
                throw new Exception();
            }
        }

        private uint DebugCallback(DebugUtilsMessageSeverityFlagBitsEXT messageSeverity, uint messageTypes, AdamantiumVulkan.Core.Interop.DebugUtilsMessengerCallbackDataEXT pCallbackData, ref IntPtr pUserData)
        {
            Console.WriteLine(Marshal.PtrToStringAnsi(pCallbackData.pMessage));
            return 1;
        }

        private void PickPhysicalDevice()
        {
            uint deviceCount = 0;
            instance.EnumeratePhysicalDevices(ref deviceCount, null);

            if (deviceCount == 0)
            {
                MessageBox.Show($"No physical devices found");
                throw new Exception();
            }

            var devices = new PhysicalDevice[deviceCount];
            instance.EnumeratePhysicalDevices(ref deviceCount, devices);

            physicalDevice = devices[0];
            physicalDevice.GetPhysicalDeviceMemoryProperties(out var memoryProperties); //TODO: change type to out
            physicalDevice.GetPhysicalDeviceProperties(out var deviceProperties);
            physicalDevice.GetPhysicalDeviceFeatures(out var deviceFeatures);
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
                queueCreateInfo.SType = StructureType.DeviceQueueCreateInfo;
                queueCreateInfo.QueueFamilyIndex = queueFamily;
                queueCreateInfo.QueueCount = 1;
                queueCreateInfo.PQueuePriorities = queuePriority;
                queueInfos.Add(queueCreateInfo);
            }

            physicalDevice.GetPhysicalDeviceFeatures(out var deviceFeatures);

            var createInfo = new DeviceCreateInfo();
            createInfo.SType = StructureType.DeviceCreateInfo;

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

            var res = physicalDevice.CreateDevice(createInfo, null, out logicalDevice);
            if (res != Result.Success)
            {
                MessageBox.Show($"Сannot create logical device. Returned result = {res}");
                throw new Exception();
            }

            createInfo.Dispose();

            logicalDevice.GetDeviceQueue(indices.graphicsFamily.Value, 0, out graphicsQueue);
            logicalDevice.GetDeviceQueue(indices.presentFamily.Value, 0, out presentQueue);

            //DeviceQueueInfo2 deviceQueueInfo2 = new DeviceQueueInfo2();
            //deviceQueueInfo2.sType = StructureType.DeviceQueueInfo2;
            //deviceQueueInfo2.queueFamilyIndex = indices.Value;
            //logicalDevice.GetDeviceQueue2(deviceQueueInfo2, out queue);

        }

        private void CreateSurface()
        {
            var surfaceInfo = new Win32SurfaceCreateInfoKHR();
            surfaceInfo.SType = StructureType.Win32SurfaceCreateInfoKhr;
            surfaceInfo.Hwnd = this.Handle;
            surfaceInfo.Hinstance = Process.GetCurrentProcess().Handle;
            var result = instance.CreateWin32SurfaceKHR(surfaceInfo, null, out surface);
            if (result != Result.Success)
            {
                MessageBox.Show($"Сannot create surface. Returned result = {result}");
                throw new Exception();
            }
        }

        QueueFamilyIndices FindQueueFamilies(PhysicalDevice device)
        {
            QueueFamilyIndices indices = new QueueFamilyIndices();

            uint queueFamilyCount = 0;
            physicalDevice.GetPhysicalDeviceQueueFamilyProperties(ref queueFamilyCount, null);
            //physicalDevice.GetPhysicalDeviceQueueFamilyProperties2(ref queueFamilyCount, null);

            var queueFamilies = new QueueFamilyProperties[queueFamilyCount];
            physicalDevice.GetPhysicalDeviceQueueFamilyProperties(ref queueFamilyCount, queueFamilies);
            //var queueFamilies2 = new QueueFamilyProperties2[queueFamilyCount];
            //physicalDevice.GetPhysicalDeviceQueueFamilyProperties2(ref queueFamilyCount, queueFamilies2);

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

            device.GetPhysicalDeviceSurfaceCapabilitiesKHR(surface, out details.Capabilities);

            uint formatCount = 0;
            device.GetPhysicalDeviceSurfaceFormatsKHR(surface, ref formatCount, null);

            if (formatCount != 0)
            {
                details.Formats = new SurfaceFormatKHR[formatCount];
                device.GetPhysicalDeviceSurfaceFormatsKHR(surface, ref formatCount, details.Formats);
            }

            uint presentModeCount = 0;
            device.GetPhysicalDeviceSurfacePresentModesKHR(surface, ref presentModeCount, null);

            if (presentModeCount != 0)
            {
                details.PresentModes = new PresentModeKHR[presentModeCount];
                device.GetPhysicalDeviceSurfacePresentModesKHR(surface, ref presentModeCount, details.PresentModes);
            }

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
            createInfo.SType = StructureType.SwapchainCreateInfoKhr;
            createInfo.Surface = surface;

            createInfo.MinImageCount = imageCount;
            createInfo.ImageFormat = surfaceFormat.Format;
            createInfo.ImageColorSpace = surfaceFormat.ColorSpace;
            createInfo.ImageExtent = extent;
            createInfo.ImageArrayLayers = 1;
            createInfo.ImageUsage = (uint)ImageUsageFlagBits.ColorAttachmentBit;

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

            var result = logicalDevice.CreateSwapchainKHR(createInfo, null, out swapchain);

            if (result != Result.Success)
            {
                MessageBox.Show($"Failed to create swap chain!. Returned result is: {result}");
                throw new Exception();
            }

            createInfo.Dispose();

            logicalDevice.GetSwapchainImagesKHR(swapchain, ref imageCount, null);
            swapchainImages = new Image[imageCount];
            logicalDevice.GetSwapchainImagesKHR(swapchain, ref imageCount, swapchainImages);

            swapChainImageFormat = surfaceFormat.Format;
            swapChainExtent = extent;
        }

        private void CreateImageViews()
        {
            swapchainImageViews = new ImageView[swapchainImages.Length];

            for (int i = 0; i < swapchainImages.Length; i++)
            {
                var createInfo = new ImageViewCreateInfo();
                createInfo.SType = StructureType.ImageViewCreateInfo;
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

                var result = logicalDevice.CreateImageView(createInfo, null, out swapchainImageViews[i]);
                if (result != Result.Success)
                {
                    MessageBox.Show($"Cannot create Image view with index {i}");
                    throw new Exception();
                }
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
            subpass.PColorAttachments = colorAttachmentRef;

            var renderPassInfo = new RenderPassCreateInfo();
            renderPassInfo.SType = StructureType.RenderPassCreateInfo;
            renderPassInfo.AttachmentCount = 1;
            renderPassInfo.PAttachments = colorAttachment;
            renderPassInfo.SubpassCount = 1;
            renderPassInfo.PSubpasses = subpass;

            var result = logicalDevice.CreateRenderPass(renderPassInfo, null, out renderPass);
            if (result != Result.Success)
            {
                MessageBox.Show("failed to create render pass!");
                throw new Exception();
            }
        }

        private void CreateGraphicsPipeline()
        {
            var vertexContent = File.ReadAllBytes(@"shaders\vert.spv");
            var fragmentContent = File.ReadAllBytes(@"shaders\frag.spv");

            var vertexShaderModule = CreateShaderModule(vertexContent);
            var fragmentShaderModule = CreateShaderModule(fragmentContent);

            var vertShaderStageInfo = new PipelineShaderStageCreateInfo();
            vertShaderStageInfo.SType = StructureType.PipelineShaderStageCreateInfo;
            vertShaderStageInfo.Stage = ShaderStageFlagBits.VertexBit;
            vertShaderStageInfo.Module = vertexShaderModule;
            vertShaderStageInfo.PName = "main";

            var fragShaderStageInfo = new PipelineShaderStageCreateInfo();
            fragShaderStageInfo.SType = StructureType.PipelineShaderStageCreateInfo;
            fragShaderStageInfo.Stage = ShaderStageFlagBits.FragmentBit;
            fragShaderStageInfo.Module = fragmentShaderModule;
            fragShaderStageInfo.PName = "main";

            PipelineShaderStageCreateInfo[] shaderStages = new[] { vertShaderStageInfo, fragShaderStageInfo };

            var bindingDescr = GetBindingDescription<Vertex>();
            var attributesDescriptions = GetVertexAttributeDescription<Vertex>();

            //var bindingDescr = GetBindingDescription<Vector2>();
            //var attributesDescriptions = new VertexInputAttributeDescription[1];

            //var desc = new VertexInputAttributeDescription();
            //desc.Binding = 0;
            //desc.Location = 0;
            //desc.Format = Format.R32g32Sfloat;
            //desc.Offset = 0;
            //attributesDescriptions[0] = desc;

            var vertexInputInfo = new PipelineVertexInputStateCreateInfo();
            vertexInputInfo.SType = StructureType.PipelineVertexInputStateCreateInfo;
            vertexInputInfo.VertexBindingDescriptionCount = 1;
            vertexInputInfo.VertexAttributeDescriptionCount = (uint)attributesDescriptions.Length;
            vertexInputInfo.PVertexBindingDescriptions = new VertexInputBindingDescription[] { bindingDescr };
            vertexInputInfo.PVertexAttributeDescriptions = attributesDescriptions;

            var inputAssembly = new PipelineInputAssemblyStateCreateInfo();
            inputAssembly.SType = StructureType.PipelineInputAssemblyStateCreateInfo;
            inputAssembly.Topology = PrimitiveTopology.TriangleList;
            inputAssembly.PrimitiveRestartEnable = false;

            var viewport = new Viewport();
            viewport.X = 0.0f;
            viewport.Y = 0.0f;
            viewport.Width = (float)swapChainExtent.width;
            viewport.Height = (float)swapChainExtent.height;
            viewport.MinDepth = 0.0f;
            viewport.MaxDepth = 1.0f;

            Rect2D scissor = new Rect2D();
            scissor.Offset = new Offset2D();
            scissor.Extent = swapChainExtent;

            var viewportState = new PipelineViewportStateCreateInfo();
            viewportState.SType = StructureType.PipelineViewportStateCreateInfo;
            viewportState.ViewportCount = 1;
            viewportState.PViewports = viewport;
            viewportState.ScissorCount = 1;
            viewportState.PScissors = scissor;

            var rasterizer = new PipelineRasterizationStateCreateInfo();
            rasterizer.SType = StructureType.PipelineRasterizationStateCreateInfo;
            rasterizer.DepthClampEnable = false;
            rasterizer.RasterizerDiscardEnable = false;
            rasterizer.PolygonMode = PolygonMode.Fill;
            rasterizer.LineWidth = 1.0f;
            rasterizer.CullMode = (uint)CullModeFlagBits.BackBit;
            rasterizer.FrontFace = FrontFace.Clockwise;
            rasterizer.DepthBiasEnable = false;

            var multisampling = new PipelineMultisampleStateCreateInfo();
            multisampling.SType = StructureType.PipelineMultisampleStateCreateInfo;
            multisampling.SampleShadingEnable = false;
            multisampling.RasterizationSamples = SampleCountFlagBits._1Bit;

            var colorBlendAttachment = new PipelineColorBlendAttachmentState();
            colorBlendAttachment.ColorWriteMask = (uint)(ColorComponentFlagBits.RBit | ColorComponentFlagBits.GBit | ColorComponentFlagBits.BBit | ColorComponentFlagBits.ABit);
            colorBlendAttachment.BlendEnable = false;

            var colorBlending = new PipelineColorBlendStateCreateInfo();
            colorBlending.SType = StructureType.PipelineColorBlendStateCreateInfo;
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
            pipelineLayoutInfo.SType = StructureType.PipelineLayoutCreateInfo;
            pipelineLayoutInfo.SetLayoutCount = 0;
            pipelineLayoutInfo.PushConstantRangeCount = 0;

            var result = logicalDevice.CreatePipelineLayout(pipelineLayoutInfo, null, out pipelineLayout);
            if (result != Result.Success)
            {
                MessageBox.Show("failed to create pipeline layout!");
                throw new Exception();
            }

            var pipelineInfo = new GraphicsPipelineCreateInfo();
            pipelineInfo.SType = StructureType.GraphicsPipelineCreateInfo;
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

            result = logicalDevice.CreateGraphicsPipelines(null, 1, pipelineInfo, null, out graphicsPipeline);
            if (result != Result.Success)
            {
                MessageBox.Show("failed to create graphics pipeline!");
                throw new Exception();
            }

            pipelineInfo.Dispose();
            logicalDevice.DestroyShaderModule(vertexShaderModule, null);
            logicalDevice.DestroyShaderModule(fragmentShaderModule, null);
        }

        private void CreateFramebuffers()
        {
            swapchainFramebuffers = new Framebuffer[swapchainImageViews.Length];

            for (int i = 0; i < swapchainImageViews.Length; i++)
            {
                FramebufferCreateInfo framebufferInfo = new FramebufferCreateInfo();
                framebufferInfo.SType = StructureType.FramebufferCreateInfo;
                framebufferInfo.RenderPass = renderPass;
                framebufferInfo.AttachmentCount = 1;

                framebufferInfo.PAttachments = swapchainImageViews[i];
                framebufferInfo.Width = swapChainExtent.width;
                framebufferInfo.Height = swapChainExtent.height;
                framebufferInfo.Layers = 1;

                var result = logicalDevice.CreateFramebuffer(framebufferInfo, null, out swapchainFramebuffers[i]);
                if (result != Result.Success)
                {
                    MessageBox.Show("failed to create framebuffer!");
                    throw new Exception();
                }

                framebufferInfo.Dispose();
            }
        }

        private void CreateCommandPool()
        {
            QueueFamilyIndices queueFamilyIndices = FindQueueFamilies(physicalDevice);

            var poolInfo = new CommandPoolCreateInfo();
            poolInfo.SType = StructureType.CommandPoolCreateInfo;
            poolInfo.QueueFamilyIndex = queueFamilyIndices.graphicsFamily.Value;

            var result = logicalDevice.CreateCommandPool(poolInfo, null, out commandPool);
            if (result != Result.Success)
            {
                MessageBox.Show("failed to create graphics command pool!");
                throw new Exception();
            }
        }

        private void CreateVertexBuffer()
        {
            vertices = GetVertexArray();
            var bufferSize = (ulong)(Marshal.SizeOf(vertices[0]) * vertices.Length);
            Buffer stagingBuffer;
            DeviceMemory stagingBufferMemory;
            CreateBuffer(bufferSize, BufferUsageFlagBits.TransferSrcBit, MemoryPropertyFlagBits.HostCachedBit | MemoryPropertyFlagBits.HostCoherentBit, out stagingBuffer, out stagingBufferMemory);

            var result = logicalDevice.MapMemory(stagingBufferMemory, 0, bufferSize, 0, out var data);
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

        void CreateIndexBuffer()
        {
            indices = GetIndices();
            ulong bufferSize = (ulong)(Marshal.SizeOf(indices[0]) * indices.Length);

            Buffer stagingBuffer;
            DeviceMemory stagingBufferMemory;
            CreateBuffer(bufferSize, BufferUsageFlagBits.TransferSrcBit, MemoryPropertyFlagBits.HostCachedBit | MemoryPropertyFlagBits.HostCoherentBit, out stagingBuffer, out stagingBufferMemory);

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
            bufferInfo.SType = StructureType.BufferCreateInfo;
            bufferInfo.Size = size;
            bufferInfo.Usage = (uint)usage;
            bufferInfo.SharingMode = SharingMode.Exclusive;

            var result = logicalDevice.CreateBuffer(bufferInfo, null, out buffer);
            if (result != Result.Success)
            {
                MessageBox.Show("failed to create vertex buffer!");
                throw new Exception();
            }

            MemoryRequirements memoryRequirements;
            logicalDevice.GetBufferMemoryRequirements(buffer, out memoryRequirements);

            MemoryAllocateInfo allocInfo = new MemoryAllocateInfo();
            allocInfo.SType = StructureType.MemoryAllocateInfo;
            allocInfo.AllocationSize = memoryRequirements.Size;

            PhysicalDeviceMemoryProperties memProperties;
            physicalDevice.GetPhysicalDeviceMemoryProperties(out memProperties);

            var properties = MemoryPropertyFlagBits.HostVisibleBit | MemoryPropertyFlagBits.HostCoherentBit;
            for (uint i = 0; i < memProperties.MemoryTypeCount; i++)
            {
                if (((memoryRequirements.MemoryTypeBits >> (int)i) & 1) == 1
                    && memProperties.MemoryTypes[i].PropertyFlags == (uint)properties)
                {
                    allocInfo.MemoryTypeIndex = i;
                    break;
                }
            }

            result = logicalDevice.AllocateMemory(allocInfo, null, out bufferMemory);
            if (result != Result.Success)
            {
                MessageBox.Show("failed to allocate vertex buffer memory!");
                throw new Exception();
            }

            result = logicalDevice.BindBufferMemory(buffer, bufferMemory, 0);
        }

        private void CopyBuffer(Buffer srcBuffer, Buffer dstBuffer, ulong size)
        {
            var allocInfo = new CommandBufferAllocateInfo();
            allocInfo.SType = StructureType.CommandBufferAllocateInfo;
            allocInfo.Level = CommandBufferLevel.Primary;
            allocInfo.CommandPool = commandPool;
            allocInfo.CommandBufferCount = 1;

            CommandBuffer[] commandBuffers = new CommandBuffer[1];
            var result = logicalDevice.AllocateCommandBuffers(allocInfo, commandBuffers);

            var beginInfo = new CommandBufferBeginInfo();
            beginInfo.SType = StructureType.CommandBufferBeginInfo;
            beginInfo.Flags = (uint)CommandBufferUsageFlagBits.OneTimeSubmitBit;

            var commandBuffer = commandBuffers[0];
            commandBuffer.BeginCommandBuffer(beginInfo);

            BufferCopy copyRegin = new BufferCopy();
            copyRegin.Size = size;
            var regions = new BufferCopy[1] { copyRegin };
            commandBuffer.CmdCopyBuffer(srcBuffer, dstBuffer, 1, regions);

            commandBuffer.EndCommandBuffer();

            SubmitInfo submitInfo = new SubmitInfo();
            submitInfo.SType = StructureType.SubmitInfo;
            submitInfo.CommandBufferCount = 1;
            submitInfo.PCommandBuffers = commandBuffers;

            var submitInfoArray = new SubmitInfo[1];
            submitInfoArray[0] = submitInfo;
            graphicsQueue.QueueSubmit(1, submitInfoArray, null);
            graphicsQueue.QueueWaitIdle();

            logicalDevice.FreeCommandBuffers(commandPool, 1, commandBuffers);
        }

        uint FindMemoryType(uint typeFilter, MemoryPropertyFlagBits properties)
        {
            PhysicalDeviceMemoryProperties memProperties;
            physicalDevice.GetPhysicalDeviceMemoryProperties(out memProperties);

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

        private void CreateCommandBuffers()
        {
            commandBuffers = new CommandBuffer[swapchainFramebuffers.Length];

            var allocInfo = new CommandBufferAllocateInfo();
            allocInfo.SType = StructureType.CommandBufferAllocateInfo;
            allocInfo.CommandPool = commandPool;
            allocInfo.Level = CommandBufferLevel.Primary;
            allocInfo.CommandBufferCount = (uint)commandBuffers.Length;

            var result = logicalDevice.AllocateCommandBuffers(allocInfo, commandBuffers);
            if (result != Result.Success)
            {
                MessageBox.Show("failed to allocate command buffers!");
                throw new Exception();
            }

            for (int i = 0; i < commandBuffers.Length; i++)
            {
                var commandBuffer = commandBuffers[i];
                var beginInfo = new CommandBufferBeginInfo();
                beginInfo.SType = StructureType.CommandBufferBeginInfo;
                beginInfo.Flags = (uint)CommandBufferUsageFlagBits.SimultaneousUseBit;

                result = commandBuffer.BeginCommandBuffer(beginInfo);
                if (result != Result.Success)
                {
                    MessageBox.Show("failed to begin recording command buffer!");
                    throw new Exception();
                }

                var renderPassInfo = new RenderPassBeginInfo();
                renderPassInfo.SType = StructureType.RenderPassBeginInfo;
                renderPassInfo.RenderPass = renderPass;
                renderPassInfo.Framebuffer = swapchainFramebuffers[i];
                renderPassInfo.RenderArea = new Rect2D();
                renderPassInfo.RenderArea.Offset = new Offset2D();
                renderPassInfo.RenderArea.Extent = swapChainExtent;

                ClearValue clearValue = new ClearValue();
                clearValue.Color = new ClearColorValue();
                clearValue.Color.Float32 = new float[4] { 0.5f, 0.7f, 1.0f, 0.0f };

                renderPassInfo.ClearValueCount = 1;
                renderPassInfo.PClearValues = new ClearValue[] { clearValue };
                CoreInterop.RenderPassBeginInfo renderPassBeginInfo = renderPassInfo;
                commandBuffer.CmdBeginRenderPass(renderPassInfo, SubpassContents.Inline);

                commandBuffer.CmdBindPipeline(PipelineBindPoint.Graphics, graphicsPipeline);

                UInt64[] offsets = new UInt64[0];
                Buffer[] vertexBuffers = new Buffer[] { vertexBuffer };
                commandBuffer.CmdBindVertexBuffers(0, 1, vertexBuffers, offsets);

                commandBuffer.CmdBindIndexBuffer(indexBuffer, 0, IndexType.Uint32);

                commandBuffer.CmdDrawIndexed((uint)indices.Length, 1, 0, 0, 0);

                commandBuffer.CmdEndRenderPass();

                result = commandBuffer.EndCommandBuffer();
                if (result != Result.Success)
                {
                    MessageBox.Show("failed to record command buffer!");
                    throw new Exception();
                }
            }
        }

        private void CreateSyncObjects()
        {
            imageAvailableSemaphores = new Semaphore[MAX_FRAMES_IN_FLIGHT];
            renderFinishedSemaphores = new Semaphore[MAX_FRAMES_IN_FLIGHT];
            inFlightFences = new Fence[MAX_FRAMES_IN_FLIGHT];

            var semaphoreInfo = new SemaphoreCreateInfo();
            semaphoreInfo.SType = StructureType.SemaphoreCreateInfo;

            var fenceInfo = new FenceCreateInfo();
            fenceInfo.SType = StructureType.FenceCreateInfo;
            fenceInfo.Flags = (uint)FenceCreateFlagBits.SignaledBit;

            for (int i = 0; i < MAX_FRAMES_IN_FLIGHT; i++)
            {
                var result = logicalDevice.CreateSemaphore(semaphoreInfo, null, out imageAvailableSemaphores[i]);
                if (result != Result.Success)
                {
                    MessageBox.Show("failed to create synchronization objects for a frame!");
                    throw new Exception();
                }

                result = logicalDevice.CreateSemaphore(semaphoreInfo, null, out renderFinishedSemaphores[i]);
                if (result != Result.Success)
                {
                    MessageBox.Show("failed to create synchronization objects for a frame!");
                    throw new Exception();
                }

                result = logicalDevice.CreateFence(fenceInfo, null, out inFlightFences[i]);
                if (result != Result.Success)
                {
                    MessageBox.Show("failed to create synchronization objects for a frame!");
                    throw new Exception();
                }
            }
        }

        ShaderModule CreateShaderModule(byte[] code)
        {
            ShaderModuleCreateInfo createInfo = new ShaderModuleCreateInfo();
            createInfo.SType = StructureType.ShaderModuleCreateInfo;
            createInfo.CodeSize = (ulong)code.Length;
            createInfo.PCode = code;

            var result = logicalDevice.CreateShaderModule(createInfo, null, out var shaderModule);
            if (result != Result.Success)
            {
                MessageBox.Show("failed to create shader module!");
                throw new Exception();
            }

            createInfo.Dispose();
            return shaderModule;
        }

        SurfaceFormatKHR ChooseSwapSurfaceFormat(SurfaceFormatKHR[] availableFormats)
        {
            if (availableFormats.Length == 1 && availableFormats[0].Format == Format.Undefined)
            {
                return new SurfaceFormatKHR() { Format = Format.B8g8r8a8Unorm, ColorSpace = ColorSpaceKHR.ColorspaceSrgbNonlinearKhr };
            }

            foreach (var availableFormat in availableFormats)
            {
                if (availableFormat.Format == Format.B8g8r8a8Unorm && availableFormat.ColorSpace == ColorSpaceKHR.ColorspaceSrgbNonlinearKhr)
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
                new Vertex(){Position = new Vector2(-0.5f, -0.5f), Color = new Vector3(0.0f, 0.0f, 1.0f)},
                new Vertex(){Position = new Vector2(0.5f, -0.5f), Color = new Vector3(1.0f, 1.0f, 1.0f)},
                new Vertex(){Position = new Vector2(0.5f, 0.5f), Color = new Vector3(0.0f, 1.0f, 0.0f)},
                new Vertex(){Position = new Vector2(-0.5f, 0.5f), Color = new Vector3(1.0f, 0.0f, 1.0f)},
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
                    return Format.R32Sfloat;
                case 8:
                    return Format.R32g32Sfloat;
                case 12:
                    return Format.R32g32b32Sfloat;
                case 16:
                    return Format.R32g32b32a32Sfloat;

                default:
                    throw new Exception($"size {size} is not supported");
            }
        }
    }
}

