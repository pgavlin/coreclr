using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_morph__orelsin_cs__orelsin_cs_
    {
        [OuterLoop]
        [Fact]
        public void _Boxing_morph__orelsin_cs__orelsin_cs_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\morph\\_orelsin_cs\\_orelsin_cs.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
