using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _localloc_call_call06_large_call06_large_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_call_call06_large_call06_large_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\call\\call06_large\\call06_large.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
