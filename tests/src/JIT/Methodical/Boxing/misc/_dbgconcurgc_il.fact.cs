using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_misc__dbgconcurgc_il__dbgconcurgc_il_
    {
        [OuterLoop]
        [Fact]
        public void _Boxing_misc__dbgconcurgc_il__dbgconcurgc_il_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\misc\\_dbgconcurgc_il\\_dbgconcurgc_il.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
