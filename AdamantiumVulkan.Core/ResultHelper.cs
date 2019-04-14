using System;
using System.Collections.Generic;
using System.Text;

namespace AdamantiumVulkan.Core
{
    public static class ResultHelper
    {
        public static void CheckResult(Result result, string methodName)
        {
            if (result != Result.Success)
            {
                throw new ResultException($"Result of function {methodName} was not success. Function Returns {result}");
            }
        }
    }
}
