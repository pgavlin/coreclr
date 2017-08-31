using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _virtualstubdispatch_bigvtbl_bigvtbl_cs_d_bigvtbl_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _virtualstubdispatch_bigvtbl_bigvtbl_cs_d_bigvtbl_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\virtualstubdispatch\\bigvtbl\\bigvtbl_cs_d\\bigvtbl_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
