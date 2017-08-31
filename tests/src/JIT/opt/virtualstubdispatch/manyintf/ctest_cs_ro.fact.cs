using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _virtualstubdispatch_manyintf_ctest_cs_ro_ctest_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _virtualstubdispatch_manyintf_ctest_cs_ro_ctest_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\virtualstubdispatch\\manyintf\\ctest_cs_ro\\ctest_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
