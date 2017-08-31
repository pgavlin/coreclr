using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _virtualstubdispatch_manyintf_ctest_cs_d_ctest_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _virtualstubdispatch_manyintf_ctest_cs_d_ctest_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\virtualstubdispatch\\manyintf\\ctest_cs_d\\ctest_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
