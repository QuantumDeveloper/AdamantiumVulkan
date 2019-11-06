namespace AdamantiumVulkan.SPIRV.Cross
{
    public static class SpirvResultHelper
    {
        public static void CheckResult(SpvcResult result, string methodName)
        {
            if (result != SpvcResult.Success)
            {
                throw new ResultException($"Result of function {methodName} was not success. Function Returns {result}");
            }
        }
    }
}