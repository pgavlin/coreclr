using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _tailcall__il_dbgtest_void__il_dbgtest_void_
    {
        [Fact]
        public void _tailcall__il_dbgtest_void__il_dbgtest_void_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\tailcall\\_il_dbgtest_void\\_il_dbgtest_void.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
