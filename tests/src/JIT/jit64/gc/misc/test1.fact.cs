using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _gc_misc_test1_test1_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_test1_test1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\test1\\test1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
