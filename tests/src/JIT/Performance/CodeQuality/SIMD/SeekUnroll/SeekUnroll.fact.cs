using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    public class _CodeQuality_SIMD_SeekUnroll_SeekUnroll_SeekUnroll_
    {
        [Fact]
        public void _CodeQuality_SIMD_SeekUnroll_SeekUnroll_SeekUnroll_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\SIMD\\SeekUnroll\\SeekUnroll\\SeekUnroll.cmd");
        }
    }
}
