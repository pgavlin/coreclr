using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_functional__dbgfibo_il__dbgfibo_il_
    {
        [Fact]
        public void _Boxing_functional__dbgfibo_il__dbgfibo_il_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\functional\\_dbgfibo_il\\_dbgfibo_il.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
