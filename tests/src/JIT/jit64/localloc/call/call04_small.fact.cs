using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _localloc_call_call04_small_call04_small_
    {
        [Fact]
        public void _localloc_call_call04_small_call04_small_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\call\\call04_small\\call04_small.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
