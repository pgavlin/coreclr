using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _gc_misc_structref1_1_structref1_1_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_structref1_1_structref1_1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\structref1_1\\structref1_1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
