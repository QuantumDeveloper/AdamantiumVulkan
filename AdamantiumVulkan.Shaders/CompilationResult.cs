using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdamantiumVulkan.Shaders
{
    public class CompilationResult
    {
        internal CompilationResult(
            string name,
            string entryPoint,
            byte[] bytecode, 
            ShadercShaderKind shaderStage, 
            ShadercCompilationStatus status, 
            string messages, 
            ulong errorsNumber, 
            ulong warningNumbers,
            bool containsTextOutput)
        {
            Name = name;
            EntryPoint = entryPoint;
            ShaderStage = shaderStage;
            Bytecode = bytecode;
            Status = status;
            ErrorsNumber = errorsNumber;
            WarningsNumber = warningNumbers;
            ContainsTextOutput = containsTextOutput;
            ParseMessageString(messages);
        }

        public byte[] Bytecode { get; }

        public UInt64 Length => (uint)Bytecode.Length;

        public string Name { get; }
        
        public string EntryPoint { get; }

        public ShadercCompilationStatus Status { get; }

        public string[] Errors { get; private set; }

        public string[] Warnings { get; private set; }

        public UInt64 ErrorsNumber { get; }

        public UInt64 WarningsNumber { get; }
        
        public ShadercShaderKind ShaderStage { get; }
        
        public bool ContainsTextOutput { get; }

        public bool HasErrors => ErrorsNumber > 0;

        private void ParseMessageString(string message)
        {
            var messages = message.Split('\n', StringSplitOptions.RemoveEmptyEntries);
            bool lastMessageIsError = false;
            List<string> errors = new List<string>();
            List<string> warnings = new List<string>();
            foreach(var m in messages)
            {
                if (m.Contains($": error:"))
                {
                    errors.Add(m);
                    lastMessageIsError = true;
                }
                else if (m.Contains($": warning:"))
                {
                    warnings.Add(m);
                    lastMessageIsError = false;
                }
                else
                {
                    var container = lastMessageIsError ? errors : warnings;
                    if (container.Count == 0) continue;

                    var last = container[container.Count - 1];
                    last += m;
                    container[container.Count - 1] = last;
                }
            }

            Errors = errors.ToArray();
            Warnings = warnings.ToArray();
        }

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
