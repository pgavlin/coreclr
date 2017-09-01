using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorCast_r_VectorCast_r_
    {
        [Fact]
        public void _VectorCast_r_VectorCast_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorCast_r\\VectorCast_r.cmd");
        }
    }
}
