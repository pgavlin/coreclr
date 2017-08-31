using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_morph__dbgsin_cs__dbgsin_cs_
    {
        [OuterLoop]
        [Fact]
        public void _Boxing_morph__dbgsin_cs__dbgsin_cs_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\morph\\_dbgsin_cs\\_dbgsin_cs.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
