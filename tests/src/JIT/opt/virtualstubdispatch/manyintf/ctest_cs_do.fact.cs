using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _virtualstubdispatch_manyintf_ctest_cs_do_ctest_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _virtualstubdispatch_manyintf_ctest_cs_do_ctest_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\virtualstubdispatch\\manyintf\\ctest_cs_do\\ctest_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
