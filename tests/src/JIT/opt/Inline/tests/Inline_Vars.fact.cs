using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Inline_tests_Inline_Vars_Inline_Vars_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_Inline_Vars_Inline_Vars_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\Inline_Vars\\Inline_Vars.cmd");
        }
    }
}
