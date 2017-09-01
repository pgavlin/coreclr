using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorMin_r_VectorMin_r_
    {
        [Fact]
        public void _VectorMin_r_VectorMin_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorMin_r\\VectorMin_r.cmd");
        }
    }
}
