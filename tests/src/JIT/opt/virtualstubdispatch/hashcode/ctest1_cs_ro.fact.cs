using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _virtualstubdispatch_hashcode_ctest1_cs_ro_ctest1_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _virtualstubdispatch_hashcode_ctest1_cs_ro_ctest1_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\virtualstubdispatch\\hashcode\\ctest1_cs_ro\\ctest1_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
