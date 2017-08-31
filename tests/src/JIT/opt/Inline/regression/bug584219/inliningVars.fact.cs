using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Inline_regression_bug584219_inliningVars_inliningVars_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_regression_bug584219_inliningVars_inliningVars_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Inline\\regression\\bug584219\\inliningVars\\inliningVars.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
