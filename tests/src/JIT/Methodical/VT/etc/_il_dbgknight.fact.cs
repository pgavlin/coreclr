using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_etc__il_dbgknight__il_dbgknight_
    {
        [OuterLoop]
        [Fact]
        public void _VT_etc__il_dbgknight__il_dbgknight_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\etc\\_il_dbgknight\\_il_dbgknight.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
