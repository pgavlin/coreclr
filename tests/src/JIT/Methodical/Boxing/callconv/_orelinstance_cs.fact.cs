using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_callconv__orelinstance_cs__orelinstance_cs_
    {
        [OuterLoop]
        [Fact]
        public void _Boxing_callconv__orelinstance_cs__orelinstance_cs_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\callconv\\_orelinstance_cs\\_orelinstance_cs.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
