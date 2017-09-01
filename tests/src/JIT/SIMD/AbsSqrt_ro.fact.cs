using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _AbsSqrt_ro_AbsSqrt_ro_
    {
        [Fact]
        public void _AbsSqrt_ro_AbsSqrt_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\AbsSqrt_ro\\AbsSqrt_ro.cmd");
        }
    }
}
