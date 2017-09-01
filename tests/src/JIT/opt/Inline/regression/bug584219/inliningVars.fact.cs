using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Inline_regression_bug584219_inliningVars_inliningVars_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_regression_bug584219_inliningVars_inliningVars_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Inline\\regression\\bug584219\\inliningVars\\inliningVars.cmd");
        }
    }
}
