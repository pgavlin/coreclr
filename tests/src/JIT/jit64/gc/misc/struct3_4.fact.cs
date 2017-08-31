using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _gc_misc_struct3_4_struct3_4_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_struct3_4_struct3_4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\struct3_4\\struct3_4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
