using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_etc__speed_dbghan2__speed_dbghan2_
    {
        [OuterLoop]
        [Fact]
        public void _VT_etc__speed_dbghan2__speed_dbghan2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\etc\\_speed_dbghan2\\_speed_dbghan2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
