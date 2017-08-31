using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorInit_r_VectorInit_r_
    {
        [Fact]
        public void _VectorInit_r_VectorInit_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorInit_r\\VectorInit_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
