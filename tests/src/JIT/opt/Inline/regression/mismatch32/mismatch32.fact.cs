using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Inline_regression_mismatch32_mismatch32_mismatch32_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_regression_mismatch32_mismatch32_mismatch32_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Inline\\regression\\mismatch32\\mismatch32\\mismatch32.cmd");
        }
    }
}
