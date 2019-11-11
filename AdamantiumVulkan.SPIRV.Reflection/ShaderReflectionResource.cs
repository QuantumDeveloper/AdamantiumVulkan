using System.Collections.Generic;

namespace AdamantiumVulkan.SPIRV.Reflection
{
    public class ShaderReflectionResource
    {
        private List<ShaderReflectionVariable> members;

        public ShaderReflectionResource()
        {
            members = new List<ShaderReflectionVariable>();
        }
        
        public ShaderReflectionVariable Description { get; internal set; }

        public uint VariablesCount => (uint)members.Count;

        public ShaderReflectionVariable GetVariable(uint index)
        {
            if (members.Count > index)
            {
                return members[(int)index];
            }

            return null;
        }
        
        public void AddVariable(ShaderReflectionVariable variable)
        {
            if (!members.Contains(variable))
            {
                members.Add(variable);
            }
        }

        public override string ToString()
        {
            return Description.Name;
        }
    }
}
