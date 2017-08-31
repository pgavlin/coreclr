using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_cse_HugeArray1_HugeArray1_
    {
        [Fact]
        public void _opt_cse_HugeArray1_HugeArray1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\HugeArray1\\HugeArray1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
