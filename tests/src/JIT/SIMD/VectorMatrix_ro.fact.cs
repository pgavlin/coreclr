using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorMatrix_ro_VectorMatrix_ro_
    {
        [Fact]
        public void _VectorMatrix_ro_VectorMatrix_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorMatrix_ro\\VectorMatrix_ro.cmd");
        }
    }
}
