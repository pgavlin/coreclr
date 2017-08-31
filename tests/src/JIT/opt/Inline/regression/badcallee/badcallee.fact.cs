using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Inline_regression_badcallee_badcallee_badcallee_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_regression_badcallee_badcallee_badcallee_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Inline\\regression\\badcallee\\badcallee\\badcallee.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
