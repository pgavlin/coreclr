using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorDot_r_VectorDot_r_
    {
        [Fact]
        public void _VectorDot_r_VectorDot_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorDot_r\\VectorDot_r.cmd");
        }
    }
}
