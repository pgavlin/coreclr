using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_cse_HugeField1_HugeField1_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cse_HugeField1_HugeField1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\HugeField1\\HugeField1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
