using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _VectorInitN_r_VectorInitN_r_
    {
        [Fact]
        public void _VectorInitN_r_VectorInitN_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\VectorInitN_r\\VectorInitN_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
