using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _localloc_zeroinit_zeroinit01_large_zeroinit01_large_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_zeroinit_zeroinit01_large_zeroinit01_large_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\zeroinit\\zeroinit01_large\\zeroinit01_large.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
