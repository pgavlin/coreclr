using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Inline_regression_bug595776_bug595776_bug595776_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_regression_bug595776_bug595776_bug595776_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Inline\\regression\\bug595776\\bug595776\\bug595776.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
