using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _localloc_zeroinit_zeroInit01_small_zeroInit01_small_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_zeroinit_zeroInit01_small_zeroInit01_small_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\zeroinit\\zeroInit01_small\\zeroInit01_small.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
