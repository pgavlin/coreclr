using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _CircleInConvex_r_CircleInConvex_r_
    {
        [Fact]
        public void _CircleInConvex_r_CircleInConvex_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\CircleInConvex_r\\CircleInConvex_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
