using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _ETW_TailCallCases_TailCallCases_
    {
        [Fact]
        public void _ETW_TailCallCases_TailCallCases_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\ETW\\TailCallCases\\TailCallCases.cmd");
        }
    }
}
