using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _gc_misc_struct4_5_struct4_5_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_struct4_5_struct4_5_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\struct4_5\\struct4_5.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
