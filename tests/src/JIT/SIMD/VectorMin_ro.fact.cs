using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorMin_ro_VectorMin_ro_
    {
        [Fact]
        public void _VectorMin_ro_VectorMin_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorMin_ro\\VectorMin_ro.cmd");
        }
    }
}
