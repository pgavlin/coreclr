using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_misc__relconcurgc_il__relconcurgc_il_
    {
        [OuterLoop]
        [Fact]
        public void _Boxing_misc__relconcurgc_il__relconcurgc_il_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\misc\\_relconcurgc_il\\_relconcurgc_il.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
