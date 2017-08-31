using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _localloc_call_call05_small_call05_small_
    {
        [Fact]
        public void _localloc_call_call05_small_call05_small_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\call\\call05_small\\call05_small.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
