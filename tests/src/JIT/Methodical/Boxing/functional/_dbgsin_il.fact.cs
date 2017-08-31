using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_functional__dbgsin_il__dbgsin_il_
    {
        [OuterLoop]
        [Fact]
        public void _Boxing_functional__dbgsin_il__dbgsin_il_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\functional\\_dbgsin_il\\_dbgsin_il.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
