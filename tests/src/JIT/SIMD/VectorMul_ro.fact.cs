using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorMul_ro_VectorMul_ro_
    {
        [Fact]
        public void _VectorMul_ro_VectorMul_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorMul_ro\\VectorMul_ro.cmd");
        }
    }
}
