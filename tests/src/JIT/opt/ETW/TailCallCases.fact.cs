using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _ETW_TailCallCases_TailCallCases_
    {
        [Fact]
        public void _ETW_TailCallCases_TailCallCases_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\ETW\\TailCallCases\\TailCallCases.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
