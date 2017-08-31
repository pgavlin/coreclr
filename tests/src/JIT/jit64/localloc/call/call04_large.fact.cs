using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _localloc_call_call04_large_call04_large_
    {
        [Fact]
        public void _localloc_call_call04_large_call04_large_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\call\\call04_large\\call04_large.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
