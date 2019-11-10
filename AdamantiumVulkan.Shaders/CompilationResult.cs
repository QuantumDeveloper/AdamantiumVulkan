using System;
using System.Text;

namespace AdamantiumVulkan.Shaders
{
    public class CompilationResult
    {
        internal CompilationResult(
            byte[] bytecode, 
            ShadercShaderKind shaderStage, 
            ShadercCompilationStatus status, 
            string[] messages, 
            ulong errorsNumber, 
            ulong warningNumbers,
            bool containsTextOutput)
        {
            ShaderStage = shaderStage;
            Bytecode = bytecode;
            Status = status;
            Messages = messages;
            ErrorsNumber = errorsNumber;
            WarningsNumber = warningNumbers;
            ContainsTextOutput = containsTextOutput;
        }

        public byte[] Bytecode { get; }

        public UInt64 Length => (uint)Bytecode.Length;

        public ShadercCompilationStatus Status { get; }

        public string[] Messages { get; }

        public UInt64 ErrorsNumber { get; }

        public UInt64 WarningsNumber { get; }
        
        public ShadercShaderKind ShaderStage { get; }
        
        public bool ContainsTextOutput { get; }

        public string GetOutputAsString()
        {
            return Encoding.ASCII.GetString(Bytecode);
        }
    }
}
