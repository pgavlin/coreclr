using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorArrayInit_r_VectorArrayInit_r_
    {
        [Fact]
        public void _VectorArrayInit_r_VectorArrayInit_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorArrayInit_r\\VectorArrayInit_r.cmd");
        }
    }
}
