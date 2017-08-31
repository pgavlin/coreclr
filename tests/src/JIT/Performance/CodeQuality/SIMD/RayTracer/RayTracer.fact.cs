using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_SIMD_RayTracer_RayTracer_RayTracer_
    {
        [Fact]
        public void _CodeQuality_SIMD_RayTracer_RayTracer_RayTracer_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\SIMD\\RayTracer\\RayTracer\\RayTracer.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
