using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_etc__speed_dbgknight__speed_dbgknight_
    {
        [OuterLoop]
        [Fact]
        public void _VT_etc__speed_dbgknight__speed_dbgknight_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\etc\\_speed_dbgknight\\_speed_dbgknight.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
