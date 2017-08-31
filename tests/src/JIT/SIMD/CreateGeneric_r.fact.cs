using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _CreateGeneric_r_CreateGeneric_r_
    {
        [Fact]
        public void _CreateGeneric_r_CreateGeneric_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\CreateGeneric_r\\CreateGeneric_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
