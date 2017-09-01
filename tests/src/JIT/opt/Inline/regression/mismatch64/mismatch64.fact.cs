using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Inline_regression_mismatch64_mismatch64_mismatch64_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_regression_mismatch64_mismatch64_mismatch64_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Inline\\regression\\mismatch64\\mismatch64\\mismatch64.cmd");
        }
    }
}
