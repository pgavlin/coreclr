using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _tailcall__il_dbgtest_2b__il_dbgtest_2b_
    {
        [Fact]
        public void _tailcall__il_dbgtest_2b__il_dbgtest_2b_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\tailcall\\_il_dbgtest_2b\\_il_dbgtest_2b.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
