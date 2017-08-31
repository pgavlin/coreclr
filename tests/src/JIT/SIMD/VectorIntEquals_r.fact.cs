using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorIntEquals_r_VectorIntEquals_r_
    {
        [OuterLoop]
        [Fact]
        public void _VectorIntEquals_r_VectorIntEquals_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorIntEquals_r\\VectorIntEquals_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
