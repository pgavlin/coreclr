using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _localloc_unwind_unwind04_dynamic_unwind04_dynamic_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_unwind_unwind04_dynamic_unwind04_dynamic_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\unwind\\unwind04_dynamic\\unwind04_dynamic.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
