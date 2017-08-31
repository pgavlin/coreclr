using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _refany__il_dbgarray2__il_dbgarray2_
    {
        [Fact]
        public void _refany__il_dbgarray2__il_dbgarray2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\_il_dbgarray2\\_il_dbgarray2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
