using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _gc_misc_struct3_5_struct3_5_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_struct3_5_struct3_5_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\struct3_5\\struct3_5.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
