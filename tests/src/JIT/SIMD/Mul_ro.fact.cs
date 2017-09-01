using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _Mul_ro_Mul_ro_
    {
        [Fact]
        public void _Mul_ro_Mul_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\Mul_ro\\Mul_ro.cmd");
        }
    }
}
