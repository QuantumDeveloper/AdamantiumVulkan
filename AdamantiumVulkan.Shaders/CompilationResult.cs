using System;
using System.Text;

namespace AdamantiumVulkan.Shaders
{
    public class CompilationResult
    {
        internal CompilationResult(
            string name,
            byte[] bytecode, 
            ShadercShaderKind shaderStage, 
            ShadercCompilationStatus status, 
            string messages, 
            ulong errorsNumber, 
            ulong warningNumbers,
            bool containsTextOutput)
        {
            Name = name;
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
        
        public string Name { get; }

        public ShadercCompilationStatus Status { get; }

        public string Messages { get; }

        public UInt64 ErrorsNumber { get; }

        public UInt64 WarningsNumber { get; }
        
        public ShadercShaderKind ShaderStage { get; }
        
        public bool ContainsTextOutput { get; }

        public bool HasErrors => ErrorsNumber > 0;

        public string GetOutputAsString()
        {
            return Encoding.ASCII.GetString(Bytecode);
        }

        public static implicit operator byte[](CompilationResult result)
        {
            return result.Bytecode;
        }
    }
}
