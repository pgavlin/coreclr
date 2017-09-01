using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorExp_r_VectorExp_r_
    {
        [Fact]
        public void _VectorExp_r_VectorExp_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorExp_r\\VectorExp_r.cmd");
        }
    }
}
