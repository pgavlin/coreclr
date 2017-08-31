using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _gc_misc_struct2_5_struct2_5_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_struct2_5_struct2_5_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\struct2_5\\struct2_5.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
