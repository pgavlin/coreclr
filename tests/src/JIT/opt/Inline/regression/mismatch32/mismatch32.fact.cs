using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Inline_regression_mismatch32_mismatch32_mismatch32_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_regression_mismatch32_mismatch32_mismatch32_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Inline\\regression\\mismatch32\\mismatch32\\mismatch32.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
