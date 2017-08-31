using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Inline_tests_Inline_SideAffects_Inline_SideAffects_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_Inline_SideAffects_Inline_SideAffects_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\Inline_SideAffects\\Inline_SideAffects.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
