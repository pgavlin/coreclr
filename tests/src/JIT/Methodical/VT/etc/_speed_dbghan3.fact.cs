using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_etc__speed_dbghan3__speed_dbghan3_
    {
        [OuterLoop]
        [Fact]
        public void _VT_etc__speed_dbghan3__speed_dbghan3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\etc\\_speed_dbghan3\\_speed_dbghan3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
