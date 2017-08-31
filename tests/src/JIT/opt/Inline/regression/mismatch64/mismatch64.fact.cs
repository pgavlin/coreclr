using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Inline_regression_mismatch64_mismatch64_mismatch64_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_regression_mismatch64_mismatch64_mismatch64_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Inline\\regression\\mismatch64\\mismatch64\\mismatch64.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
