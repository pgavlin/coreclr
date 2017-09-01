using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Inline_tests_deepcall_deepcall_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_deepcall_deepcall_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\deepcall\\deepcall.cmd");
        }
    }
}
