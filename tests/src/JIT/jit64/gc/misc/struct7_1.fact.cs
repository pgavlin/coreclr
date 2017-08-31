using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _gc_misc_struct7_1_struct7_1_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_struct7_1_struct7_1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\struct7_1\\struct7_1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
