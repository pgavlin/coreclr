using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _virtualstubdispatch_bigvtbl_bigvtbl_cs_do_bigvtbl_cs_do_
    {
        [Fact]
        public void _virtualstubdispatch_bigvtbl_bigvtbl_cs_do_bigvtbl_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\virtualstubdispatch\\bigvtbl\\bigvtbl_cs_do\\bigvtbl_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
