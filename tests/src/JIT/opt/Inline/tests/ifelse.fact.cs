using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Inline_tests_ifelse_ifelse_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_ifelse_ifelse_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\ifelse\\ifelse.cmd");
        }
    }
}
