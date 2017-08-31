using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_misc__orelenum_cs__orelenum_cs_
    {
        [OuterLoop]
        [Fact]
        public void _Boxing_misc__orelenum_cs__orelenum_cs_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\misc\\_orelenum_cs\\_orelenum_cs.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
