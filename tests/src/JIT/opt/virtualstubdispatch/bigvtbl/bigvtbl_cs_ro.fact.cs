using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _virtualstubdispatch_bigvtbl_bigvtbl_cs_ro_bigvtbl_cs_ro_
    {
        [Fact]
        public void _virtualstubdispatch_bigvtbl_bigvtbl_cs_ro_bigvtbl_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\virtualstubdispatch\\bigvtbl\\bigvtbl_cs_ro\\bigvtbl_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
