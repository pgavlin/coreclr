using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Inline_regression_badcallee_badcallee_badcallee_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_regression_badcallee_badcallee_badcallee_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Inline\\regression\\badcallee\\badcallee\\badcallee.cmd");
        }
    }
}
