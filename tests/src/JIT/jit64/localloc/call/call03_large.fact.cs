using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _localloc_call_call03_large_call03_large_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_call_call03_large_call03_large_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\call\\call03_large\\call03_large.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
