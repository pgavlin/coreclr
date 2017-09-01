using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _virtualstubdispatch_manyintf_ctest_cs_ro_ctest_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _virtualstubdispatch_manyintf_ctest_cs_ro_ctest_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\virtualstubdispatch\\manyintf\\ctest_cs_ro\\ctest_cs_ro.cmd");
        }
    }
}
