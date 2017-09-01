using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorMatrix_r_VectorMatrix_r_
    {
        [Fact]
        public void _VectorMatrix_r_VectorMatrix_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorMatrix_r\\VectorMatrix_r.cmd");
        }
    }
}
