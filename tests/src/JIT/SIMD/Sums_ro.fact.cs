using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _Sums_ro_Sums_ro_
    {
        [Fact]
        public void _Sums_ro_Sums_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\Sums_ro\\Sums_ro.cmd");
        }
    }
}
