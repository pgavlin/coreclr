using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorInit_r_VectorInit_r_
    {
        [Fact]
        public void _VectorInit_r_VectorInit_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorInit_r\\VectorInit_r.cmd");
        }
    }
}
