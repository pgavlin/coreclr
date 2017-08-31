using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_misc__odbgnestval_cs__odbgnestval_cs_
    {
        [OuterLoop]
        [Fact]
        public void _Boxing_misc__odbgnestval_cs__odbgnestval_cs_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\misc\\_odbgnestval_cs\\_odbgnestval_cs.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
