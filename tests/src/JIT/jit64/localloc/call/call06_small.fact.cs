using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _localloc_call_call06_small_call06_small_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_call_call06_small_call06_small_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\call\\call06_small\\call06_small.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
