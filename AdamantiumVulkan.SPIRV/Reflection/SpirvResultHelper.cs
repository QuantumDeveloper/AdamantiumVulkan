using AdamantiumVulkan.Spirv.Cross;

namespace AdamantiumVulkan.Spirv.Reflection
{
    public static class SpirvResultHelper
    {
        public static void CheckResult(Result result, string methodName)
        {
            if (result != Result.Success)
            {
                throw new SpirvResultException($"Result of function {methodName} was not success. Function Returns {result}");
            }
        }
    }
}