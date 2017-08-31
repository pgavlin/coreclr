using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorMax_r_VectorMax_r_
    {
        [Fact]
        public void _VectorMax_r_VectorMax_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorMax_r\\VectorMax_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
