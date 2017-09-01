using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _Mul_r_Mul_r_
    {
        [OuterLoop]
        [Fact]
        public void _Mul_r_Mul_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\Mul_r\\Mul_r.cmd");
        }
    }
}
