using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorSet_r_VectorSet_r_
    {
        [Fact]
        public void _VectorSet_r_VectorSet_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorSet_r\\VectorSet_r.cmd");
        }
    }
}
