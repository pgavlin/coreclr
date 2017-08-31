using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _localloc_unwind_unwind03_dynamic_unwind03_dynamic_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_unwind_unwind03_dynamic_unwind03_dynamic_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\unwind\\unwind03_dynamic\\unwind03_dynamic.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
