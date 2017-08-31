using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Inline_tests_Inline_Vars_Inline_Vars_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_Inline_Vars_Inline_Vars_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\Inline_Vars\\Inline_Vars.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
