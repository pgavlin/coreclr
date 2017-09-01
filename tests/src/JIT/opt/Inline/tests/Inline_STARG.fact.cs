using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Inline_tests_Inline_STARG_Inline_STARG_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_Inline_STARG_Inline_STARG_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\Inline_STARG\\Inline_STARG.cmd");
        }
    }
}
