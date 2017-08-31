using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _virtualstubdispatch_hashcode_ctest1_cs_r_ctest1_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _virtualstubdispatch_hashcode_ctest1_cs_r_ctest1_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\virtualstubdispatch\\hashcode\\ctest1_cs_r\\ctest1_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
