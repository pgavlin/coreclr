using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _localloc_unwind_unwind01_small_unwind01_small_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_unwind_unwind01_small_unwind01_small_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\unwind\\unwind01_small\\unwind01_small.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
