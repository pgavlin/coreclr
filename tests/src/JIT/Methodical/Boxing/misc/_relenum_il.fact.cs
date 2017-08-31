using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_misc__relenum_il__relenum_il_
    {
        [Fact]
        public void _Boxing_misc__relenum_il__relenum_il_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\misc\\_relenum_il\\_relenum_il.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
