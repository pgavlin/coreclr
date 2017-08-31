using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _virtualstubdispatch_mixed_mixed_cs_do_mixed_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _virtualstubdispatch_mixed_mixed_cs_do_mixed_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\virtualstubdispatch\\mixed\\mixed_cs_do\\mixed_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
