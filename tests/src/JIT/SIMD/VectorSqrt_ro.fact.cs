using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorSqrt_ro_VectorSqrt_ro_
    {
        [Fact]
        public void _VectorSqrt_ro_VectorSqrt_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorSqrt_ro\\VectorSqrt_ro.cmd");
        }
    }
}
