using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_misc__il_dbgbinop__il_dbgbinop_
    {
        [OuterLoop]
        [Fact]
        public void _int64_misc__il_dbgbinop__il_dbgbinop_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\misc\\_il_dbgbinop\\_il_dbgbinop.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
