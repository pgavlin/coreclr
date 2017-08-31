using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_functional__dbgfibo_cs__dbgfibo_cs_
    {
        [OuterLoop]
        [Fact]
        public void _Boxing_functional__dbgfibo_cs__dbgfibo_cs_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\functional\\_dbgfibo_cs\\_dbgfibo_cs.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
