using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_callconv__dbginstance_cs__dbginstance_cs_
    {
        [Fact]
        public void _Boxing_callconv__dbginstance_cs__dbginstance_cs_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\callconv\\_dbginstance_cs\\_dbginstance_cs.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
