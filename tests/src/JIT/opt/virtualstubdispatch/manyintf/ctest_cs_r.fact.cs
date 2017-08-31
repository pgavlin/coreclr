using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _virtualstubdispatch_manyintf_ctest_cs_r_ctest_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _virtualstubdispatch_manyintf_ctest_cs_r_ctest_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\virtualstubdispatch\\manyintf\\ctest_cs_r\\ctest_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
