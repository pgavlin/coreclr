using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_callconv__dbginstance_il__dbginstance_il_
    {
        [Fact]
        public void _Boxing_callconv__dbginstance_il__dbginstance_il_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\callconv\\_dbginstance_il\\_dbginstance_il.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
