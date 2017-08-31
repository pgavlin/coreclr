using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _gc_misc_test3_test3_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_test3_test3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\test3\\test3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
