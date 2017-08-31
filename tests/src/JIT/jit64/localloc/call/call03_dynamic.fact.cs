using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _localloc_call_call03_dynamic_call03_dynamic_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_call_call03_dynamic_call03_dynamic_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\call\\call03_dynamic\\call03_dynamic.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
