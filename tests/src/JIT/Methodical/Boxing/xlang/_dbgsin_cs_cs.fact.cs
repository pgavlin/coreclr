using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_xlang__dbgsin_cs_cs__dbgsin_cs_cs_
    {
        [OuterLoop]
        [Fact]
        public void _Boxing_xlang__dbgsin_cs_cs__dbgsin_cs_cs_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\xlang\\_dbgsin_cs_cs\\_dbgsin_cs_cs.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
