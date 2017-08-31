using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _opt_cse_HugeArray_HugeArray_
    {
        [OuterLoop]
        [Fact]
        public void _opt_cse_HugeArray_HugeArray_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\opt\\cse\\HugeArray\\HugeArray.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
