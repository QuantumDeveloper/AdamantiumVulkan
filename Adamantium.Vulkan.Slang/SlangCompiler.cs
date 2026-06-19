using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Adamantium.Vulkan.Slang
{
    /// <summary>The outcome of one Slang compile: the SPIR-V bytes (when successful) plus the Slang diagnostics text.</summary>
    public sealed class SlangCompileResult
    {
        public byte[] Spirv { get; internal set; }
        public bool Success { get; internal set; }
        public string Diagnostics { get; internal set; }
    }

    /// <summary>
    /// Reusable Slang -> SPIR-V compiler over the Slang runtime. Owns a session configured with a target profile,
    /// compiler options and preprocessor defines, and resolves <c>#include</c> directives through
    /// <see cref="IncludeResolver"/>. The native session, file-load callback and SPIR-V extraction live here once and
    /// are shared by every consumer (the engine's effect compiler, the Vulkan demo, …) instead of being duplicated.
    /// Not thread-safe; use one instance per compilation context.
    /// </summary>
    public sealed class SlangCompiler : IDisposable
    {
        // Native VFS callback: int(void* userData, const char* path, const unsigned char** outData, size_t* outSize).
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int SlangcLoadFile(IntPtr userData, IntPtr path, out IntPtr outData, out UIntPtr outSize);

        private readonly SlangcSession session;
        private readonly SlangcLoadFile loadFileDelegate;   // kept alive for the session's lifetime
        private readonly List<IntPtr> pendingBuffers = [];
        private int moduleCounter;

        /// <summary>Maps an <c>#include</c> path to file contents (null = not found); set per compile as needed.</summary>
        public Func<string, string> IncludeResolver { get; set; }

        /// <param name="profile">SPIR-V target profile, e.g. <c>spirv_1_6</c>.</param>
        /// <param name="options">Slang compiler options (matrix layout, entry-point naming, …); may be null.</param>
        /// <param name="defines">Session-wide preprocessor macros; may be null.</param>
        public SlangCompiler(string profile, IReadOnlyList<SlangcCompilerOption> options = null,
            IReadOnlyDictionary<string, string> defines = null)
        {
            loadFileDelegate = LoadFile;
            var loadFilePtr = unchecked((nuint)Marshal.GetFunctionPointerForDelegate(loadFileDelegate).ToInt64());

            var optionArray = options?.ToArray() ?? [];

            string[] defineNames = [];
            string[] defineValues = [];
            if (defines is { Count: > 0 })
            {
                defineNames = defines.Keys.ToArray();
                defineValues = defines.Values.ToArray();
            }

            nuint userData = 0;
            session = SlangNative.SessionCreate(
                null, 0,
                defineNames, defineValues, defineNames.Length,
                profile, optionArray, optionArray.Length, loadFilePtr, ref userData);
        }

        /// <summary>Compiles one entry point of <paramref name="source"/> to SPIR-V for the given stage.</summary>
        public SlangCompileResult Compile(string source, string entryPoint, SlangcStage stage)
        {
            // Unique module name per compile so Slang's per-session module cache never collides.
            var moduleName = $"m{moduleCounter++}_{entryPoint}";

            var result = session.Compile(moduleName, source, entryPoint, stage);
            try
            {
                var ok = result.ResultOk() != 0;
                var diagnostics = result.ResultDiagnostics();

                byte[] spirv = null;
                if (ok)
                {
                    var ptr = result.ResultSpirv(out var size);
                    if (ptr != 0 && size > 0)
                    {
                        spirv = new byte[size];
                        Marshal.Copy(new IntPtr((long)(ulong)ptr), spirv, 0, (int)size);
                    }
                }

                return new SlangCompileResult
                {
                    Spirv = spirv,
                    Success = ok && spirv != null,
                    Diagnostics = diagnostics
                };
            }
            finally
            {
                result.ResultRelease();
                // The shim copies callback buffers synchronously during compilation, so they are safe to free now.
                FreePendingBuffers();
            }
        }

        // Called by Slang (native) for every #include it can't already satisfy. The returned buffer must stay valid
        // until the call returns; the shim copies it immediately, so we free after the compile completes.
        private int LoadFile(IntPtr userData, IntPtr path, out IntPtr outData, out UIntPtr outSize)
        {
            outData = IntPtr.Zero;
            outSize = UIntPtr.Zero;

            var requested = Marshal.PtrToStringAnsi(path);
            var content = string.IsNullOrEmpty(requested) ? null : IncludeResolver?.Invoke(requested);
            if (content == null)
                return 0;

            var bytes = Encoding.UTF8.GetBytes(content);
            var buffer = Marshal.AllocHGlobal(bytes.Length);
            Marshal.Copy(bytes, 0, buffer, bytes.Length);
            pendingBuffers.Add(buffer);

            outData = buffer;
            outSize = (UIntPtr)bytes.Length;
            return 1;
        }

        private void FreePendingBuffers()
        {
            foreach (var buffer in pendingBuffers)
                Marshal.FreeHGlobal(buffer);
            pendingBuffers.Clear();
        }

        public void Dispose()
        {
            FreePendingBuffers();
            session?.SessionRelease();
        }
    }
}
