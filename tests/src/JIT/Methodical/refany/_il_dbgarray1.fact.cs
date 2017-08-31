using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _refany__il_dbgarray1__il_dbgarray1_
    {
        [OuterLoop]
        [Fact]
        public void _refany__il_dbgarray1__il_dbgarray1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\_il_dbgarray1\\_il_dbgarray1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
