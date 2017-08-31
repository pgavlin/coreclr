using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _localloc_unwind_unwind06_large_unwind06_large_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_unwind_unwind06_large_unwind06_large_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\unwind\\unwind06_large\\unwind06_large.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
