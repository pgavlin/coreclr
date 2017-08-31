using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_misc__dbgnestval_cs__dbgnestval_cs_
    {
        [Fact]
        public void _Boxing_misc__dbgnestval_cs__dbgnestval_cs_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\misc\\_dbgnestval_cs\\_dbgnestval_cs.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
