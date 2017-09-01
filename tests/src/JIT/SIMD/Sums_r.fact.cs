using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _Sums_r_Sums_r_
    {
        [Fact]
        public void _Sums_r_Sums_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\Sums_r\\Sums_r.cmd");
        }
    }
}
