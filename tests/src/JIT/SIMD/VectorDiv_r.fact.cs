using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorDiv_r_VectorDiv_r_
    {
        [Fact]
        public void _VectorDiv_r_VectorDiv_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorDiv_r\\VectorDiv_r.cmd");
        }
    }
}
