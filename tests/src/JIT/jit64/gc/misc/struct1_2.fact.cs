using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _gc_misc_struct1_2_struct1_2_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_struct1_2_struct1_2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\struct1_2\\struct1_2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
