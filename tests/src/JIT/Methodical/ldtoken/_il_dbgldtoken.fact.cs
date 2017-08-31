using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _ldtoken__il_dbgldtoken__il_dbgldtoken_
    {
        [OuterLoop]
        [Fact]
        public void _ldtoken__il_dbgldtoken__il_dbgldtoken_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\ldtoken\\_il_dbgldtoken\\_il_dbgldtoken.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
