using System;
using System.Collections.Generic;
using System.Text;
using AdamantiumVulkan.Core.Interop;

namespace AdamantiumVulkan.Core
{
    public static class ResultHelper
    {
        public static void CheckResult(Result result, string methodName)
        {
            if (result is not Result.Success)
            {
                throw new ResultException($"Result of function {methodName} was not success. Function Returns {result}");
            }
        }
    }
}
