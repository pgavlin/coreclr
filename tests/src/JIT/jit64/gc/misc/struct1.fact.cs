using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _gc_misc_struct1_struct1_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_struct1_struct1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\struct1\\struct1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
