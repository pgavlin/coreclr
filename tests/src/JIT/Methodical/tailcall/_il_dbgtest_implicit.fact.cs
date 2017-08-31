using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _tailcall__il_dbgtest_implicit__il_dbgtest_implicit_
    {
        [Fact]
        public void _tailcall__il_dbgtest_implicit__il_dbgtest_implicit_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\tailcall\\_il_dbgtest_implicit\\_il_dbgtest_implicit.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
