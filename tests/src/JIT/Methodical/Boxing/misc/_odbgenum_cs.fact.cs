using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_misc__odbgenum_cs__odbgenum_cs_
    {
        [OuterLoop]
        [Fact]
        public void _Boxing_misc__odbgenum_cs__odbgenum_cs_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\misc\\_odbgenum_cs\\_odbgenum_cs.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
