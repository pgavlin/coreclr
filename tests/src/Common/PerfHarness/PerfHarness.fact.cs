using CoreclrTestLib;
using Xunit;

namespace Common_PerfHarness
{
    class _PerfHarness_PerfHarness_
    {
        [Fact]
        public void _PerfHarness_PerfHarness_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Common\\PerfHarness\\PerfHarness\\PerfHarness.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
