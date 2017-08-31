using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_cse_HugeField2_HugeField2_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cse_HugeField2_HugeField2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\HugeField2\\HugeField2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
