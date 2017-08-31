using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _localloc_call_call05_large_call05_large_
    {
        [Fact]
        public void _localloc_call_call05_large_call05_large_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\call\\call05_large\\call05_large.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
