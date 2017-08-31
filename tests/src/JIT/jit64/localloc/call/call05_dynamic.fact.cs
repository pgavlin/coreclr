using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _localloc_call_call05_dynamic_call05_dynamic_
    {
        [Fact]
        public void _localloc_call_call05_dynamic_call05_dynamic_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\call\\call05_dynamic\\call05_dynamic.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
