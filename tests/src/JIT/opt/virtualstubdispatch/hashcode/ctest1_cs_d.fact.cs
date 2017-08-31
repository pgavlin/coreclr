using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _virtualstubdispatch_hashcode_ctest1_cs_d_ctest1_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _virtualstubdispatch_hashcode_ctest1_cs_d_ctest1_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\virtualstubdispatch\\hashcode\\ctest1_cs_d\\ctest1_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
