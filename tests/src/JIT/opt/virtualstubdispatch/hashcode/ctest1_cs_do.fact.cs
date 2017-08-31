using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _virtualstubdispatch_hashcode_ctest1_cs_do_ctest1_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _virtualstubdispatch_hashcode_ctest1_cs_do_ctest1_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\virtualstubdispatch\\hashcode\\ctest1_cs_do\\ctest1_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
