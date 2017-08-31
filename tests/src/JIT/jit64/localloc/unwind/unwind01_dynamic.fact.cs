using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _localloc_unwind_unwind01_dynamic_unwind01_dynamic_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_unwind_unwind01_dynamic_unwind01_dynamic_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\unwind\\unwind01_dynamic\\unwind01_dynamic.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
