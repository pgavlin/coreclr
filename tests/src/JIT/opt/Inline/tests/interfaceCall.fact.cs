using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Inline_tests_interfaceCall_interfaceCall_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_interfaceCall_interfaceCall_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\interfaceCall\\interfaceCall.cmd");
        }
    }
}
