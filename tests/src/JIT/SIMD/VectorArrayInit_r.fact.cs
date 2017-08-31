using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorArrayInit_r_VectorArrayInit_r_
    {
        [Fact]
        public void _VectorArrayInit_r_VectorArrayInit_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorArrayInit_r\\VectorArrayInit_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
