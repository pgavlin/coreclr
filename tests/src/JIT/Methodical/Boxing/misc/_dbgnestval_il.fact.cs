using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_misc__dbgnestval_il__dbgnestval_il_
    {
        [Fact]
        public void _Boxing_misc__dbgnestval_il__dbgnestval_il_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\misc\\_dbgnestval_il\\_dbgnestval_il.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
