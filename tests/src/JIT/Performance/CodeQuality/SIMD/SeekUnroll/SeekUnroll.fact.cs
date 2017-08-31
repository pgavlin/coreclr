using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_SIMD_SeekUnroll_SeekUnroll_SeekUnroll_
    {
        [Fact]
        public void _CodeQuality_SIMD_SeekUnroll_SeekUnroll_SeekUnroll_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\SIMD\\SeekUnroll\\SeekUnroll\\SeekUnroll.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
