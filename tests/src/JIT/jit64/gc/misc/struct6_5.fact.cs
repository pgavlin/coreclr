using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _gc_misc_struct6_5_struct6_5_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_struct6_5_struct6_5_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\struct6_5\\struct6_5.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
