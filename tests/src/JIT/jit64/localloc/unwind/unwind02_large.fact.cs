using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _localloc_unwind_unwind02_large_unwind02_large_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_unwind_unwind02_large_unwind02_large_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\unwind\\unwind02_large\\unwind02_large.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
