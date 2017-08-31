using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _localloc_call_call04_dynamic_call04_dynamic_
    {
        [Fact]
        public void _localloc_call_call04_dynamic_call04_dynamic_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\call\\call04_dynamic\\call04_dynamic.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
