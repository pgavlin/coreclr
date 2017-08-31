using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _gc_misc_148343_148343_
    {
        [OuterLoop]
        [Fact]
        public void _gc_misc_148343_148343_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\gc\\misc\\148343\\148343.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
