using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _gc_misc_struct3_struct3_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_struct3_struct3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\struct3\\struct3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
