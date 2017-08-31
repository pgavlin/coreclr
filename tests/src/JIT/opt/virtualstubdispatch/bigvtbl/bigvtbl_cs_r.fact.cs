using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _virtualstubdispatch_bigvtbl_bigvtbl_cs_r_bigvtbl_cs_r_
    {
        [Fact]
        public void _virtualstubdispatch_bigvtbl_bigvtbl_cs_r_bigvtbl_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\virtualstubdispatch\\bigvtbl\\bigvtbl_cs_r\\bigvtbl_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
