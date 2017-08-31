using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _gc_misc_alloca3_alloca3_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_alloca3_alloca3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\alloca3\\alloca3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
