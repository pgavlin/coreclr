using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_etc__dbgknight__dbgknight_
    {
        [OuterLoop]
        [Fact]
        public void _VT_etc__dbgknight__dbgknight_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\etc\\_dbgknight\\_dbgknight.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
