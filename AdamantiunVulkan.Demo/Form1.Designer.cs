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

        

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            
            //debugCallback = DebugCallback;

            
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
            
            
        }
        
        

        

        

        

        
        
    }
}

