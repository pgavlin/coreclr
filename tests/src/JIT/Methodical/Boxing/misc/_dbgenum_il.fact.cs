using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_misc__dbgenum_il__dbgenum_il_
    {
        [OuterLoop]
        [Fact]
        public void _Boxing_misc__dbgenum_il__dbgenum_il_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\misc\\_dbgenum_il\\_dbgenum_il.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
