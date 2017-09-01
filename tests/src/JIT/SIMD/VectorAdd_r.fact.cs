using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorAdd_r_VectorAdd_r_
    {
        [Fact]
        public void _VectorAdd_r_VectorAdd_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorAdd_r\\VectorAdd_r.cmd");
        }
    }
}
