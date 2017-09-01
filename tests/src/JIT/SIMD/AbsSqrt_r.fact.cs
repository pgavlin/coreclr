using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _AbsSqrt_r_AbsSqrt_r_
    {
        [Fact]
        public void _AbsSqrt_r_AbsSqrt_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\AbsSqrt_r\\AbsSqrt_r.cmd");
        }
    }
}
