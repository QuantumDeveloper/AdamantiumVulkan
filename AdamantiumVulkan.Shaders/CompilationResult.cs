using System;

namespace AdamantiumVulkan.Shaders
{
    public class CompilationResult : DisposableObject
    {
        private ShadercCompilationResultT compilationResult;

        internal CompilationResult(ShadercCompilationResultT compilationResult)
        {
            this.compilationResult = compilationResult;
        }

        internal CompilationResult(byte[] bytecode, ShadercCompilationStatus status, string[] messages, uint errorsNumber, uint warningNumbers)
        {

        }

        public byte[] Bytecode
        {
            get
            {
                var bytes = new byte[Length];
                MarshalUtils.IntPtrToManagedArray(compilationResult.GetBytes(), bytes);
                return bytes;
            }
        }

        public UInt64 Length => compilationResult.GetLength();

        public ShadercCompilationStatus Status => compilationResult.GetCompilationStatus();

        public string Messages => compilationResult.GetErrorMessage();

        public UInt64 ErrorsNumber => compilationResult.GetNumErrors();

        public UInt64 WarningsNumber => compilationResult.GetNumWarnings();

        protected override void UnmanagedDisposeOverride()
        {
            compilationResult?.Release();
            compilationResult = null;
        }
    }
}
