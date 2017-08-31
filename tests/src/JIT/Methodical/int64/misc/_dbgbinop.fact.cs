using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_misc__dbgbinop__dbgbinop_
    {
        [OuterLoop]
        [Fact]
        public void _int64_misc__dbgbinop__dbgbinop_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\misc\\_dbgbinop\\_dbgbinop.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
