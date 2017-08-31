using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _refany__il_dbgstress2__il_dbgstress2_
    {
        [OuterLoop]
        [Fact]
        public void _refany__il_dbgstress2__il_dbgstress2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\_il_dbgstress2\\_il_dbgstress2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
