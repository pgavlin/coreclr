using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_deep__il_dbgdeep1__il_dbgdeep1_
    {
        [Fact]
        public void _Invoke_deep__il_dbgdeep1__il_dbgdeep1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\deep\\_il_dbgdeep1\\_il_dbgdeep1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
