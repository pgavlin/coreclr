using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorSqrt_r_VectorSqrt_r_
    {
        [OuterLoop]
        [Fact]
        public void _VectorSqrt_r_VectorSqrt_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorSqrt_r\\VectorSqrt_r.cmd");
        }
    }
}
