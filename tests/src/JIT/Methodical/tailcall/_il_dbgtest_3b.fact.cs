using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _tailcall__il_dbgtest_3b__il_dbgtest_3b_
    {
        [OuterLoop]
        [Fact]
        public void _tailcall__il_dbgtest_3b__il_dbgtest_3b_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\tailcall\\_il_dbgtest_3b\\_il_dbgtest_3b.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
