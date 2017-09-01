using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorMul_r_VectorMul_r_
    {
        [Fact]
        public void _VectorMul_r_VectorMul_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorMul_r\\VectorMul_r.cmd");
        }
    }
}
