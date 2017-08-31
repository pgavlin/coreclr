using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _localloc_unwind_unwind04_large_unwind04_large_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_unwind_unwind04_large_unwind04_large_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\unwind\\unwind04_large\\unwind04_large.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
