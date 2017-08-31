using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _gc_misc_struct3_2_struct3_2_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_struct3_2_struct3_2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\struct3_2\\struct3_2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
