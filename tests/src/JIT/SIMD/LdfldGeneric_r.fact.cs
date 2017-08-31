using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _LdfldGeneric_r_LdfldGeneric_r_
    {
        [Fact]
        public void _LdfldGeneric_r_LdfldGeneric_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\LdfldGeneric_r\\LdfldGeneric_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
