using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _gc_misc_struct2_5_2_struct2_5_2_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_struct2_5_2_struct2_5_2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\struct2_5_2\\struct2_5_2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
