using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _virtualstubdispatch_mixed_mixed_cs_ro_mixed_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _virtualstubdispatch_mixed_mixed_cs_ro_mixed_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\virtualstubdispatch\\mixed\\mixed_cs_ro\\mixed_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
