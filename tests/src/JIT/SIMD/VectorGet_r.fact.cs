using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorGet_r_VectorGet_r_
    {
        [Fact]
        public void _VectorGet_r_VectorGet_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorGet_r\\VectorGet_r.cmd");
        }
    }
}
