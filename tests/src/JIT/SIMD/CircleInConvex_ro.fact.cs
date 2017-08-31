using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _CircleInConvex_ro_CircleInConvex_ro_
    {
        [Fact]
        public void _CircleInConvex_ro_CircleInConvex_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\CircleInConvex_ro\\CircleInConvex_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
