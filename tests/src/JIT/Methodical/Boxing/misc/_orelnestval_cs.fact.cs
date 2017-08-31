using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_misc__orelnestval_cs__orelnestval_cs_
    {
        [Fact]
        public void _Boxing_misc__orelnestval_cs__orelnestval_cs_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\misc\\_orelnestval_cs\\_orelnestval_cs.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
